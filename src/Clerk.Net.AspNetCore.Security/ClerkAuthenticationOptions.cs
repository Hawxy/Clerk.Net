namespace Clerk.Net.AspNetCore.Security;

/// <summary>
/// Options used configure Clerk authentication.
/// </summary>
public sealed class ClerkAuthenticationOptions
{
    /// <summary>
    /// Sets the authorized party we should check against. We highly recommend configuring this for security reasons.
    /// </summary>
    public string? AuthorizedParty { get; set; } = null!;
    
    /// <summary>
    /// The Frontend URI of your Clerk instance.
    /// </summary>
    public string Authority { get; set; } = null!;
}