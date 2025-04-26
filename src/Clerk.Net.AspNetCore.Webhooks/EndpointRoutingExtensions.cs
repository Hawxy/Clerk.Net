using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Clerk.Net.AspNetCore.Webhooks;

public static class EndpointRoutingExtensions
{
    public static IEndpointConventionBuilder MapWebhooks(this IEndpointRouteBuilder builder, [StringSyntax("Route")]string pattern)
    {
        return builder.MapPost(pattern, WebhookInvoker.InvokeAsync);
    }
}