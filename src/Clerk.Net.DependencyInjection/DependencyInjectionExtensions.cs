using Clerk.Net.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

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
    public static void AddClerkApiClient(this IServiceCollection collection, Action<ClerkApiClientOptions> options)
    {
        ArgumentNullException.ThrowIfNull(options);
        
        collection.AddHttpClient(ClerkHttpClient)
            .ConfigurePrimaryHttpMessageHandler(() => 
                new SocketsHttpHandler()
                {
                    PooledConnectionLifetime = TimeSpan.FromMinutes(2)
                })
            .SetHandlerLifetime(Timeout.InfiniteTimeSpan);

        collection.Configure(options);

        collection.AddSingleton<ClerkApiClient>(x =>
        {
            var clientOptions = x.GetRequiredService<IOptions<ClerkApiClientOptions>>();
            var httpClient = x.GetRequiredService<IHttpClientFactory>().CreateClient(ClerkHttpClient);

            return ClerkApiClientFactory.Create(clientOptions.Value.SecretKey, httpClient);
        });

    }
}