// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Models {
    public class SAMLAccount : IParsable {
        /// <summary>The active property</summary>
        public bool? Active { get; set; }
        /// <summary>The email_address property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailAddress { get; set; }
#nullable restore
#else
        public string EmailAddress { get; set; }
#endif
        /// <summary>The first_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstName { get; set; }
#nullable restore
#else
        public string FirstName { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The last_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName { get; set; }
#nullable restore
#else
        public string LastName { get; set; }
#endif
        /// <summary>String representing the object&apos;s type. Objects of the same type share the same value.</summary>
        public SAMLAccount_object? Object { get; set; }
        /// <summary>The provider property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Provider { get; set; }
#nullable restore
#else
        public string Provider { get; set; }
#endif
        /// <summary>The provider_user_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProviderUserId { get; set; }
#nullable restore
#else
        public string ProviderUserId { get; set; }
#endif
        /// <summary>The verification property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SAMLAccount_verification? Verification { get; set; }
#nullable restore
#else
        public SAMLAccount_verification Verification { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SAMLAccount CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SAMLAccount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"active", n => { Active = n.GetBoolValue(); } },
                {"email_address", n => { EmailAddress = n.GetStringValue(); } },
                {"first_name", n => { FirstName = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"last_name", n => { LastName = n.GetStringValue(); } },
                {"object", n => { Object = n.GetEnumValue<SAMLAccount_object>(); } },
                {"provider", n => { Provider = n.GetStringValue(); } },
                {"provider_user_id", n => { ProviderUserId = n.GetStringValue(); } },
                {"verification", n => { Verification = n.GetObjectValue<SAMLAccount_verification>(SAMLAccount_verification.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("active", Active);
            writer.WriteStringValue("email_address", EmailAddress);
            writer.WriteStringValue("first_name", FirstName);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("last_name", LastName);
            writer.WriteEnumValue<SAMLAccount_object>("object", Object);
            writer.WriteStringValue("provider", Provider);
            writer.WriteStringValue("provider_user_id", ProviderUserId);
            writer.WriteObjectValue<SAMLAccount_verification>("verification", Verification);
        }
    }
}
