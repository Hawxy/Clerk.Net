using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Clerk.Net.AspNetCore.Webhooks;

public static class EndpointRoutingExtensions
{
    public static IEndpointConventionBuilder MapWebhook(this IEndpointRouteBuilder builder, [StringSyntax("Route")]string pattern, string profileName)
    {
        var invoker = new WebhookInvoker(profileName);
        
        return builder.MapPost(pattern, invoker.InvokeAsync);
    }
}