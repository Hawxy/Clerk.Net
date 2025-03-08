using Shouldly;

namespace Clerk.Net.Tests;

public class ClientTests
{
    [Test]
    public void ClientFactory_Works()
    {
        var client = ClerkApiClientFactory.Create("invalid_key");
        client.ShouldNotBeNull();
    }

    [Test]
    public void KiotaOptions_Returns_CorrectUserAgent()
    {
        var options = KiotaHandlerConfiguration.UserAgentHandlerOption;
        options.ProductName.ShouldBe("Clerk.Net");
        options.ProductVersion.ShouldNotBeNull();
        options.ProductVersion.ShouldNotContain('+');
    }
}