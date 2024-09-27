// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Clerk.Net.Client.Instance.Change_domain
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class Change_domainPostRequestBody : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The new home URL of the production instance e.g. https://www.example.com</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HomeUrl { get; set; }
#nullable restore
#else
        public string HomeUrl { get; set; }
#endif
        /// <summary>Whether this is a domain for a secondary app, meaning that any subdomain provided is significant andwill be stored as part of the domain. This is useful for supporting multiple apps (one primary andmultiple secondaries) on the same root domain (eTLD+1).</summary>
        public bool? IsSecondary { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Instance.Change_domain.Change_domainPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Instance.Change_domain.Change_domainPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Instance.Change_domain.Change_domainPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "home_url", n => { HomeUrl = n.GetStringValue(); } },
                { "is_secondary", n => { IsSecondary = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("home_url", HomeUrl);
            writer.WriteBoolValue("is_secondary", IsSecondary);
        }
    }
}
#pragma warning restore CS0618
