// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Saml_connections.Item {
    public class WithSaml_connection_PatchRequestBody : IParsable {
        /// <summary>Activate or de-activate the SAML Connection</summary>
        public bool? Active { get; set; }
        /// <summary>Enable or deactivate IdP-initiated flows</summary>
        public bool? AllowIdpInitiated { get; set; }
        /// <summary>Allow users with an email address subdomain to use this connection in order to authenticate</summary>
        public bool? AllowSubdomains { get; set; }
        /// <summary>Define the atrtibute name mapping between Identity Provider and Clerk&apos;s user properties</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WithSaml_connection_PatchRequestBody_attribute_mapping? AttributeMapping { get; set; }
#nullable restore
#else
        public WithSaml_connection_PatchRequestBody_attribute_mapping AttributeMapping { get; set; }
#endif
        /// <summary>The domain to use for the new SAML Connection</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Domain { get; set; }
#nullable restore
#else
        public string Domain { get; set; }
#endif
        /// <summary>The x509 certificated as provided by the IdP</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdpCertificate { get; set; }
#nullable restore
#else
        public string IdpCertificate { get; set; }
#endif
        /// <summary>The entity id as provided by the IdP</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdpEntityId { get; set; }
#nullable restore
#else
        public string IdpEntityId { get; set; }
#endif
        /// <summary>The URL which serves the IdP metadata. If present, it takes priority over the corresponding individual properties and replaces them</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdpMetadataUrl { get; set; }
#nullable restore
#else
        public string IdpMetadataUrl { get; set; }
#endif
        /// <summary>The SSO url as provided by the IdP</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdpSsoUrl { get; set; }
#nullable restore
#else
        public string IdpSsoUrl { get; set; }
#endif
        /// <summary>The name of the new SAML Connection</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Controls whether to update the user&apos;s attributes in each sign-in</summary>
        public bool? SyncUserAttributes { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WithSaml_connection_PatchRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WithSaml_connection_PatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WithSaml_connection_PatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"active", n => { Active = n.GetBoolValue(); } },
                {"allow_idp_initiated", n => { AllowIdpInitiated = n.GetBoolValue(); } },
                {"allow_subdomains", n => { AllowSubdomains = n.GetBoolValue(); } },
                {"attribute_mapping", n => { AttributeMapping = n.GetObjectValue<WithSaml_connection_PatchRequestBody_attribute_mapping>(WithSaml_connection_PatchRequestBody_attribute_mapping.CreateFromDiscriminatorValue); } },
                {"domain", n => { Domain = n.GetStringValue(); } },
                {"idp_certificate", n => { IdpCertificate = n.GetStringValue(); } },
                {"idp_entity_id", n => { IdpEntityId = n.GetStringValue(); } },
                {"idp_metadata_url", n => { IdpMetadataUrl = n.GetStringValue(); } },
                {"idp_sso_url", n => { IdpSsoUrl = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"sync_user_attributes", n => { SyncUserAttributes = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("active", Active);
            writer.WriteBoolValue("allow_idp_initiated", AllowIdpInitiated);
            writer.WriteBoolValue("allow_subdomains", AllowSubdomains);
            writer.WriteObjectValue<WithSaml_connection_PatchRequestBody_attribute_mapping>("attribute_mapping", AttributeMapping);
            writer.WriteStringValue("domain", Domain);
            writer.WriteStringValue("idp_certificate", IdpCertificate);
            writer.WriteStringValue("idp_entity_id", IdpEntityId);
            writer.WriteStringValue("idp_metadata_url", IdpMetadataUrl);
            writer.WriteStringValue("idp_sso_url", IdpSsoUrl);
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("sync_user_attributes", SyncUserAttributes);
        }
    }
}
