using System.Collections.Frozen;
using System.Diagnostics.CodeAnalysis;
using Clerk.Net.AspNetCore.Webhooks.Models.User;

namespace Clerk.Net.AspNetCore.Webhooks;

internal static class EventMap
{
    private static readonly FrozenDictionary<string, Type> Map = new Dictionary<string, Type>()
    {
        { "user.event.create", typeof(UserCreatedEvent) },
    }.ToFrozenDictionary();

    public static bool TryGetEvent(string @name, [NotNullWhen(true)]out Type? type)
    {
        return Map.TryGetValue(@name, out type);
    }
}