// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Clerk.Net.Client.Models {
    public class OTP : IParsable 
    {
        /// <summary>The attempts property</summary>
        public int? Attempts { get; set; }
        /// <summary>The expire_at property</summary>
        public int? ExpireAt { get; set; }
        /// <summary>The status property</summary>
        public OTP_status? Status { get; set; }
        /// <summary>The strategy property</summary>
        public OTP_strategy? Strategy { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="OTP"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OTP CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OTP();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"attempts", n => { Attempts = n.GetIntValue(); } },
                {"expire_at", n => { ExpireAt = n.GetIntValue(); } },
                {"status", n => { Status = n.GetEnumValue<OTP_status>(); } },
                {"strategy", n => { Strategy = n.GetEnumValue<OTP_strategy>(); } },
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
            writer.WriteIntValue("expire_at", ExpireAt);
            writer.WriteEnumValue<OTP_status>("status", Status);
            writer.WriteEnumValue<OTP_strategy>("strategy", Strategy);
        }
    }
}
