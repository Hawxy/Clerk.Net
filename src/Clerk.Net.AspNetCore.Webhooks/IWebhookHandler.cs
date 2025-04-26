namespace Clerk.Net.AspNetCore.Webhooks;

public interface IWebhookHandler<in TEvent> where TEvent : class
{
    public Task HandleAsync(TEvent request);
}