using System.Collections.Frozen;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.ComTypes;
using Clerk.Net.AspNetCore.Webhooks.Models;
using Clerk.Net.AspNetCore.Webhooks.Models.User;

namespace Clerk.Net.AspNetCore.Webhooks;

public static class EventMapExtensions
{
    public static void ApplyClerkDefaults(this WebhookProfileBuilder options)
    {
        options.WithEventMap(y =>
        {
            y.Add<UserCreatedEvent>("user.created");
        });
        options.WithSerializerOptions(o =>
        {
            o.TypeInfoResolver = WebhookSerializationContext.Default;
        });
    }
}

public sealed class EventMap
{
    private readonly FrozenDictionary<string, Type> _map;

    public EventMap(FrozenDictionary<string, Type> map)
    {
        _map = map;
    }

    public bool TryGetEvent(string @name, [NotNullWhen(true)]out Type? type)
    {
        return _map.TryGetValue(@name, out type);
    }
}


public sealed class EventMapBuilder
{
    private readonly Dictionary<string, Type> _map = new();
    public EventMapBuilder Add(Type type, string eventName)
    {
        _map.Add(eventName, type);
        return this;
    }

    public EventMapBuilder Add<T>(string eventName)
    {
        return Add(typeof(T), eventName);
    }

    internal EventMap Build()
    {
        return new EventMap(_map.ToFrozenDictionary());
    }
}