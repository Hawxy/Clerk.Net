// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Clerk.Net.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Session : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Unix timestamp of abandonment.</summary>
        public long? AbandonAt { get; set; }
        /// <summary>The actor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Models.Session_actor? Actor { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Models.Session_actor Actor { get; set; }
#endif
        /// <summary>The client_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientId { get; set; }
#nullable restore
#else
        public string ClientId { get; set; }
#endif
        /// <summary>Unix timestamp of creation.</summary>
        public long? CreatedAt { get; set; }
        /// <summary>Unix timestamp of expiration.</summary>
        public long? ExpireAt { get; set; }
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The last_active_at property</summary>
        public int? LastActiveAt { get; set; }
        /// <summary>The last_active_organization_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastActiveOrganizationId { get; set; }
#nullable restore
#else
        public string LastActiveOrganizationId { get; set; }
#endif
        /// <summary>The latest_activity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Models.SessionActivityResponse? LatestActivity { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Models.SessionActivityResponse LatestActivity { get; set; }
#endif
        /// <summary>String representing the object&apos;s type. Objects of the same type share the same value.</summary>
        public global::Clerk.Net.Client.Models.Session_object? Object { get; set; }
        /// <summary>The status property</summary>
        public global::Clerk.Net.Client.Models.Session_status? Status { get; set; }
        /// <summary>Unix timestamp of last update.</summary>
        public long? UpdatedAt { get; set; }
        /// <summary>The user_id property</summary>
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
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.Session"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Models.Session CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Models.Session();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "abandon_at", n => { AbandonAt = n.GetLongValue(); } },
                { "actor", n => { Actor = n.GetObjectValue<global::Clerk.Net.Client.Models.Session_actor>(global::Clerk.Net.Client.Models.Session_actor.CreateFromDiscriminatorValue); } },
                { "client_id", n => { ClientId = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetLongValue(); } },
                { "expire_at", n => { ExpireAt = n.GetLongValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "last_active_at", n => { LastActiveAt = n.GetIntValue(); } },
                { "last_active_organization_id", n => { LastActiveOrganizationId = n.GetStringValue(); } },
                { "latest_activity", n => { LatestActivity = n.GetObjectValue<global::Clerk.Net.Client.Models.SessionActivityResponse>(global::Clerk.Net.Client.Models.SessionActivityResponse.CreateFromDiscriminatorValue); } },
                { "object", n => { Object = n.GetEnumValue<global::Clerk.Net.Client.Models.Session_object>(); } },
                { "status", n => { Status = n.GetEnumValue<global::Clerk.Net.Client.Models.Session_status>(); } },
                { "updated_at", n => { UpdatedAt = n.GetLongValue(); } },
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
            writer.WriteLongValue("abandon_at", AbandonAt);
            writer.WriteObjectValue<global::Clerk.Net.Client.Models.Session_actor>("actor", Actor);
            writer.WriteStringValue("client_id", ClientId);
            writer.WriteLongValue("created_at", CreatedAt);
            writer.WriteLongValue("expire_at", ExpireAt);
            writer.WriteStringValue("id", Id);
            writer.WriteIntValue("last_active_at", LastActiveAt);
            writer.WriteStringValue("last_active_organization_id", LastActiveOrganizationId);
            writer.WriteObjectValue<global::Clerk.Net.Client.Models.SessionActivityResponse>("latest_activity", LatestActivity);
            writer.WriteEnumValue<global::Clerk.Net.Client.Models.Session_object>("object", Object);
            writer.WriteEnumValue<global::Clerk.Net.Client.Models.Session_status>("status", Status);
            writer.WriteLongValue("updated_at", UpdatedAt);
            writer.WriteStringValue("user_id", UserId);
        }
    }
}
#pragma warning restore CS0618
