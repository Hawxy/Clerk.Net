﻿using Alba;
using Clerk.Net.Client;
using Microsoft.Extensions.DependencyInjection;
using TUnit.Core.Interfaces;

namespace Clerk.Net.AspNetCore.Tests;

public sealed class AlbaBootstrap : IAsyncInitializer, IAsyncDisposable
{
    public IAlbaHost Host { get; private set; } = null!;
    public ClerkApiClient ClerkApiClient { get; private set; } = null!;

    public async Task InitializeAsync() 
    {
        Host = await AlbaHost.For<Program>();

        ClerkApiClient = Host.Services.GetRequiredService<ClerkApiClient>();
    }

    public async ValueTask DisposeAsync()
    {
        await Host.DisposeAsync();
    }
}