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
    public partial class ManagementCreateOrganizationRequest : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The creation timestamp in RFC3339 format.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The ID of the user who created the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy { get; set; }
#nullable restore
#else
        public string CreatedBy { get; set; }
#endif
        /// <summary>The maximum allowed memberships for the organization.</summary>
        public int? MaxAllowedMemberships { get; set; }
        /// <summary>The name of the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Private metadata for the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Models.ManagementCreateOrganizationRequest_private_metadata? PrivateMetadata { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Models.ManagementCreateOrganizationRequest_private_metadata PrivateMetadata { get; set; }
#endif
        /// <summary>Public metadata for the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Models.ManagementCreateOrganizationRequest_public_metadata? PublicMetadata { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Models.ManagementCreateOrganizationRequest_public_metadata PublicMetadata { get; set; }
#endif
        /// <summary>The slug of the organization.</summary>
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
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.ManagementCreateOrganizationRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Models.ManagementCreateOrganizationRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Models.ManagementCreateOrganizationRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "created_by", n => { CreatedBy = n.GetStringValue(); } },
                { "max_allowed_memberships", n => { MaxAllowedMemberships = n.GetIntValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "private_metadata", n => { PrivateMetadata = n.GetObjectValue<global::Clerk.Net.Client.Models.ManagementCreateOrganizationRequest_private_metadata>(global::Clerk.Net.Client.Models.ManagementCreateOrganizationRequest_private_metadata.CreateFromDiscriminatorValue); } },
                { "public_metadata", n => { PublicMetadata = n.GetObjectValue<global::Clerk.Net.Client.Models.ManagementCreateOrganizationRequest_public_metadata>(global::Clerk.Net.Client.Models.ManagementCreateOrganizationRequest_public_metadata.CreateFromDiscriminatorValue); } },
                { "slug", n => { Slug = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("created_by", CreatedBy);
            writer.WriteIntValue("max_allowed_memberships", MaxAllowedMemberships);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Clerk.Net.Client.Models.ManagementCreateOrganizationRequest_private_metadata>("private_metadata", PrivateMetadata);
            writer.WriteObjectValue<global::Clerk.Net.Client.Models.ManagementCreateOrganizationRequest_public_metadata>("public_metadata", PublicMetadata);
            writer.WriteStringValue("slug", Slug);
        }
    }
}
#pragma warning restore CS0618
