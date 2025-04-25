using Alba;
using Clerk.Net.AspNetCore.Tests.Webhooks;
using Clerk.Net.Client;
using Svix;

namespace Clerk.Net.AspNetCore.Tests;

public abstract class AlbaTestBase(AlbaBootstrap albaBootstrap)
{
    protected IAlbaHost Host => albaBootstrap.Host;
    protected ClerkApiClient ClerkApiClient => albaBootstrap.ClerkApiClient;

    internal Webhook SvixWebhook = new Webhook(SvixDefaults.SvixSecret);
    
    protected T Generate<T>()
    {
        return Faker.Instance.Generate<T>();
    }
}