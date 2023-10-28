using Clerk.Net.Client;

namespace Clerk.Net.DependencyInjection;
/// <summary>
/// Client options for the underlying <see cref="ClerkApiClient"/>
/// </summary>
public sealed class ClerkApiClientOptions
{
    /// <summary>
    /// Secret Key from your Clerk instance.
    /// </summary>
    public string SecretKey { get; set; } = null!;
}