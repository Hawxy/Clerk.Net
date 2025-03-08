using Clerk.Net.Client;
using Clerk.Net.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Shouldly;

namespace Clerk.Net.Tests;

public class ExtensionTests
{
    [Test]
    public void ClientExtension_WorksAsExpected()
    {
        var collection = new ServiceCollection();
        
        collection.AddClerkApiClient(options =>
        {
            options.SecretKey = "fake_secret";
        });

        var provider = collection.BuildServiceProvider();

        var client = provider.GetService<ClerkApiClient>();
        client.ShouldNotBeNull();
    }
}