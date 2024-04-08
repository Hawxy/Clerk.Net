// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Models {
    public class SignUp : IParsable 
    {
        /// <summary>The abandon_at property</summary>
        public int? AbandonAt { get; set; }
        /// <summary>The created_session_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedSessionId { get; set; }
#nullable restore
#else
        public string CreatedSessionId { get; set; }
#endif
        /// <summary>The created_user_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedUserId { get; set; }
#nullable restore
#else
        public string CreatedUserId { get; set; }
#endif
        /// <summary>The custom_action property</summary>
        public bool? CustomAction { get; set; }
        /// <summary>The email_address property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailAddress { get; set; }
#nullable restore
#else
        public string EmailAddress { get; set; }
#endif
        /// <summary>The external_account property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SignUp_external_account? ExternalAccount { get; set; }
#nullable restore
#else
        public SignUp_external_account ExternalAccount { get; set; }
#endif
        /// <summary>The external_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
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
        /// <summary>The missing_fields property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MissingFields { get; set; }
#nullable restore
#else
        public List<string> MissingFields { get; set; }
#endif
        /// <summary>The object property</summary>
        public SignUp_object? Object { get; set; }
        /// <summary>The optional_fields property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? OptionalFields { get; set; }
#nullable restore
#else
        public List<string> OptionalFields { get; set; }
#endif
        /// <summary>The password_enabled property</summary>
        public bool? PasswordEnabled { get; set; }
        /// <summary>The phone_number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber { get; set; }
#nullable restore
#else
        public string PhoneNumber { get; set; }
#endif
        /// <summary>The public_metadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SignUp_public_metadata? PublicMetadata { get; set; }
#nullable restore
#else
        public SignUp_public_metadata PublicMetadata { get; set; }
#endif
        /// <summary>The required_fields property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RequiredFields { get; set; }
#nullable restore
#else
        public List<string> RequiredFields { get; set; }
#endif
        /// <summary>The status property</summary>
        public SignUp_status? Status { get; set; }
        /// <summary>The unsafe_metadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SignUp_unsafe_metadata? UnsafeMetadata { get; set; }
#nullable restore
#else
        public SignUp_unsafe_metadata UnsafeMetadata { get; set; }
#endif
        /// <summary>The unverified_fields property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? UnverifiedFields { get; set; }
#nullable restore
#else
        public List<string> UnverifiedFields { get; set; }
#endif
        /// <summary>The username property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Username { get; set; }
#nullable restore
#else
        public string Username { get; set; }
#endif
        /// <summary>The verifications property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SignUp_verifications? Verifications { get; set; }
#nullable restore
#else
        public SignUp_verifications Verifications { get; set; }
#endif
        /// <summary>The web3_wallet property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Web3Wallet { get; set; }
#nullable restore
#else
        public string Web3Wallet { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SignUp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SignUp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SignUp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"abandon_at", n => { AbandonAt = n.GetIntValue(); } },
                {"created_session_id", n => { CreatedSessionId = n.GetStringValue(); } },
                {"created_user_id", n => { CreatedUserId = n.GetStringValue(); } },
                {"custom_action", n => { CustomAction = n.GetBoolValue(); } },
                {"email_address", n => { EmailAddress = n.GetStringValue(); } },
                {"external_account", n => { ExternalAccount = n.GetObjectValue<SignUp_external_account>(SignUp_external_account.CreateFromDiscriminatorValue); } },
                {"external_id", n => { ExternalId = n.GetStringValue(); } },
                {"first_name", n => { FirstName = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"last_name", n => { LastName = n.GetStringValue(); } },
                {"missing_fields", n => { MissingFields = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"object", n => { Object = n.GetEnumValue<SignUp_object>(); } },
                {"optional_fields", n => { OptionalFields = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"password_enabled", n => { PasswordEnabled = n.GetBoolValue(); } },
                {"phone_number", n => { PhoneNumber = n.GetStringValue(); } },
                {"public_metadata", n => { PublicMetadata = n.GetObjectValue<SignUp_public_metadata>(SignUp_public_metadata.CreateFromDiscriminatorValue); } },
                {"required_fields", n => { RequiredFields = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"status", n => { Status = n.GetEnumValue<SignUp_status>(); } },
                {"unsafe_metadata", n => { UnsafeMetadata = n.GetObjectValue<SignUp_unsafe_metadata>(SignUp_unsafe_metadata.CreateFromDiscriminatorValue); } },
                {"unverified_fields", n => { UnverifiedFields = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"username", n => { Username = n.GetStringValue(); } },
                {"verifications", n => { Verifications = n.GetObjectValue<SignUp_verifications>(SignUp_verifications.CreateFromDiscriminatorValue); } },
                {"web3_wallet", n => { Web3Wallet = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("abandon_at", AbandonAt);
            writer.WriteStringValue("created_session_id", CreatedSessionId);
            writer.WriteStringValue("created_user_id", CreatedUserId);
            writer.WriteBoolValue("custom_action", CustomAction);
            writer.WriteStringValue("email_address", EmailAddress);
            writer.WriteObjectValue<SignUp_external_account>("external_account", ExternalAccount);
            writer.WriteStringValue("external_id", ExternalId);
            writer.WriteStringValue("first_name", FirstName);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("last_name", LastName);
            writer.WriteCollectionOfPrimitiveValues<string>("missing_fields", MissingFields);
            writer.WriteEnumValue<SignUp_object>("object", Object);
            writer.WriteCollectionOfPrimitiveValues<string>("optional_fields", OptionalFields);
            writer.WriteBoolValue("password_enabled", PasswordEnabled);
            writer.WriteStringValue("phone_number", PhoneNumber);
            writer.WriteObjectValue<SignUp_public_metadata>("public_metadata", PublicMetadata);
            writer.WriteCollectionOfPrimitiveValues<string>("required_fields", RequiredFields);
            writer.WriteEnumValue<SignUp_status>("status", Status);
            writer.WriteObjectValue<SignUp_unsafe_metadata>("unsafe_metadata", UnsafeMetadata);
            writer.WriteCollectionOfPrimitiveValues<string>("unverified_fields", UnverifiedFields);
            writer.WriteStringValue("username", Username);
            writer.WriteObjectValue<SignUp_verifications>("verifications", Verifications);
            writer.WriteStringValue("web3_wallet", Web3Wallet);
        }
    }
}
