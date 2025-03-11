using System.Collections.Concurrent;
using System.Collections.Frozen;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text.Json;

namespace Clerk.Net.JwtSample;


public record UserEvent();

public record OrganizationEvent();

public static class EventMap
{
    private static readonly FrozenDictionary<string, Type> _map = new Dictionary<string, Type>()
    {
        { "user.event.create", typeof(UserEvent) },
    }.ToFrozenDictionary();

    public static bool TryGetEvent(string @name, [NotNullWhen(true)]out Type? type)
    {
        return _map.TryGetValue(@name, out type);
    }
}



public interface IClerkWebhookHandler<in TEvent> where TEvent : class
{
    public Task HandleAsync(TEvent request);
}

public class UserHandler : IClerkWebhookHandler<UserEvent>
{
    public Task HandleAsync(UserEvent request)
    {
        throw new NotImplementedException();
    }
}

public static class DiExtensions
{
    public static void AddHandler<TEvent, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]THandler>(this IServiceCollection collection) where THandler : class, IClerkWebhookHandler<TEvent> where TEvent : class
    {
        collection.AddTransient<Middleware>();
        collection.AddKeyedSingleton<IClerkWebhookHandler<TEvent>, THandler>($"handler-{nameof(TEvent)}");
    }
}


public class Middleware() : IMiddleware
{
    private static readonly ConcurrentDictionary<string, MethodInvoker> MethodLookup = new();
    
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
      
        var document = await context.Request.ReadFromJsonAsync<JsonDocument>();

        var typeLookup = document.RootElement.GetProperty("type").GetString();

        if (!EventMap.TryGetEvent(typeLookup, out var type))
        {
            
        }

        var dec = document.Deserialize()
        var key = $"handler-{type.Name}";
        
        var provider = (IKeyedServiceProvider)context.RequestServices;
        
        var handler = provider.GetKeyedService(typeof(IClerkWebhookHandler<>), key);

        if (handler is null)
            return;

        var invoker = MethodLookup.GetOrAdd(key, static (_, t) =>
        {
            var method = typeof(IClerkWebhookHandler<>).MakeGenericType(t).GetMethod("HandleAsync")!;
            return MethodInvoker.Create(method);
        }, type);


        invoker.Invoke(handler);
        
        document.Dispose();
    }

    public async Task MatchHandlerAsync(JsonDocument document, IKeyedServiceProvider provider)
    {
        var typeLookup = document.RootElement.GetProperty("type").GetString();

        if (typeLookup == "user.event.created")
        {
            await ExecuteHandlerAsync<UserEvent>(document, "handler-user.event.created", provider);
        }
    }

    public async Task ExecuteHandlerAsync<TEvent>(JsonDocument document, string key, IKeyedServiceProvider provider) where TEvent: class
    {
        var handler = provider.GetKeyedService<IClerkWebhookHandler<TEvent>>(key);
        await handler.HandleAsync(document.Deserialize<TEvent>());
    }
}