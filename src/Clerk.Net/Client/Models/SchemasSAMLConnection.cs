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
    public partial class SchemasSAMLConnection : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The acs_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AcsUrl { get; set; }
#nullable restore
#else
        public string AcsUrl { get; set; }
#endif
        /// <summary>The active property</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The allow_idp_initiated property</summary>
        public bool? AllowIdpInitiated { get; set; }
        /// <summary>The allow_subdomains property</summary>
        public bool? AllowSubdomains { get; set; }
        /// <summary>The attribute_mapping property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Models.SAMLConnectionAttributeMapping? AttributeMapping { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Models.SAMLConnectionAttributeMapping AttributeMapping { get; set; }
#endif
        /// <summary>Unix timestamp of creation.</summary>
        public long? CreatedAt { get; set; }
        /// <summary>The disable_additional_identifications property</summary>
        public bool? DisableAdditionalIdentifications { get; set; }
        /// <summary>The domain property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Domain { get; set; }
#nullable restore
#else
        public string Domain { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The idp_certificate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdpCertificate { get; set; }
#nullable restore
#else
        public string IdpCertificate { get; set; }
#endif
        /// <summary>The idp_entity_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdpEntityId { get; set; }
#nullable restore
#else
        public string IdpEntityId { get; set; }
#endif
        /// <summary>The idp_metadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdpMetadata { get; set; }
#nullable restore
#else
        public string IdpMetadata { get; set; }
#endif
        /// <summary>The idp_metadata_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdpMetadataUrl { get; set; }
#nullable restore
#else
        public string IdpMetadataUrl { get; set; }
#endif
        /// <summary>The idp_sso_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdpSsoUrl { get; set; }
#nullable restore
#else
        public string IdpSsoUrl { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The object property</summary>
        public global::Clerk.Net.Client.Models.SchemasSAMLConnection_object? Object { get; set; }
        /// <summary>The organization_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationId { get; set; }
#nullable restore
#else
        public string OrganizationId { get; set; }
#endif
        /// <summary>The provider property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Provider { get; set; }
#nullable restore
#else
        public string Provider { get; set; }
#endif
        /// <summary>The sp_entity_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SpEntityId { get; set; }
#nullable restore
#else
        public string SpEntityId { get; set; }
#endif
        /// <summary>The sp_metadata_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SpMetadataUrl { get; set; }
#nullable restore
#else
        public string SpMetadataUrl { get; set; }
#endif
        /// <summary>The sync_user_attributes property</summary>
        public bool? SyncUserAttributes { get; set; }
        /// <summary>Unix timestamp of last update.</summary>
        public long? UpdatedAt { get; set; }
        /// <summary>The user_count property</summary>
        public int? UserCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Models.SchemasSAMLConnection"/> and sets the default values.
        /// </summary>
        public SchemasSAMLConnection()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.SchemasSAMLConnection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Models.SchemasSAMLConnection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Models.SchemasSAMLConnection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "acs_url", n => { AcsUrl = n.GetStringValue(); } },
                { "active", n => { Active = n.GetBoolValue(); } },
                { "allow_idp_initiated", n => { AllowIdpInitiated = n.GetBoolValue(); } },
                { "allow_subdomains", n => { AllowSubdomains = n.GetBoolValue(); } },
                { "attribute_mapping", n => { AttributeMapping = n.GetObjectValue<global::Clerk.Net.Client.Models.SAMLConnectionAttributeMapping>(global::Clerk.Net.Client.Models.SAMLConnectionAttributeMapping.CreateFromDiscriminatorValue); } },
                { "created_at", n => { CreatedAt = n.GetLongValue(); } },
                { "disable_additional_identifications", n => { DisableAdditionalIdentifications = n.GetBoolValue(); } },
                { "domain", n => { Domain = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "idp_certificate", n => { IdpCertificate = n.GetStringValue(); } },
                { "idp_entity_id", n => { IdpEntityId = n.GetStringValue(); } },
                { "idp_metadata", n => { IdpMetadata = n.GetStringValue(); } },
                { "idp_metadata_url", n => { IdpMetadataUrl = n.GetStringValue(); } },
                { "idp_sso_url", n => { IdpSsoUrl = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "object", n => { Object = n.GetEnumValue<global::Clerk.Net.Client.Models.SchemasSAMLConnection_object>(); } },
                { "organization_id", n => { OrganizationId = n.GetStringValue(); } },
                { "provider", n => { Provider = n.GetStringValue(); } },
                { "sp_entity_id", n => { SpEntityId = n.GetStringValue(); } },
                { "sp_metadata_url", n => { SpMetadataUrl = n.GetStringValue(); } },
                { "sync_user_attributes", n => { SyncUserAttributes = n.GetBoolValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetLongValue(); } },
                { "user_count", n => { UserCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("acs_url", AcsUrl);
            writer.WriteBoolValue("active", Active);
            writer.WriteBoolValue("allow_idp_initiated", AllowIdpInitiated);
            writer.WriteBoolValue("allow_subdomains", AllowSubdomains);
            writer.WriteObjectValue<global::Clerk.Net.Client.Models.SAMLConnectionAttributeMapping>("attribute_mapping", AttributeMapping);
            writer.WriteLongValue("created_at", CreatedAt);
            writer.WriteBoolValue("disable_additional_identifications", DisableAdditionalIdentifications);
            writer.WriteStringValue("domain", Domain);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("idp_certificate", IdpCertificate);
            writer.WriteStringValue("idp_entity_id", IdpEntityId);
            writer.WriteStringValue("idp_metadata", IdpMetadata);
            writer.WriteStringValue("idp_metadata_url", IdpMetadataUrl);
            writer.WriteStringValue("idp_sso_url", IdpSsoUrl);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<global::Clerk.Net.Client.Models.SchemasSAMLConnection_object>("object", Object);
            writer.WriteStringValue("organization_id", OrganizationId);
            writer.WriteStringValue("provider", Provider);
            writer.WriteStringValue("sp_entity_id", SpEntityId);
            writer.WriteStringValue("sp_metadata_url", SpMetadataUrl);
            writer.WriteBoolValue("sync_user_attributes", SyncUserAttributes);
            writer.WriteLongValue("updated_at", UpdatedAt);
            writer.WriteIntValue("user_count", UserCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
