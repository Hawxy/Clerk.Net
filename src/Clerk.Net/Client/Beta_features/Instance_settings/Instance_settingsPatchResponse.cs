// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Clerk.Net.Client.Beta_features.Instance_settings
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class Instance_settingsPatchResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The enhanced_email_deliverability property</summary>
        public bool? EnhancedEmailDeliverability { get; set; }
        /// <summary>The from_email_address property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FromEmailAddress { get; set; }
#nullable restore
#else
        public string FromEmailAddress { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>String representing the object&apos;s type. Objects of the same type share the same value.</summary>
        public global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsPatchResponse_object? Object { get; set; }
        /// <summary>The progressive_sign_up property</summary>
        public bool? ProgressiveSignUp { get; set; }
        /// <summary>The restricted_to_allowlist property</summary>
        public bool? RestrictedToAllowlist { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsPatchResponse"/> and sets the default values.
        /// </summary>
        public Instance_settingsPatchResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsPatchResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsPatchResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsPatchResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "enhanced_email_deliverability", n => { EnhancedEmailDeliverability = n.GetBoolValue(); } },
                { "from_email_address", n => { FromEmailAddress = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "object", n => { Object = n.GetEnumValue<global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsPatchResponse_object>(); } },
                { "progressive_sign_up", n => { ProgressiveSignUp = n.GetBoolValue(); } },
                { "restricted_to_allowlist", n => { RestrictedToAllowlist = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("enhanced_email_deliverability", EnhancedEmailDeliverability);
            writer.WriteStringValue("from_email_address", FromEmailAddress);
            writer.WriteStringValue("id", Id);
            writer.WriteEnumValue<global::Clerk.Net.Client.Beta_features.Instance_settings.Instance_settingsPatchResponse_object>("object", Object);
            writer.WriteBoolValue("progressive_sign_up", ProgressiveSignUp);
            writer.WriteBoolValue("restricted_to_allowlist", RestrictedToAllowlist);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
