using Clerk.Net.Client;
using Clerk.Net.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace Clerk.Net.Tests;

public class ExtensionTests
{
    [Fact]
    public void ClientExtension_WorksAsExpected()
    {
        var collection = new ServiceCollection();
        
        collection.AddClerkApiClient(options =>
        {
            options.SecretKey = "fake_secret";
        });

        var provider = collection.BuildServiceProvider();

        var client = provider.GetService<ClerkApiClient>();
        Assert.NotNull(client);
        

    }
}