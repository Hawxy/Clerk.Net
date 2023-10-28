namespace Clerk.Net.Tests;

public class ClientTests
{
    [Fact]
    public void ClientFactory_Works()
    {
        var client = ClerkApiClientFactory.Create("invalid_key");
        Assert.NotNull(client);
    }
}