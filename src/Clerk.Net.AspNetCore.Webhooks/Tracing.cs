using System.Diagnostics;

namespace Clerk.Net.AspNetCore.Webhooks;

internal static class Tracing
{
    public static readonly ActivitySource Source = new("Webhooks.AspNetCore");
}