// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Clerk.Net.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class PhoneNumber : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The backup_codes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? BackupCodes { get; set; }
#nullable restore
#else
        public List<string> BackupCodes { get; set; }
#endif
        /// <summary>Unix timestamp of creation</summary>
        public long? CreatedAt { get; set; }
        /// <summary>The default_second_factor property</summary>
        public bool? DefaultSecondFactor { get; set; }
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The linked_to property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Clerk.Net.Client.Models.IdentificationLink>? LinkedTo { get; set; }
#nullable restore
#else
        public List<global::Clerk.Net.Client.Models.IdentificationLink> LinkedTo { get; set; }
#endif
        /// <summary>String representing the object&apos;s type. Objects of the same type share the same value.</summary>
        public global::Clerk.Net.Client.Models.PhoneNumber_object? Object { get; set; }
        /// <summary>The phone_number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumberProp { get; set; }
#nullable restore
#else
        public string PhoneNumberProp { get; set; }
#endif
        /// <summary>The reserved property</summary>
        public bool? Reserved { get; set; }
        /// <summary>The reserved_for_second_factor property</summary>
        public bool? ReservedForSecondFactor { get; set; }
        /// <summary>Unix timestamp of creation</summary>
        public long? UpdatedAt { get; set; }
        /// <summary>The verification property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Models.PhoneNumber.PhoneNumber_verification? Verification { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Models.PhoneNumber.PhoneNumber_verification Verification { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.PhoneNumber"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Models.PhoneNumber CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Models.PhoneNumber();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "backup_codes", n => { BackupCodes = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "created_at", n => { CreatedAt = n.GetLongValue(); } },
                { "default_second_factor", n => { DefaultSecondFactor = n.GetBoolValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "linked_to", n => { LinkedTo = n.GetCollectionOfObjectValues<global::Clerk.Net.Client.Models.IdentificationLink>(global::Clerk.Net.Client.Models.IdentificationLink.CreateFromDiscriminatorValue)?.AsList(); } },
                { "object", n => { Object = n.GetEnumValue<global::Clerk.Net.Client.Models.PhoneNumber_object>(); } },
                { "phone_number", n => { PhoneNumberProp = n.GetStringValue(); } },
                { "reserved", n => { Reserved = n.GetBoolValue(); } },
                { "reserved_for_second_factor", n => { ReservedForSecondFactor = n.GetBoolValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetLongValue(); } },
                { "verification", n => { Verification = n.GetObjectValue<global::Clerk.Net.Client.Models.PhoneNumber.PhoneNumber_verification>(global::Clerk.Net.Client.Models.PhoneNumber.PhoneNumber_verification.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("backup_codes", BackupCodes);
            writer.WriteLongValue("created_at", CreatedAt);
            writer.WriteBoolValue("default_second_factor", DefaultSecondFactor);
            writer.WriteStringValue("id", Id);
            writer.WriteCollectionOfObjectValues<global::Clerk.Net.Client.Models.IdentificationLink>("linked_to", LinkedTo);
            writer.WriteEnumValue<global::Clerk.Net.Client.Models.PhoneNumber_object>("object", Object);
            writer.WriteStringValue("phone_number", PhoneNumberProp);
            writer.WriteBoolValue("reserved", Reserved);
            writer.WriteBoolValue("reserved_for_second_factor", ReservedForSecondFactor);
            writer.WriteLongValue("updated_at", UpdatedAt);
            writer.WriteObjectValue<global::Clerk.Net.Client.Models.PhoneNumber.PhoneNumber_verification>("verification", Verification);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Clerk.Net.Client.Models.Admin"/>, <see cref="global::Clerk.Net.Client.Models.OTP"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class PhoneNumber_verification : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Clerk.Net.Client.Models.Admin"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Clerk.Net.Client.Models.Admin? Admin { get; set; }
#nullable restore
#else
            public global::Clerk.Net.Client.Models.Admin Admin { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Clerk.Net.Client.Models.OTP"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Clerk.Net.Client.Models.OTP? OTP { get; set; }
#nullable restore
#else
            public global::Clerk.Net.Client.Models.OTP OTP { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Clerk.Net.Client.Models.PhoneNumber.PhoneNumber_verification"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Clerk.Net.Client.Models.PhoneNumber.PhoneNumber_verification CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Clerk.Net.Client.Models.PhoneNumber.PhoneNumber_verification();
                if("Admin".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.Admin = new global::Clerk.Net.Client.Models.Admin();
                }
                else if("OTP".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.OTP = new global::Clerk.Net.Client.Models.OTP();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(Admin != null)
                {
                    return Admin.GetFieldDeserializers();
                }
                else if(OTP != null)
                {
                    return OTP.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(Admin != null)
                {
                    writer.WriteObjectValue<global::Clerk.Net.Client.Models.Admin>(null, Admin);
                }
                else if(OTP != null)
                {
                    writer.WriteObjectValue<global::Clerk.Net.Client.Models.OTP>(null, OTP);
                }
            }
        }
    }
}
#pragma warning restore CS0618
