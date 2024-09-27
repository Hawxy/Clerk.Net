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
    public partial class Oauth : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The attempts property</summary>
        public int? Attempts { get; set; }
        /// <summary>The error property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Clerk.Net.Client.Models.Oauth_error? Error { get; set; }
#nullable restore
#else
        public global::Clerk.Net.Client.Models.Oauth_error Error { get; set; }
#endif
        /// <summary>The expire_at property</summary>
        public int? ExpireAt { get; set; }
        /// <summary>The external_verification_redirect_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalVerificationRedirectUrl { get; set; }
#nullable restore
#else
        public string ExternalVerificationRedirectUrl { get; set; }
#endif
        /// <summary>The status property</summary>
        public global::Clerk.Net.Client.Models.Oauth_status? Status { get; set; }
        /// <summary>The strategy property</summary>
        public global::Clerk.Net.Client.Models.Oauth_strategy? Strategy { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.Oauth"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Models.Oauth CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Models.Oauth();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attempts", n => { Attempts = n.GetIntValue(); } },
                { "error", n => { Error = n.GetObjectValue<global::Clerk.Net.Client.Models.Oauth_error>(global::Clerk.Net.Client.Models.Oauth_error.CreateFromDiscriminatorValue); } },
                { "expire_at", n => { ExpireAt = n.GetIntValue(); } },
                { "external_verification_redirect_url", n => { ExternalVerificationRedirectUrl = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Clerk.Net.Client.Models.Oauth_status>(); } },
                { "strategy", n => { Strategy = n.GetEnumValue<global::Clerk.Net.Client.Models.Oauth_strategy>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("attempts", Attempts);
            writer.WriteObjectValue<global::Clerk.Net.Client.Models.Oauth_error>("error", Error);
            writer.WriteIntValue("expire_at", ExpireAt);
            writer.WriteStringValue("external_verification_redirect_url", ExternalVerificationRedirectUrl);
            writer.WriteEnumValue<global::Clerk.Net.Client.Models.Oauth_status>("status", Status);
            writer.WriteEnumValue<global::Clerk.Net.Client.Models.Oauth_strategy>("strategy", Strategy);
        }
    }
}
#pragma warning restore CS0618
