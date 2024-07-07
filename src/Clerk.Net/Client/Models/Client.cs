// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Clerk.Net.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class Client : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Unix timestamp of creation.</summary>
        public long? CreatedAt { get; set; }
        /// <summary>String representing the identifier of the session.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Last active session_id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastActiveSessionId { get; set; }
#nullable restore
#else
        public string LastActiveSessionId { get; set; }
#endif
        /// <summary>String representing the object&apos;s type. Objects of the same type share the same value.</summary>
        public global::Clerk.Net.Client.Models.Client_object? Object { get; set; }
        /// <summary>The session_ids property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SessionIds { get; set; }
#nullable restore
#else
        public List<string> SessionIds { get; set; }
#endif
        /// <summary>The sessions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Clerk.Net.Client.Models.Session>? Sessions { get; set; }
#nullable restore
#else
        public List<global::Clerk.Net.Client.Models.Session> Sessions { get; set; }
#endif
        /// <summary>The sign_in_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignInId { get; set; }
#nullable restore
#else
        public string SignInId { get; set; }
#endif
        /// <summary>The sign_up_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignUpId { get; set; }
#nullable restore
#else
        public string SignUpId { get; set; }
#endif
        /// <summary>Unix timestamp of last update.</summary>
        public long? UpdatedAt { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.Client"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Models.Client CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Models.Client();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetLongValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "last_active_session_id", n => { LastActiveSessionId = n.GetStringValue(); } },
                { "object", n => { Object = n.GetEnumValue<global::Clerk.Net.Client.Models.Client_object>(); } },
                { "session_ids", n => { SessionIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "sessions", n => { Sessions = n.GetCollectionOfObjectValues<global::Clerk.Net.Client.Models.Session>(global::Clerk.Net.Client.Models.Session.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sign_in_id", n => { SignInId = n.GetStringValue(); } },
                { "sign_up_id", n => { SignUpId = n.GetStringValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("created_at", CreatedAt);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("last_active_session_id", LastActiveSessionId);
            writer.WriteEnumValue<global::Clerk.Net.Client.Models.Client_object>("object", Object);
            writer.WriteCollectionOfPrimitiveValues<string>("session_ids", SessionIds);
            writer.WriteCollectionOfObjectValues<global::Clerk.Net.Client.Models.Session>("sessions", Sessions);
            writer.WriteStringValue("sign_in_id", SignInId);
            writer.WriteStringValue("sign_up_id", SignUpId);
            writer.WriteLongValue("updated_at", UpdatedAt);
        }
    }
}
