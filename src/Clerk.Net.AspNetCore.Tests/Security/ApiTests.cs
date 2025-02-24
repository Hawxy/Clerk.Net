using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using Alba;
using Microsoft.AspNetCore.Http;

namespace Clerk.Net.AspNetCore.Tests.Security;

[ClassDataSource<AlbaBootstrap>(Shared = SharedType.PerTestSession)]
public class ApiTests(AlbaBootstrap albaBootstrap) : AlbaTestBase(albaBootstrap)
{
    [Test]
    public async Task JwtAuth_HappyPath_WorksAsExpected()
    {
        var token = await ClerkApiClient.GetSessionJwt();

        await Host.Scenario(x =>
        {
            x.Get.Url("/weatherforecast");
            x.WithRequestHeader("Authorization", $"Bearer {token}");
            x.StatusCodeShouldBeOk();
        });
    }
    
    [Test]
    public async Task JwtAuth_MissingToken_Returns401()
    {
        await Host.Scenario(x =>
        {
            x.Get.Url("/weatherforecast");
            x.StatusCodeShouldBe(HttpStatusCode.Unauthorized);
        });
    }

    [Test]
    public async Task CookieAuth_HappyPath_WorksAsExpected()
    {
        var token = await ClerkApiClient.GetSessionJwt();

        await Host.Scenario(x =>
        {
            x.Get.Url("/weatherforecast");
            x.ConfigureHttpContext(c =>
            {
                c.Request.Cookies = new TestCookieCollection([new KeyValuePair<string, string>("__session", token)]);
            });
            x.StatusCodeShouldBeOk();
        });
    }
    
    [Test]
    public async Task CookieAuth_InvalidCookie_Returns401()
    {
        await Host.Scenario(x =>
        {
            x.Get.Url("/weatherforecast");
            x.ConfigureHttpContext(c =>
            {
                c.Request.Cookies = new TestCookieCollection([new KeyValuePair<string, string>("__session", "something-random")]);
            });
            x.StatusCodeShouldBe(HttpStatusCode.Unauthorized);
        });
    }

    public sealed class TestCookieCollection : IRequestCookieCollection
    {
        private readonly Dictionary<string, string> _cookies;

        public TestCookieCollection(IEnumerable<KeyValuePair<string, string>> cookies)
        {
            _cookies = new Dictionary<string, string>(cookies);
        }
        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            return _cookies.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool ContainsKey(string key)
        {
            return _cookies.ContainsKey(key);
        }

        public bool TryGetValue(string key, [NotNullWhen(true)] out string? value)
        {
            return _cookies.TryGetValue(key, out value);
        }

        public int Count => _cookies.Count;
        public ICollection<string> Keys => _cookies.Keys;

        public string? this[string key] => _cookies[key];
    }
}