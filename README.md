## Clerk API Client for .NET

[![Nuget](https://img.shields.io/nuget/v/Clerk.Net.DependencyInjection?label=Clerk.Net.DependencyInjection&style=flat-square)](https://www.nuget.org/packages/Clerk.Net.DependencyInjection)
[![Nuget](https://img.shields.io/nuget/v/Clerk.Net?label=Clerk.Net&style=flat-square)](https://www.nuget.org/packages/Clerk.Net)

### Packages
**`Clerk.Net`**: Provides the standalone API Client as a Kiota-generated wrapper over Clerk's OpenAPI spec.

**`Clerk.Net.DependencyInjection`**: Extensions to register the `ClerkApiClient` into your DI container.

These libraries support .NET 6 onwards and are configured as native AoT compatible for .NET 8+ consumers.

## Getting Started

Make sure to add your `SecretKey` to your application configuration, ideally via the [dotnet secrets manager](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows#enable-secret-storage).

### DI Container Configuration (ASP.NET Core & Worker Services)

1. Install `Clerk.Net.DependencyInjection` from Nuget.
2. Add the following code to your service configuration:
```cs
builder.Services.AddClerkApiClient(config =>
{
    config.SecretKey = builder.Configuration["Clerk:SecretKey"]!
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

## Disclaimer

I am not affiliated with nor represent Clerk. All support queries regarding the underlying service should go to [Clerk Support](https://clerk.com/support).
