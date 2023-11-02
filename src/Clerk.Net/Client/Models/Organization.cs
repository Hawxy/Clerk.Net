// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Models {
    public class Organization : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The admin_delete_enabled property</summary>
        public bool? AdminDeleteEnabled { get; set; }
        /// <summary>Unix timestamp of creation.</summary>
        public long? CreatedAt { get; set; }
        /// <summary>The created_by property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy { get; set; }
#nullable restore
#else
        public string CreatedBy { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The max_allowed_memberships property</summary>
        public int? MaxAllowedMemberships { get; set; }
        /// <summary>The members_count property</summary>
        public int? MembersCount { get; set; }
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The object property</summary>
        public Organization_object? Object { get; set; }
        /// <summary>The private_metadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Organization_private_metadata? PrivateMetadata { get; set; }
#nullable restore
#else
        public Organization_private_metadata PrivateMetadata { get; set; }
#endif
        /// <summary>The public_metadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Organization_public_metadata? PublicMetadata { get; set; }
#nullable restore
#else
        public Organization_public_metadata PublicMetadata { get; set; }
#endif
        /// <summary>The slug property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Slug { get; set; }
#nullable restore
#else
        public string Slug { get; set; }
#endif
        /// <summary>Unix timestamp of last update.</summary>
        public long? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new Organization and sets the default values.
        /// </summary>
        public Organization() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Organization CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Organization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"admin_delete_enabled", n => { AdminDeleteEnabled = n.GetBoolValue(); } },
                {"created_at", n => { CreatedAt = n.GetLongValue(); } },
                {"created_by", n => { CreatedBy = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"max_allowed_memberships", n => { MaxAllowedMemberships = n.GetIntValue(); } },
                {"members_count", n => { MembersCount = n.GetIntValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"object", n => { Object = n.GetEnumValue<Organization_object>(); } },
                {"private_metadata", n => { PrivateMetadata = n.GetObjectValue<Organization_private_metadata>(Organization_private_metadata.CreateFromDiscriminatorValue); } },
                {"public_metadata", n => { PublicMetadata = n.GetObjectValue<Organization_public_metadata>(Organization_public_metadata.CreateFromDiscriminatorValue); } },
                {"slug", n => { Slug = n.GetStringValue(); } },
                {"updated_at", n => { UpdatedAt = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("admin_delete_enabled", AdminDeleteEnabled);
            writer.WriteLongValue("created_at", CreatedAt);
            writer.WriteStringValue("created_by", CreatedBy);
            writer.WriteStringValue("id", Id);
            writer.WriteIntValue("max_allowed_memberships", MaxAllowedMemberships);
            writer.WriteIntValue("members_count", MembersCount);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<Organization_object>("object", Object);
            writer.WriteObjectValue<Organization_private_metadata>("private_metadata", PrivateMetadata);
            writer.WriteObjectValue<Organization_public_metadata>("public_metadata", PublicMetadata);
            writer.WriteStringValue("slug", Slug);
            writer.WriteLongValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
