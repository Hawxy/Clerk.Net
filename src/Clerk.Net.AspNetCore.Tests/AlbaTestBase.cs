using Alba;
using Clerk.Net.Client;

namespace Clerk.Net.AspNetCore.Tests;

public abstract class AlbaTestBase(AlbaBootstrap albaBootstrap)
{
    protected IAlbaHost Host => albaBootstrap.Host;
    protected ClerkApiClient ClerkApiClient => albaBootstrap.ClerkApiClient;
}