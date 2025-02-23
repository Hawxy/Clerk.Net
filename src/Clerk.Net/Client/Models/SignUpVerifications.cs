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
    public partial class SignUpVerifications : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The email_address property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Models.SignUpVerification? EmailAddress { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Models.SignUpVerification EmailAddress { get; set; }
#endif
        /// <summary>The external_account property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Models.SignUpVerifications_external_account? ExternalAccount { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Models.SignUpVerifications_external_account ExternalAccount { get; set; }
#endif
        /// <summary>The phone_number property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Models.SignUpVerification? PhoneNumber { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Models.SignUpVerification PhoneNumber { get; set; }
#endif
        /// <summary>The web3_wallet property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Models.SignUpVerification? Web3Wallet { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Models.SignUpVerification Web3Wallet { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.SignUpVerifications"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Models.SignUpVerifications CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Models.SignUpVerifications();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "email_address", n => { EmailAddress = n.GetObjectValue<global::Clerk.Net.Client.Models.SignUpVerification>(global::Clerk.Net.Client.Models.SignUpVerification.CreateFromDiscriminatorValue); } },
                { "external_account", n => { ExternalAccount = n.GetObjectValue<global::Clerk.Net.Client.Models.SignUpVerifications_external_account>(global::Clerk.Net.Client.Models.SignUpVerifications_external_account.CreateFromDiscriminatorValue); } },
                { "phone_number", n => { PhoneNumber = n.GetObjectValue<global::Clerk.Net.Client.Models.SignUpVerification>(global::Clerk.Net.Client.Models.SignUpVerification.CreateFromDiscriminatorValue); } },
                { "web3_wallet", n => { Web3Wallet = n.GetObjectValue<global::Clerk.Net.Client.Models.SignUpVerification>(global::Clerk.Net.Client.Models.SignUpVerification.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Clerk.Net.Client.Models.SignUpVerification>("email_address", EmailAddress);
            writer.WriteObjectValue<global::Clerk.Net.Client.Models.SignUpVerifications_external_account>("external_account", ExternalAccount);
            writer.WriteObjectValue<global::Clerk.Net.Client.Models.SignUpVerification>("phone_number", PhoneNumber);
            writer.WriteObjectValue<global::Clerk.Net.Client.Models.SignUpVerification>("web3_wallet", Web3Wallet);
        }
    }
}
#pragma warning restore CS0618
