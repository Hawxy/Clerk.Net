using Clerk.Net.Client;
using Clerk.Net.Client.Sessions;
using Clerk.Net.Client.Sessions.Item.Tokens;

namespace Clerk.Net.AspNetCore.Tests;

public static class SessionHelpers
{
    public static async Task<string> GetSessionJwt(this ClerkApiClient client)
    {
        var session = await client.Sessions.PostAsync(new SessionsPostRequestBody()
        {
            UserId = "user_2tUF4eharmgez5S9F30GoklcQeE"
        });
        
        var tokenResponse = await client.Sessions[session!.Id].Tokens.PostAsync(new TokensPostRequestBody());

        return tokenResponse!.Jwt!;
    }
}