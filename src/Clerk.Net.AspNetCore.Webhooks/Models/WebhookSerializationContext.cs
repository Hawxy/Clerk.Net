using System.Text.Json.Serialization;
using Clerk.Net.AspNetCore.Webhooks.Models.User;

namespace Clerk.Net.AspNetCore.Webhooks.Models;

[JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Metadata)]
[JsonSerializable(typeof(UserCreatedEvent))]
internal partial class ClerkWebhookSerializationContext : JsonSerializerContext
{
}