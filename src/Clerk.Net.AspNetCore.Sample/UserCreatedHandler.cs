using Clerk.Net.AspNetCore.Webhooks;
using Clerk.Net.AspNetCore.Webhooks.Models.User;

namespace Clerk.Net.AspNetCore.Sample;

public class UserCreatedHandler : IWebhookHandler<UserCreatedEvent>
{
    public Task HandleAsync(UserCreatedEvent request)
    {
        return Task.CompletedTask;
    }
}