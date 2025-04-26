using System.Net;
using System.Text.Json;
using Alba;
using Clerk.Net.AspNetCore.Webhooks.Models.User;

namespace Clerk.Net.AspNetCore.Tests.Webhooks;

[ClassDataSource<AlbaBootstrap>(Shared = SharedType.PerTestSession)]
public class ApiTests(AlbaBootstrap albaBootstrap) : AlbaTestBase(albaBootstrap)
{
    [Test]
    public async Task SubmitsWebhook_HappyPath()
    {
        var svixId = Guid.NewGuid().ToString();
        var timeStamp = DateTimeOffset.Now;
        
        var payload = JsonSerializer.Serialize(UserCreatedPayload.Instance, JsonSerializerOptions.Web);

        var signature = SvixWebhook.Sign(svixId, timeStamp, payload);
        await Host.Scenario(c =>
        {
            c.Post.Json(UserCreatedPayload.Instance).ToUrl("/webhooks");
            
            c.WithRequestHeader(SvixDefaults.SvixId, svixId);
            c.WithRequestHeader(SvixDefaults.SvixTimestamp, timeStamp.ToUnixTimeSeconds().ToString());
            c.WithRequestHeader(SvixDefaults.SvixSignature, signature);

            c.StatusCodeShouldBeOk();
        });
    }

    [Test]
    public async Task SubmitsWebhook_InvalidSignature()
    {
        var svixId = Guid.NewGuid().ToString();
        var timeStamp = DateTimeOffset.Now;

        await Host.Scenario(c =>
        {
            c.Post.Json(UserCreatedPayload.Instance).ToUrl("/webhooks");
            
            c.WithRequestHeader(SvixDefaults.SvixId, svixId);
            c.WithRequestHeader(SvixDefaults.SvixTimestamp, timeStamp.ToUnixTimeSeconds().ToString());
            c.WithRequestHeader(SvixDefaults.SvixSignature, "Wrong-signature");

            c.StatusCodeShouldBe(HttpStatusCode.Unauthorized);
        });
    }
}