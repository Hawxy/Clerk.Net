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
    public partial class SAMLAccount_saml_connection : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The active property</summary>
        public bool? Active { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The allow_idp_initiated property</summary>
        public bool? AllowIdpInitiated { get; set; }
        /// <summary>The allow_subdomains property</summary>
        public bool? AllowSubdomains { get; set; }
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
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The provider property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Provider { get; set; }
#nullable restore
#else
        public string Provider { get; set; }
#endif
        /// <summary>The sync_user_attributes property</summary>
        public bool? SyncUserAttributes { get; set; }
        /// <summary>Unix timestamp of last update.</summary>
        public long? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Models.SAMLAccount_saml_connection"/> and sets the default values.
        /// </summary>
        public SAMLAccount_saml_connection()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.SAMLAccount_saml_connection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Models.SAMLAccount_saml_connection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Models.SAMLAccount_saml_connection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "active", n => { Active = n.GetBoolValue(); } },
                { "allow_idp_initiated", n => { AllowIdpInitiated = n.GetBoolValue(); } },
                { "allow_subdomains", n => { AllowSubdomains = n.GetBoolValue(); } },
                { "created_at", n => { CreatedAt = n.GetLongValue(); } },
                { "disable_additional_identifications", n => { DisableAdditionalIdentifications = n.GetBoolValue(); } },
                { "domain", n => { Domain = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "provider", n => { Provider = n.GetStringValue(); } },
                { "sync_user_attributes", n => { SyncUserAttributes = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("active", Active);
            writer.WriteBoolValue("allow_idp_initiated", AllowIdpInitiated);
            writer.WriteBoolValue("allow_subdomains", AllowSubdomains);
            writer.WriteLongValue("created_at", CreatedAt);
            writer.WriteBoolValue("disable_additional_identifications", DisableAdditionalIdentifications);
            writer.WriteStringValue("domain", Domain);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("provider", Provider);
            writer.WriteBoolValue("sync_user_attributes", SyncUserAttributes);
            writer.WriteLongValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
