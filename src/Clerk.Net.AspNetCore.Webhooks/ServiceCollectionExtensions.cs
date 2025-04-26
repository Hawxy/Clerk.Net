using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;

namespace Clerk.Net.AspNetCore.Webhooks;

/// <summary>
/// Service Collection Extensions used to register Webhook services.
/// </summary>
public static class ServiceCollectionExtensions
{
    public static WebhookBuilder AddWebhooks(this IServiceCollection collection, Action<WebhookOptions> options)
    {
        collection.AddOptions<WebhookOptions>().Configure(options);

        return new WebhookBuilder(collection);
    }
}

public sealed class WebhookBuilder
{
    private readonly IServiceCollection _collection;

    public WebhookBuilder(IServiceCollection collection)
    {
        _collection = collection;
    }

    public WebhookBuilder ConfigureEventMap(Action<EventMapBuilder> builder)
    {
        var internalBuilder = new EventMapBuilder();
        builder.Invoke(internalBuilder);
        _collection.AddSingleton(internalBuilder.Build());
        return this;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEvent">The event type being registered</typeparam>
    /// <typeparam name="THandler">The type of handler being registered</typeparam>
    /// <returns></returns>
    public WebhookBuilder RegisterHandler<TEvent, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]THandler>() where THandler : class, IWebhookHandler<TEvent> where TEvent : class
    {
        _collection.AddKeyedSingleton<IWebhookHandler<TEvent>, THandler>($"handler-{nameof(TEvent)}");
        return this;
    }
}