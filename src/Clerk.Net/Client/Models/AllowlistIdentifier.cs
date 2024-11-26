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
    public partial class AllowlistIdentifier : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Unix timestamp of creation</summary>
        public long? CreatedAt { get; set; }
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>An email address or a phone number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Identifier { get; set; }
#nullable restore
#else
        public string Identifier { get; set; }
#endif
        /// <summary>The identifier_type property</summary>
        public global::Clerk.Net.Client.Models.AllowlistIdentifier_identifier_type? IdentifierType { get; set; }
        /// <summary>The instance_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InstanceId { get; set; }
#nullable restore
#else
        public string InstanceId { get; set; }
#endif
        /// <summary>The invitation_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvitationId { get; set; }
#nullable restore
#else
        public string InvitationId { get; set; }
#endif
        /// <summary>String representing the object&apos;s type. Objects of the same type share the same value.</summary>
        public global::Clerk.Net.Client.Models.AllowlistIdentifier_object? Object { get; set; }
        /// <summary>Unix timestamp of last update.</summary>
        public long? UpdatedAt { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.AllowlistIdentifier"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Models.AllowlistIdentifier CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Models.AllowlistIdentifier();
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
                { "identifier", n => { Identifier = n.GetStringValue(); } },
                { "identifier_type", n => { IdentifierType = n.GetEnumValue<global::Clerk.Net.Client.Models.AllowlistIdentifier_identifier_type>(); } },
                { "instance_id", n => { InstanceId = n.GetStringValue(); } },
                { "invitation_id", n => { InvitationId = n.GetStringValue(); } },
                { "object", n => { Object = n.GetEnumValue<global::Clerk.Net.Client.Models.AllowlistIdentifier_object>(); } },
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
            writer.WriteStringValue("identifier", Identifier);
            writer.WriteEnumValue<global::Clerk.Net.Client.Models.AllowlistIdentifier_identifier_type>("identifier_type", IdentifierType);
            writer.WriteStringValue("instance_id", InstanceId);
            writer.WriteStringValue("invitation_id", InvitationId);
            writer.WriteEnumValue<global::Clerk.Net.Client.Models.AllowlistIdentifier_object>("object", Object);
            writer.WriteLongValue("updated_at", UpdatedAt);
        }
    }
}
#pragma warning restore CS0618
