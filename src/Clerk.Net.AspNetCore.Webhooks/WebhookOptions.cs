namespace Clerk.Net.AspNetCore.Webhooks;

public sealed class WebhookOptions
{
    /// <summary>
    /// The Webhook Secret
    /// </summary>
    public string WebhookSecret { get; set; }
    
    /// <summary>
    /// Enables a warning log if a webhook event arrives with no registered handler
    /// </summary>
    public bool WarnOnMissingHandler { get; set; }
    
}