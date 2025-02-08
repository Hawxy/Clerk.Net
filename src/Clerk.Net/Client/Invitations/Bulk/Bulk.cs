// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Clerk.Net.Client.Invitations.Bulk
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Bulk : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The email address the invitation will be sent to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailAddress { get; set; }
#nullable restore
#else
        public string EmailAddress { get; set; }
#endif
        /// <summary>The number of days the invitation will be valid for. By default, the invitation expires after 30 days.</summary>
        public int? ExpiresInDays { get; set; }
        /// <summary>Whether an invitation should be created if there is already an existing invitation for this emailaddress, or it&apos;s claimed by another user.</summary>
        public bool? IgnoreExisting { get; set; }
        /// <summary>Optional flag which denotes whether an email invitation should be sent to the given email address.Defaults to true.</summary>
        public bool? Notify { get; set; }
        /// <summary>Metadata that will be attached to the newly created invitation.The value of this property should be a well-formed JSON object.Once the user accepts the invitation and signs up, these metadata will end up in the user&apos;s public metadata.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Invitations.Bulk.Bulk_public_metadata? PublicMetadata { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Invitations.Bulk.Bulk_public_metadata PublicMetadata { get; set; }
#endif
        /// <summary>The URL where the user is redirected upon visiting the invitation link, where they can accept the invitation. Required if you have implemented a [custom flow for handling application invitations](/docs/custom-flows/invitations).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RedirectUrl { get; set; }
#nullable restore
#else
        public string RedirectUrl { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Invitations.Bulk.Bulk"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Invitations.Bulk.Bulk CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Invitations.Bulk.Bulk();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "email_address", n => { EmailAddress = n.GetStringValue(); } },
                { "expires_in_days", n => { ExpiresInDays = n.GetIntValue(); } },
                { "ignore_existing", n => { IgnoreExisting = n.GetBoolValue(); } },
                { "notify", n => { Notify = n.GetBoolValue(); } },
                { "public_metadata", n => { PublicMetadata = n.GetObjectValue<global::Clerk.Net.Client.Invitations.Bulk.Bulk_public_metadata>(global::Clerk.Net.Client.Invitations.Bulk.Bulk_public_metadata.CreateFromDiscriminatorValue); } },
                { "redirect_url", n => { RedirectUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("email_address", EmailAddress);
            writer.WriteIntValue("expires_in_days", ExpiresInDays);
            writer.WriteBoolValue("ignore_existing", IgnoreExisting);
            writer.WriteBoolValue("notify", Notify);
            writer.WriteObjectValue<global::Clerk.Net.Client.Invitations.Bulk.Bulk_public_metadata>("public_metadata", PublicMetadata);
            writer.WriteStringValue("redirect_url", RedirectUrl);
        }
    }
}
#pragma warning restore CS0618
