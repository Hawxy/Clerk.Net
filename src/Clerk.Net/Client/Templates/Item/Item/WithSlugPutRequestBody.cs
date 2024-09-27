// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Clerk.Net.Client.Templates.Item.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class WithSlugPutRequestBody : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The template body before variable interpolation</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Body { get; set; }
#nullable restore
#else
        public string Body { get; set; }
#endif
        /// <summary>Whether Clerk should deliver emails or SMS messages based on the current template</summary>
        public bool? DeliveredByClerk { get; set; }
        /// <summary>The local part of the From email address that will be used for emails.For example, in the address &apos;hello@example.com&apos;, the local part is &apos;hello&apos;.Applicable only to email templates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FromEmailName { get; set; }
#nullable restore
#else
        public string FromEmailName { get; set; }
#endif
        /// <summary>The editor markup used to generate the body of the template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Markup { get; set; }
#nullable restore
#else
        public string Markup { get; set; }
#endif
        /// <summary>The user-friendly name of the template</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The local part of the Reply To email address that will be used for emails.For example, in the address &apos;hello@example.com&apos;, the local part is &apos;hello&apos;.Applicable only to email templates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReplyToEmailName { get; set; }
#nullable restore
#else
        public string ReplyToEmailName { get; set; }
#endif
        /// <summary>The email subject.Applicable only to email templates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Clerk.Net.Client.Templates.Item.Item.WithSlugPutRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Clerk.Net.Client.Templates.Item.Item.WithSlugPutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Clerk.Net.Client.Templates.Item.Item.WithSlugPutRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "body", n => { Body = n.GetStringValue(); } },
                { "delivered_by_clerk", n => { DeliveredByClerk = n.GetBoolValue(); } },
                { "from_email_name", n => { FromEmailName = n.GetStringValue(); } },
                { "markup", n => { Markup = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "reply_to_email_name", n => { ReplyToEmailName = n.GetStringValue(); } },
                { "subject", n => { Subject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("body", Body);
            writer.WriteBoolValue("delivered_by_clerk", DeliveredByClerk);
            writer.WriteStringValue("from_email_name", FromEmailName);
            writer.WriteStringValue("markup", Markup);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("reply_to_email_name", ReplyToEmailName);
            writer.WriteStringValue("subject", Subject);
        }
    }
}
#pragma warning restore CS0618
