// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Clerk.Net.Client.Organizations.Item.Invitations.Bulk
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class Bulk : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The email address of the new member that is going to be invited to the organization</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailAddress { get; set; }
#nullable restore
#else
        public string EmailAddress { get; set; }
#endif
        /// <summary>The ID of the user that invites the new member to the organization.Must be an administrator in the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InviterUserId { get; set; }
#nullable restore
#else
        public string InviterUserId { get; set; }
#endif
        /// <summary>Metadata saved on the organization invitation, fully accessible (read/write) from the Backend API but not visible from the Frontend API.When the organization invitation is accepted, the metadata will be transferred to the newly created organization membership.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Organizations.Item.Invitations.Bulk.Bulk_private_metadata? PrivateMetadata { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Organizations.Item.Invitations.Bulk.Bulk_private_metadata PrivateMetadata { get; set; }
#endif
        /// <summary>Metadata saved on the organization invitation, read-only from the Frontend API and fully accessible (read/write) from the Backend API.When the organization invitation is accepted, the metadata will be transferred to the newly created organization membership.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Organizations.Item.Invitations.Bulk.Bulk_public_metadata? PublicMetadata { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Organizations.Item.Invitations.Bulk.Bulk_public_metadata PublicMetadata { get; set; }
#endif
        /// <summary>Optional URL that the invitee will be redirected to once they accept the invitation by clicking the join link in the invitation email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RedirectUrl { get; set; }
#nullable restore
#else
        public string RedirectUrl { get; set; }
#endif
        /// <summary>The role of the new member in the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Role { get; set; }
#nullable restore
#else
        public string Role { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Clerk.Net.Client.Organizations.Item.Invitations.Bulk.Bulk"/> and sets the default values.
        /// </summary>
        public Bulk()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Organizations.Item.Invitations.Bulk.Bulk"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Organizations.Item.Invitations.Bulk.Bulk CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Organizations.Item.Invitations.Bulk.Bulk();
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
                { "inviter_user_id", n => { InviterUserId = n.GetStringValue(); } },
                { "private_metadata", n => { PrivateMetadata = n.GetObjectValue<global::Clerk.Net.Client.Organizations.Item.Invitations.Bulk.Bulk_private_metadata>(global::Clerk.Net.Client.Organizations.Item.Invitations.Bulk.Bulk_private_metadata.CreateFromDiscriminatorValue); } },
                { "public_metadata", n => { PublicMetadata = n.GetObjectValue<global::Clerk.Net.Client.Organizations.Item.Invitations.Bulk.Bulk_public_metadata>(global::Clerk.Net.Client.Organizations.Item.Invitations.Bulk.Bulk_public_metadata.CreateFromDiscriminatorValue); } },
                { "redirect_url", n => { RedirectUrl = n.GetStringValue(); } },
                { "role", n => { Role = n.GetStringValue(); } },
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
            writer.WriteStringValue("inviter_user_id", InviterUserId);
            writer.WriteObjectValue<global::Clerk.Net.Client.Organizations.Item.Invitations.Bulk.Bulk_private_metadata>("private_metadata", PrivateMetadata);
            writer.WriteObjectValue<global::Clerk.Net.Client.Organizations.Item.Invitations.Bulk.Bulk_public_metadata>("public_metadata", PublicMetadata);
            writer.WriteStringValue("redirect_url", RedirectUrl);
            writer.WriteStringValue("role", Role);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
