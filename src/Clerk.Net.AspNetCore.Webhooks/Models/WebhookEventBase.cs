using System.Text.Json.Serialization;

namespace Clerk.Net.AspNetCore.Webhooks.Models;

public abstract class WebhookEventBase<T> where T: class
{
    [JsonPropertyName("data")]
    public T Data { get; set; }

    [JsonPropertyName("event_attributes")]
    public EventAttributes EventAttributes { get; set; }

    [JsonPropertyName("object")]
    public string Object { get; set; }

    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}


public class EventAttributes
{
    [JsonPropertyName("http_request")]
    public HttpRequest HttpRequest { get; set; }
}

public class HttpRequest
{
    [JsonPropertyName("client_ip")]
    public string ClientIp { get; set; }

    [JsonPropertyName("user_agent")]
    public string UserAgent { get; set; }
}