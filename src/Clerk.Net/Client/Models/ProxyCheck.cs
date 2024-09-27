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
    public partial class ProxyCheck : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The created_at property</summary>
        public int? CreatedAt { get; set; }
        /// <summary>The domain_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DomainId { get; set; }
#nullable restore
#else
        public string DomainId { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The last_run_at property</summary>
        public int? LastRunAt { get; set; }
        /// <summary>The object property</summary>
        public global::Clerk.Net.Client.Models.ProxyCheck_object? Object { get; set; }
        /// <summary>The proxy_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProxyUrl { get; set; }
#nullable restore
#else
        public string ProxyUrl { get; set; }
#endif
        /// <summary>The successful property</summary>
        public bool? Successful { get; set; }
        /// <summary>The updated_at property</summary>
        public int? UpdatedAt { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.ProxyCheck"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Models.ProxyCheck CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Models.ProxyCheck();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetIntValue(); } },
                { "domain_id", n => { DomainId = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "last_run_at", n => { LastRunAt = n.GetIntValue(); } },
                { "object", n => { Object = n.GetEnumValue<global::Clerk.Net.Client.Models.ProxyCheck_object>(); } },
                { "proxy_url", n => { ProxyUrl = n.GetStringValue(); } },
                { "successful", n => { Successful = n.GetBoolValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("created_at", CreatedAt);
            writer.WriteStringValue("domain_id", DomainId);
            writer.WriteStringValue("id", Id);
            writer.WriteIntValue("last_run_at", LastRunAt);
            writer.WriteEnumValue<global::Clerk.Net.Client.Models.ProxyCheck_object>("object", Object);
            writer.WriteStringValue("proxy_url", ProxyUrl);
            writer.WriteBoolValue("successful", Successful);
            writer.WriteIntValue("updated_at", UpdatedAt);
        }
    }
}
#pragma warning restore CS0618
