using System.Collections.Concurrent;
using System.Reflection;
using System.Text.Json;
using Clerk.Net.AspNetCore.Webhooks.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Svix;

namespace Clerk.Net.AspNetCore.Webhooks;

internal sealed class WebhookInvoker
{
    private static readonly ConcurrentDictionary<string, MethodInvoker> MethodLookup = new();

    public static async Task InvokeAsync(HttpContext context, ILogger<WebhookInvoker> logger, IOptions<WebhookOptions> options, EventMap eventMap)
    {
        var wh = new Webhook(options.Value.WebhookSecret);
        // auth
        using var reader = new StreamReader(context.Request.Body, leaveOpen: true);
        var payload = await reader.ReadToEndAsync();
        try
        {
            wh.Verify(payload, header => context.Request.Headers[header]);
        }
        catch (Svix.Exceptions.WebhookVerificationException ex)
        {
            logger.LogDebug(ex, "Webhook signature verification failed");
            context.Response.StatusCode = 401;
            return;
        }
        catch (Exception ex)
        {
            logger.LogDebug(ex, "Webhook signature verification threw unexpected exception");
            context.Response.StatusCode = 401;
            return;
        }
        
        // type validation
        using var document = JsonDocument.Parse(payload);

        var typeLookup = document.RootElement.GetProperty("type").GetString();

        if (string.IsNullOrEmpty(typeLookup) || !eventMap.TryGetEvent(typeLookup, out var type))
        {
            logger.LogDebug("Webhook payload did not contain valid or known event type '{Type}'",
                typeLookup ?? "N/A");
            context.Response.StatusCode = 400;
            return;
        }

        // handler validation
        var key = $"handler-{type.Name}";

        var provider = (IKeyedServiceProvider)context.RequestServices;

        var handler = provider.GetKeyedService(typeof(IWebhookHandler<>), key);

        if (handler is null)
        {
            if(options.Value.WarnOnMissingHandler)
                logger.LogWarning("No webhook handler is registered for incoming webhook event type {Type}", typeLookup);
            context.Response.StatusCode = 200;
            return;
        }
        
        // deserialization
        object? deserializedPayload;
        try
        {
            deserializedPayload = document.Deserialize(type, WebhookSerializationContext.Default);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Webhook payload was unable to be deserialized");
            context.Response.StatusCode = 500;
            return;
        }
        
        var invoker = MethodLookup.GetOrAdd(key, static (_, t) =>
        {
            var method = typeof(IWebhookHandler<>).MakeGenericType(t).GetMethod("HandleAsync")!;
            return MethodInvoker.Create(method);
        }, type);

        try
        {
            // handler invoke
            var result = (Task)invoker.Invoke(handler, deserializedPayload)!;
            await result;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Webhook Handler {Type} threw unhandled exception", handler.GetType().Name);
            context.Response.StatusCode = 500;
        }
       
    }
    
    
}