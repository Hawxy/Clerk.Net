// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Organizations.Item {
    public class WithOrganization_PatchRequestBody : IParsable {
        /// <summary>If true, an admin can delete this organization with the Frontend API.</summary>
        public bool? AdminDeleteEnabled { get; set; }
        /// <summary>The maximum number of memberships allowed for this organization</summary>
        public int? MaxAllowedMemberships { get; set; }
        /// <summary>The new name of the organization</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Metadata saved on the organization that is only visible to your backend.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WithOrganization_PatchRequestBody_private_metadata? PrivateMetadata { get; set; }
#nullable restore
#else
        public WithOrganization_PatchRequestBody_private_metadata PrivateMetadata { get; set; }
#endif
        /// <summary>Metadata saved on the organization, that is visible to both your frontend and backend.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WithOrganization_PatchRequestBody_public_metadata? PublicMetadata { get; set; }
#nullable restore
#else
        public WithOrganization_PatchRequestBody_public_metadata PublicMetadata { get; set; }
#endif
        /// <summary>The new slug of the organization, which needs to be unique in the instance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Slug { get; set; }
#nullable restore
#else
        public string Slug { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WithOrganization_PatchRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WithOrganization_PatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WithOrganization_PatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"admin_delete_enabled", n => { AdminDeleteEnabled = n.GetBoolValue(); } },
                {"max_allowed_memberships", n => { MaxAllowedMemberships = n.GetIntValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"private_metadata", n => { PrivateMetadata = n.GetObjectValue<WithOrganization_PatchRequestBody_private_metadata>(WithOrganization_PatchRequestBody_private_metadata.CreateFromDiscriminatorValue); } },
                {"public_metadata", n => { PublicMetadata = n.GetObjectValue<WithOrganization_PatchRequestBody_public_metadata>(WithOrganization_PatchRequestBody_public_metadata.CreateFromDiscriminatorValue); } },
                {"slug", n => { Slug = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("admin_delete_enabled", AdminDeleteEnabled);
            writer.WriteIntValue("max_allowed_memberships", MaxAllowedMemberships);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<WithOrganization_PatchRequestBody_private_metadata>("private_metadata", PrivateMetadata);
            writer.WriteObjectValue<WithOrganization_PatchRequestBody_public_metadata>("public_metadata", PublicMetadata);
            writer.WriteStringValue("slug", Slug);
        }
    }
}
