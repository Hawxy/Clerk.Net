using System.Diagnostics.CodeAnalysis;
using Clerk.Net.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware;
using Microsoft.Kiota.Http.HttpClientLibrary.Middleware.Options;

namespace Clerk.Net.DependencyInjection;

/// <summary>
/// Extensions for registering <see cref="ClerkApiClient"/> with <see cref="IServiceCollection"/>
/// </summary>
public static class DependencyInjectionExtensions
{
    private const string ClerkHttpClient = nameof(ClerkHttpClient);
    
    /// <summary>
    /// Adds a singleton instance of <see cref="ClerkApiClient"/> to the container.
    /// </summary>
    /// <param name="collection">The service collection.</param>
    /// <param name="options">The lambda that configures the client.</param>
    /// <returns>A <see cref="IHttpClientBuilder"/> instance that can be used to additionally configure the underlying <see cref="HttpClient"/>.</returns>
    public static IHttpClientBuilder AddClerkApiClient(this IServiceCollection collection, Action<ClerkApiClientOptions> options)
    {
        ArgumentNullException.ThrowIfNull(options);
        
        var clientBuilder = collection.AddHttpClient(ClerkHttpClient)
            .ConfigurePrimaryHttpMessageHandler(() => 
                new SocketsHttpHandler()
                {
                    PooledConnectionLifetime = TimeSpan.FromMinutes(2)
                })
            .SetHandlerLifetime(Timeout.InfiniteTimeSpan);
       
        
        var types = KiotaClientFactory.GetDefaultHandlerActivatableTypes();
        
        foreach (var type in types)
        {
            collection.TryAddTransient(type);
            clientBuilder.AddHttpMessageHandler(sp => (DelegatingHandler)sp.GetRequiredService(type));
        }

        collection.Configure(options);

        collection.AddSingleton<ClerkApiClient>(x =>
        {
            var clientOptions = x.GetRequiredService<IOptions<ClerkApiClientOptions>>();
            var httpClient = x.GetRequiredService<IHttpClientFactory>().CreateClient(ClerkHttpClient);

            return ClerkApiClientFactory.Create(clientOptions.Value.SecretKey, httpClient);
        });

        return clientBuilder;
    }
}