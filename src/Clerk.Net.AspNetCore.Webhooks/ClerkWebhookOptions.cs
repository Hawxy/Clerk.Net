namespace Clerk.Net.AspNetCore.Webhooks;

public sealed class ClerkWebhookOptions
{
    /// <summary>
    /// The Clerk Webhook Secret
    /// </summary>
    public string WebhookSecret { get; set; }
    
    /// <summary>
    /// Enables a warning log if a webhook event arrives with no registered handler
    /// </summary>
    public bool WarnOnMissingHandler { get; set; }
    
}