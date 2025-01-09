# Clerk SDK for .NET

[![Nuget](https://img.shields.io/nuget/v/Clerk.Net?label=Clerk.Net&style=flat-square)](https://www.nuget.org/packages/Clerk.Net)
[![Nuget](https://img.shields.io/nuget/v/Clerk.Net.DependencyInjection?label=Clerk.Net.DependencyInjection&style=flat-square)](https://www.nuget.org/packages/Clerk.Net.DependencyInjection)

_Looking for ASP.NET Core w/ Clerk JWTs? [See below](#what-about-jwt-auth)._

### Packages

**`Clerk.Net`**: Provides the standalone API Client as a Kiota-generated wrapper over Clerk's OpenAPI spec. Compatible with .NET 6+ and .NET Framework 4.7.2+.

**`Clerk.Net.DependencyInjection`**: Extensions to register the `ClerkApiClient` into your DI container. Compatible with .NET 6+.

These libraries are configured as native AoT compatible for .NET 8+ consumers.

## Getting Started

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

### Testing

For unit testing, see [Unit testing Kiota API clients](https://learn.microsoft.com/en-us/openapi/kiota/testing).

### What about JWT Auth?

You might have stumbled upon this repo looking for a solution for validating Clerk JWTs, so I'll include the answer here for completion. Configuring JWT auth for Clerk is a tad _unusual_ as they want you to validate the `azp` parameter instead of specifying an `audience`.
This claim isn't normally validated at the authentication layer, and so you'll need some extra code to get things working:

```cs
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(x =>
    {
        // Authority is the URL of your clerk instance
        x.Authority = builder.Configuration["Clerk:Authority"];
        x.TokenValidationParameters = new TokenValidationParameters()
        {
            // Disable audience validation as we aren't using it
            ValidateAudience = false,
            NameClaimType = ClaimTypes.NameIdentifier
        };
        x.Events = new JwtBearerEvents()
        {
            // Additional validation for AZP claim
            OnTokenValidated = context =>
            {
                var azp = context.Principal?.FindFirstValue("azp");
                // AuthorizedParty is the base URL of your frontend.
                if (string.IsNullOrEmpty(azp) || !azp.Equals(builder.Configuration["Clerk:AuthorizedParty"]))
                    context.Fail("AZP Claim is invalid or missing");

                return Task.CompletedTask;
            }
        };
    });
```

Prerequisits for .NET Core:
- Nuget Package [`Microsoft.AspNetCore.Authentication.JwtBearer`](https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer)

If you're sending requests from a SPA, it should call Clerk-JS's `getToken` as part of its HTTP middleware and append the token (prefixed with `Bearer`) to the `Authorization` header, for example:

```ts
async onRequestInit({ requestInit }) {
    requestInit.headers = {
        ...requestInit.headers,
        Authorization: `Bearer ${await getToken()}`
    }
}
```

If the requests are coming from an SSR environment (ie NextJS), then you can either use the session JWT via the `__session` cookie and forward it on, or use a JWT template to create a unique JWT for your scenario.

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
