// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Klaviyo.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class SMSMessageDefinitionCreate : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The channel property</summary>
        public global::Klaviyo.Models.SmsEnum? Channel { get; set; }
        /// <summary>The content property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.SMSContentCreate? Content { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.SMSContentCreate Content { get; set; }
#endif
        /// <summary>The render_options property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.RenderOptions? RenderOptions { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.RenderOptions RenderOptions { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.SMSMessageDefinitionCreate"/> and sets the default values.
        /// </summary>
        public SMSMessageDefinitionCreate()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.SMSMessageDefinitionCreate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.SMSMessageDefinitionCreate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.SMSMessageDefinitionCreate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "channel", n => { Channel = n.GetEnumValue<global::Klaviyo.Models.SmsEnum>(); } },
                { "content", n => { Content = n.GetObjectValue<global::Klaviyo.Models.SMSContentCreate>(global::Klaviyo.Models.SMSContentCreate.CreateFromDiscriminatorValue); } },
                { "render_options", n => { RenderOptions = n.GetObjectValue<global::Klaviyo.Models.RenderOptions>(global::Klaviyo.Models.RenderOptions.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Klaviyo.Models.SmsEnum>("channel", Channel);
            writer.WriteObjectValue<global::Klaviyo.Models.SMSContentCreate>("content", Content);
            writer.WriteObjectValue<global::Klaviyo.Models.RenderOptions>("render_options", RenderOptions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
