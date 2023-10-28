## Clerk API Client for .NET

[![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/Clerk.Net.DependencyInjection?label=Clerk.Net.DependencyInjection&style=flat-square)](https://www.nuget.org/packages/Fga.Net.DependencyInjection)
[![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/Clerk.Net?label=Clerk.Net&style=flat-square)](https://www.nuget.org/packages/Fga.Net.AspNetCore)

#### Note: This project is currently in alpha. Breaking changes may occur before release.

### Packages
**`Clerk.Net`**: Provides the standalone API Client as a Kiota-generated wrapper over Clerk's OpenAPI spec.

**`Clerk.Net.DependencyInjection`**: Dependency Injection extensions to register the `ClerkApiClient` into your container.

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

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // Do work with the client
    }
}
```

## Standalone Client

If you want to use the client by itself, install `Clerk.Net` and call `ClerkApiClientFactory.Create`, passing in your secret key. 

The returned client should be treated as a singleton and created once for the lifetime of your application.

## Testing

(To be written)

## Disclaimer

I am not affiliated with nor represent Clerk. All support queries regarding the underlying service should go to [Clerk Support](https://clerk.com/support).
