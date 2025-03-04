# Clerk SDK for .NET

[![Nuget](https://img.shields.io/nuget/v/Clerk.Net?label=Clerk.Net&style=flat-square)](https://www.nuget.org/packages/Clerk.Net)
[![Nuget](https://img.shields.io/nuget/v/Clerk.Net.DependencyInjection?label=Clerk.Net.DependencyInjection&style=flat-square)](https://www.nuget.org/packages/Clerk.Net.DependencyInjection)
[![Nuget](https://img.shields.io/nuget/vpre/Clerk.Net.AspNetCore.Security?label=Clerk.Net.AspNetCore.Security&style=flat-square)](https://www.nuget.org/packages/Clerk.Net.AspNetCore.Security)

### Packages

**`Clerk.Net`**: Clerk API Client generated with Kiota from Clerk's OpenAPI spec. Compatible with .NET 6+ and .NET Framework 4.7.2+.

**`Clerk.Net.DependencyInjection`**: Extensions to register the `ClerkApiClient` into your DI container. Compatible with .NET 6+.

**`Clerk.Net.AspNetCore.Security`**: Clerk Authentication support for ASP.NET Core API. Compatible with .NET 8+.

These libraries are configured as native AoT compatible for .NET 8+ consumers.

**Caution:** As the Clerk OpenAPI spec is constantly changing, the core `Clerk.Net` library does not follow usual SemVer rules, with minor releases usually containing breaking changes. Major releases are only used for breaking changes at the framework level, not for codegen output.

## Getting Started - Clerk API Client

Make sure to add your `SecretKey` to your application configuration, ideally via the [dotnet secrets manager](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows#enable-secret-storage).

### DI Container Configuration (ASP.NET Core & Worker Services)

1. Install `Clerk.Net.DependencyInjection` from Nuget.
2. Add the following code to your service configuration:

```cs
builder.Services.AddClerkApiClient(config =>
{
    config.SecretKey = builder.Configuration["Clerk:SecretKey"]!;
});
```

3. Request the `ClerkApiClient` in your services

```cs
public class MyBackgroundWorker : BackgroundService
{
    private readonly ClerkApiClient _clerkApiClient;

    public MyBackgroundWorker(ClerkApiClient clerkApiClient)
    {
        _clerkApiClient = clerkApiClient;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var invites = await _clerkApiClient.Organizations["org_abc1234"].Invitations.GetAsync(x =>
        {
            x.QueryParameters.Status = "pending";
        });
    }
}
```

### Standalone Client

If you want to use the client by itself, install `Clerk.Net` and call `ClerkApiClientFactory.Create`, passing in your secret key.

The returned client should be treated as a singleton and created once for the lifetime of your application.

### HttpClient Customization

If you need to configure the underlying `HttpClient` used by the client, you can do in one of two ways:

- Configure the `IHttpClientBuilder` returned by `AddClerkApiClient`.
- Pass in a custom `HttpClient` instance to `ClerkApiClientFactory.Create`

### Rate Limiting

This package applies Kiota's default handlers which enables automated retries when hitting Clerk's rate limits. No additional configuration is required.

### Testing

For unit testing, see [Unit testing Kiota API clients](https://learn.microsoft.com/en-us/openapi/kiota/testing).

## Getting Stated - Authentication (ASP.NET Core)

You should have a new or existing ASP.NET Core application created before continuing.

1. Install `Clerk.Net.AspNetCore.Security` to your project.
2. Call `AddClerkAuthentication` within your authentication builder, passing in an `Authority` - the Frontend URI of your Clerk instance - and an `AuthorizedParty` - the Frontend URL of your application:
```csharp
builder.Services.AddAuthentication(ClerkAuthenticationDefaults.AuthenticationScheme)
    .AddClerkAuthentication(x =>
    {
        x.Authority = builder.Configuration["Clerk:Authority"]!;
        x.AuthorizedParty = builder.Configuration["Clerk:AuthorizedParty"]!;
    });
```

3. Configure an Authorization policy to require authorization by default:
```csharp
builder.Services.AddAuthorizationBuilder()
    .SetFallbackPolicy(new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build());
```

This authentication middleware is compatible with both [cross-origin](https://clerk.com/docs/backend-requests/making/cross-origin) & [same-origin](https://clerk.com/docs/backend-requests/making/same-origin) requests.

This package is light on options at the moment - Please open an issue if there's something you'd like to be able to configure.

Note: This supports authentication for a remote client - such as an SPA - communicating with your backend. MVC is not supported (yet)

### Inbound Clerk Webhooks

If you're accepting webhooks from Clerk, you will need to validate the incoming webhook signature. To do this, you'll need to install the `Svix` package:

```bash
dotnet add package Svix
```

Then, you can use the following code to validate the webhook signature:

```cs
    [HttpPost("webhook")]
    public async Task<IActionResult> ClerkWebhook(IConfiguration configuration)
    {
        // Retrieve the Clerk webhook secret from the configuration
        var clerkWebhookSecret = configuration["Clerk:WebhookSecret"];

        // Read the request body
        var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();

        // Retrieve the Svix headers
        var svixId = Request.Headers["svix-id"].ToString();
        var svixTimestamp = Request.Headers["svix-timestamp"].ToString();
        var svixSignature = Request.Headers["svix-signature"].ToString();

        if (string.IsNullOrEmpty(svixId) || string.IsNullOrEmpty(svixTimestamp) || string.IsNullOrEmpty(svixSignature))
        {
            return BadRequest("Missing headers");
        }

        // Attempt signature verification with the raw signature
        var wh = new Webhook(clerkWebhookSecret);
        WebHeaderCollection headers = new WebHeaderCollection
        {
            { "svix-id", svixId },
            { "svix-timestamp", svixTimestamp },
            { "svix-signature", svixSignature }
        };

        Event webhookEvent;
        try
        {
            wh.Verify(json, headers); // Verify doesn't return anything, just verifies the signature and throws if it's invalid
            webhookEvent = JsonSerializer.Deserialize<Event>(json); // Deserialize the JSON into an Event object
        }
        catch (Svix.Exceptions.WebhookVerificationException ex)
        {
            return BadRequest("Invalid signature");
        }
        catch (Exception ex)
        {
            return BadRequest("An error occurred");
        }

        switch (webhookEvent.Type)
        {
            case "user.created":
                // Handle user created event
                break;
            case "user.updated":
                // Handle user updated event
                break;
            case "user.deleted":
                // Handle user deleted event
                break;

            default:
                return BadRequest("Unhandled event type");
        }

        return Ok();
    }

    // Define the Event class to represent the webhook event
    public class Event
    {
        public string? Type { get; set; }
        public ClerkUser? Data { get; set; }
    }

    public class ClerkUser
    {
        public string Id { get; set; }
        public string? ExternalId { get; set; }
        [JsonPropertyName("first_name")]
        public string? FirstName { get; set; }
        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }
        [JsonPropertyName("email_addresses")]
        public List<ClerkEmailAddress> EmailAddresses { get; set; } = new List<ClerkEmailAddress>();
    }

    public class ClerkEmailAddress
    {
        [JsonPropertyName("email_address")]
        public string? EmailAddress { get; set; }
    }
```

### Disclaimer

I am not affiliated with nor represent Clerk. All support queries regarding the underlying service should go to [Clerk Support](https://clerk.com/support).
