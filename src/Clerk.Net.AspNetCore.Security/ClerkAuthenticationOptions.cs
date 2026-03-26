namespace Clerk.Net.AspNetCore.Security;

/// <summary>
/// Options used configure Clerk authentication.
/// </summary>
public sealed class ClerkAuthenticationOptions
{
    /// <summary>
    /// Sets the authorized party. This should be the front-end URL if your application.
    /// We highly recommend configuring this for improved security.
    /// </summary>
    [Obsolete("Use AuthorizedParties instead.")]
    public string? AuthorizedParty { get; set; } = null!;
    
    /// <summary>
    /// Sets the authorized parties. These should be the front-end URLs of your application.
    /// We highly recommend configuring this for improved security.
    /// </summary>
    public List<string>? AuthorizedParties { get; set; } = null!;
    
    /// <summary>
    /// The Frontend URI of your Clerk instance.
    /// </summary>
    public string Authority { get; set; } = null!;
}