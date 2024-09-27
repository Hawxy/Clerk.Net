// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Clerk.Net.Client.Phone_numbers
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class Phone_numbersPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The new phone number. Must adhere to the E.164 standard for phone number format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber { get; set; }
#nullable restore
#else
        public string PhoneNumber { get; set; }
#endif
        /// <summary>Create this phone number as the primary phone number for the user.Default: false, unless it is the first phone number.</summary>
        public bool? Primary { get; set; }
        /// <summary>Create this phone number as reserved for multi-factor authentication.The phone number must also be verified.If there are no other reserved second factors, the phone number will be set as the default second factor.</summary>
        public bool? ReservedForSecondFactor { get; set; }
        /// <summary>The ID representing the user</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>When created, the phone number will be marked as verified.</summary>
        public bool? Verified { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Phone_numbers.Phone_numbersPostRequestBody"/> and sets the default values.
        /// </summary>
        public Phone_numbersPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Phone_numbers.Phone_numbersPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Phone_numbers.Phone_numbersPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Phone_numbers.Phone_numbersPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "phone_number", n => { PhoneNumber = n.GetStringValue(); } },
                { "primary", n => { Primary = n.GetBoolValue(); } },
                { "reserved_for_second_factor", n => { ReservedForSecondFactor = n.GetBoolValue(); } },
                { "user_id", n => { UserId = n.GetStringValue(); } },
                { "verified", n => { Verified = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("phone_number", PhoneNumber);
            writer.WriteBoolValue("primary", Primary);
            writer.WriteBoolValue("reserved_for_second_factor", ReservedForSecondFactor);
            writer.WriteStringValue("user_id", UserId);
            writer.WriteBoolValue("verified", Verified);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
