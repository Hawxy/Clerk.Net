namespace Clerk.Net.Tests;

public class ClientTests
{
    [Fact]
    public void ClientFactory_Works()
    {
        var client = ClerkApiClientFactory.Create("invalid_key");
        Assert.NotNull(client);
    }

    [Fact]
    public void KiotaOptions_Returns_CorrectUserAgent()
    {
        var options = KiotaHandlerConfiguration.UserAgentHandlerOption;
        
        Assert.Equal("Clerk.Net", options.ProductName);
        Assert.NotNull(options.ProductVersion);
        Assert.DoesNotContain('+', options.ProductVersion);
    }
}