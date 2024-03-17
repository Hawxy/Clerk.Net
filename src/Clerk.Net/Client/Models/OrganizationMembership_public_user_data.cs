// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Models {
    public class OrganizationMembership_public_user_data : IParsable {
        /// <summary>The first_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstName { get; set; }
#nullable restore
#else
        public string FirstName { get; set; }
#endif
        /// <summary>The has_image property</summary>
        public bool? HasImage { get; set; }
        /// <summary>The identifier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Identifier { get; set; }
#nullable restore
#else
        public string Identifier { get; set; }
#endif
        /// <summary>The image_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageUrl { get; set; }
#nullable restore
#else
        public string ImageUrl { get; set; }
#endif
        /// <summary>The last_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName { get; set; }
#nullable restore
#else
        public string LastName { get; set; }
#endif
        /// <summary>The profile_image_url property</summary>
        [Obsolete("")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProfileImageUrl { get; set; }
#nullable restore
#else
        public string ProfileImageUrl { get; set; }
#endif
        /// <summary>The user_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="OrganizationMembership_public_user_data"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OrganizationMembership_public_user_data CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrganizationMembership_public_user_data();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"first_name", n => { FirstName = n.GetStringValue(); } },
                {"has_image", n => { HasImage = n.GetBoolValue(); } },
                {"identifier", n => { Identifier = n.GetStringValue(); } },
                {"image_url", n => { ImageUrl = n.GetStringValue(); } },
                {"last_name", n => { LastName = n.GetStringValue(); } },
                {"profile_image_url", n => { ProfileImageUrl = n.GetStringValue(); } },
                {"user_id", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("first_name", FirstName);
            writer.WriteBoolValue("has_image", HasImage);
            writer.WriteStringValue("identifier", Identifier);
            writer.WriteStringValue("image_url", ImageUrl);
            writer.WriteStringValue("last_name", LastName);
            writer.WriteStringValue("profile_image_url", ProfileImageUrl);
            writer.WriteStringValue("user_id", UserId);
        }
    }
}
