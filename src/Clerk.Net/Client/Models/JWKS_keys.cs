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
    public partial class JWKS_keys : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The alg property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Alg { get; set; }
#nullable restore
#else
        public string Alg { get; set; }
#endif
        /// <summary>The crv property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Crv { get; set; }
#nullable restore
#else
        public string Crv { get; set; }
#endif
        /// <summary>The e property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? E { get; set; }
#nullable restore
#else
        public string E { get; set; }
#endif
        /// <summary>The kid property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Kid { get; set; }
#nullable restore
#else
        public string Kid { get; set; }
#endif
        /// <summary>The kty property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Kty { get; set; }
#nullable restore
#else
        public string Kty { get; set; }
#endif
        /// <summary>The n property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? N { get; set; }
#nullable restore
#else
        public string N { get; set; }
#endif
        /// <summary>The use property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Use { get; set; }
#nullable restore
#else
        public string Use { get; set; }
#endif
        /// <summary>The x property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? X { get; set; }
#nullable restore
#else
        public string X { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Models.JWKS_keys"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Models.JWKS_keys CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Models.JWKS_keys();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "alg", n => { Alg = n.GetStringValue(); } },
                { "crv", n => { Crv = n.GetStringValue(); } },
                { "e", n => { E = n.GetStringValue(); } },
                { "kid", n => { Kid = n.GetStringValue(); } },
                { "kty", n => { Kty = n.GetStringValue(); } },
                { "n", n => { N = n.GetStringValue(); } },
                { "use", n => { Use = n.GetStringValue(); } },
                { "x", n => { X = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("alg", Alg);
            writer.WriteStringValue("crv", Crv);
            writer.WriteStringValue("e", E);
            writer.WriteStringValue("kid", Kid);
            writer.WriteStringValue("kty", Kty);
            writer.WriteStringValue("n", N);
            writer.WriteStringValue("use", Use);
            writer.WriteStringValue("x", X);
        }
    }
}
#pragma warning restore CS0618