using Clerk.Net.AspNetCore.Webhooks;
using Clerk.Net.AspNetCore.Webhooks.Models.User;

namespace Clerk.Net.AspNetCore.Sample;

public class UserCreatedHandler : IClerkWebhookHandler<UserCreatedEvent>
{
    public Task HandleAsync(UserCreatedEvent request)
    {
        throw new NotImplementedException();
    }
}