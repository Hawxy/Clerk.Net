using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;

namespace Clerk.Net.AspNetCore.Webhooks;

/// <summary>
/// Service Collection Extensions used to register Webhook services.
/// </summary>
public static class ServiceCollectionExtensions
{
    public static WebhookBuilder AddWebhooks(this IServiceCollection collection, Action<WebhookGlobalOptions>? options = null)
    {
        var builder = collection.AddOptions<WebhookGlobalOptions>();

        if (options is not null)
            builder.Configure(options);

        return new WebhookBuilder(collection);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEvent">The event type being registered</typeparam>
    /// <typeparam name="THandler">The type of handler being registered</typeparam>
    /// <returns></returns>
    public static IServiceCollection AddWebhookHandler<TEvent, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]THandler>(this IServiceCollection collection) where THandler : class, IWebhookHandler<TEvent> where TEvent : class
    {
        collection.AddKeyedSingleton<IWebhookHandler<TEvent>, THandler>($"handler-{nameof(TEvent)}");
        return collection;
    }
}

public sealed class WebhookBuilder
{
    private readonly IServiceCollection _collection;

    public WebhookBuilder(IServiceCollection collection)
    {
        _collection = collection;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="options"></param>
    /// <returns></returns>
    public WebhookBuilder AddProfile(string name, Action<WebhookProfileBuilder> options)
    {
        var builder = new WebhookProfileBuilder();
        options(builder);
        
        _collection.AddOptions<WebhookProfileOptions>(name).Configure(x=> builder.Apply(x));
        return this;
    }
    

}