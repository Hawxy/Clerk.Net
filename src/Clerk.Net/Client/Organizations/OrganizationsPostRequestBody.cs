// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Clerk.Net.Client.Organizations
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class OrganizationsPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ID of the User who will become the administrator for the new organization</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy { get; set; }
#nullable restore
#else
        public string CreatedBy { get; set; }
#endif
        /// <summary>The maximum number of memberships allowed for this organization</summary>
        public int? MaxAllowedMemberships { get; set; }
        /// <summary>The name of the new organization</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Metadata saved on the organization, accessible only from the Backend API</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Organizations.OrganizationsPostRequestBody_private_metadata? PrivateMetadata { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Organizations.OrganizationsPostRequestBody_private_metadata PrivateMetadata { get; set; }
#endif
        /// <summary>Metadata saved on the organization, read-only from the Frontend API and fully accessible (read/write) from the Backend API</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Organizations.OrganizationsPostRequestBody_public_metadata? PublicMetadata { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Organizations.OrganizationsPostRequestBody_public_metadata PublicMetadata { get; set; }
#endif
        /// <summary>A slug for the new organization.Can contain only lowercase alphanumeric characters and the dash &quot;-&quot;.Must be unique for the instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Slug { get; set; }
#nullable restore
#else
        public string Slug { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Organizations.OrganizationsPostRequestBody"/> and sets the default values.
        /// </summary>
        public OrganizationsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Organizations.OrganizationsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Organizations.OrganizationsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Organizations.OrganizationsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_by", n => { CreatedBy = n.GetStringValue(); } },
                { "max_allowed_memberships", n => { MaxAllowedMemberships = n.GetIntValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "private_metadata", n => { PrivateMetadata = n.GetObjectValue<global::Clerk.Net.Client.Organizations.OrganizationsPostRequestBody_private_metadata>(global::Clerk.Net.Client.Organizations.OrganizationsPostRequestBody_private_metadata.CreateFromDiscriminatorValue); } },
                { "public_metadata", n => { PublicMetadata = n.GetObjectValue<global::Clerk.Net.Client.Organizations.OrganizationsPostRequestBody_public_metadata>(global::Clerk.Net.Client.Organizations.OrganizationsPostRequestBody_public_metadata.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("created_by", CreatedBy);
            writer.WriteIntValue("max_allowed_memberships", MaxAllowedMemberships);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Clerk.Net.Client.Organizations.OrganizationsPostRequestBody_private_metadata>("private_metadata", PrivateMetadata);
            writer.WriteObjectValue<global::Clerk.Net.Client.Organizations.OrganizationsPostRequestBody_public_metadata>("public_metadata", PublicMetadata);
            writer.WriteStringValue("slug", Slug);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
