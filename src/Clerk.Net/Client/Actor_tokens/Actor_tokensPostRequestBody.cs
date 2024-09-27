// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Clerk.Net.Client.Actor_tokens
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class Actor_tokensPostRequestBody : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The actor payload. It needs to include a sub property which should contain the ID of the actor.This whole payload will be also included in the JWT session token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Actor_tokens.Actor_tokensPostRequestBody_actor? Actor { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Actor_tokens.Actor_tokensPostRequestBody_actor Actor { get; set; }
#endif
        /// <summary>Optional parameter to specify the life duration of the actor token in seconds.By default, the duration is 1 hour.</summary>
        public int? ExpiresInSeconds { get; set; }
        /// <summary>The maximum duration that the session which will be created by the generated actor token should last.By default, the duration of a session created via an actor token, lasts 30 minutes.</summary>
        public int? SessionMaxDurationInSeconds { get; set; }
        /// <summary>The ID of the user being impersonated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Actor_tokens.Actor_tokensPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Actor_tokens.Actor_tokensPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Actor_tokens.Actor_tokensPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "actor", n => { Actor = n.GetObjectValue<global::Clerk.Net.Client.Actor_tokens.Actor_tokensPostRequestBody_actor>(global::Clerk.Net.Client.Actor_tokens.Actor_tokensPostRequestBody_actor.CreateFromDiscriminatorValue); } },
                { "expires_in_seconds", n => { ExpiresInSeconds = n.GetIntValue(); } },
                { "session_max_duration_in_seconds", n => { SessionMaxDurationInSeconds = n.GetIntValue(); } },
                { "user_id", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Clerk.Net.Client.Actor_tokens.Actor_tokensPostRequestBody_actor>("actor", Actor);
            writer.WriteIntValue("expires_in_seconds", ExpiresInSeconds);
            writer.WriteIntValue("session_max_duration_in_seconds", SessionMaxDurationInSeconds);
            writer.WriteStringValue("user_id", UserId);
        }
    }
}
#pragma warning restore CS0618
