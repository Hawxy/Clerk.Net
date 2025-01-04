using Clerk.Net.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Clerk.Net;

/// <summary>
/// A factory for creating a <see cref="ClerkApiClient"/>
/// </summary>
public static class ClerkApiClientFactory
{
    /// <summary>
    /// Creates a new <see cref="ClerkApiClient"/> with the provided configuration. For performance, you should treat this client as a singleton.
    /// </summary>
    /// <param name="secretKey">The Secret Key from your Clerk instance.</param>
    /// <param name="httpClient">An optional <see cref="HttpClient"/> for advanced use.</param>
    /// <returns>The <see cref="ClerkApiClient"/></returns>
    public static ClerkApiClient Create(string secretKey, HttpClient? httpClient = null)
    {
        if (string.IsNullOrEmpty(secretKey))
            throw new ArgumentNullException(nameof(secretKey));
        
        var authProvider = new ApiKeyAuthenticationProvider($"Bearer {secretKey}", "Authorization", ApiKeyAuthenticationProvider.KeyLocation.Header);
        var adapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
        return new ClerkApiClient(adapter);
    }
}