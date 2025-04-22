using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;

namespace Clerk.Net.AspNetCore.Webhooks;

/// <summary>
/// Service Collection Extensions used to register Webhook services.
/// </summary>
public static class ServiceCollectionExtensions
{
    public static ClerkWebhookBuilder AddClerkWebhooks(this IServiceCollection collection, Action<ClerkWebhookOptions> options)
    {
        collection.AddOptions<ClerkWebhookOptions>().Configure(options);

        return new ClerkWebhookBuilder(collection);
    }
}

public sealed class ClerkWebhookBuilder
{
    private readonly IServiceCollection _collection;

    public ClerkWebhookBuilder(IServiceCollection collection)
    {
        _collection = collection;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEvent">The event type being registered</typeparam>
    /// <typeparam name="THandler">The type of handler being registered</typeparam>
    /// <returns></returns>
    public ClerkWebhookBuilder RegisterHandler<TEvent, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]THandler>() where THandler : class, IClerkWebhookHandler<TEvent> where TEvent : class
    {
        _collection.AddKeyedSingleton<IClerkWebhookHandler<TEvent>, THandler>($"handler-{nameof(TEvent)}");
        return this;
    }
}