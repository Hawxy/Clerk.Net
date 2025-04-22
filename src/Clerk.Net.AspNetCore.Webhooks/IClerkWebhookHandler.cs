namespace Clerk.Net.AspNetCore.Webhooks;

public interface IClerkWebhookHandler<in TEvent> where TEvent : class
{
    public Task HandleAsync(TEvent request);
}