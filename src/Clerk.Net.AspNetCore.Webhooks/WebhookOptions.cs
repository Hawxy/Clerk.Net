using System.Collections.Frozen;
using System.Text.Json;

namespace Clerk.Net.AspNetCore.Webhooks;

public sealed class WebhookGlobalOptions
{
    /// <summary>
    /// Enables a warning log if a webhook event arrives with no registered handler
    /// </summary>
    public bool WarnOnMissingHandler { get; set; }
}

public sealed class WebhookProfileBuilder
{
    private JsonSerializerOptions _serializerOptions = new(JsonSerializerDefaults.Web);

    private EventMapBuilder _eventMapBuilder = new EventMapBuilder();

    private string _webhookSecret;

    public WebhookProfileBuilder WithWebhookSecret(string secret)
    {
        _webhookSecret = secret;
        return this;
    }
    
    public WebhookProfileBuilder WithSerializerOptions(Action<JsonSerializerOptions> options)
    {
        options(_serializerOptions);
        return this;
    }

    public WebhookProfileBuilder WithEventMap(Action<EventMapBuilder> eventMapBuilder)
    {
        eventMapBuilder(_eventMapBuilder);
        return this;
    }

    internal void Apply(WebhookProfileOptions instance)
    {
        instance.WebhookSecret = _webhookSecret;
        instance.SerializerOptions = _serializerOptions;
        instance.EventMap = _eventMapBuilder.Build();
    }
    
}

public sealed class WebhookProfileOptions
{
    /// <summary>
    /// The Webhook Secret
    /// </summary>
    public string WebhookSecret { get; set; }
    
    public JsonSerializerOptions SerializerOptions { get; set; } = new(JsonSerializerDefaults.Web);
    
    /// <summary>
    /// Configure how the inbound type name maps to an event type.
    /// </summary>
    public EventMap EventMap { get; set; }
    
}