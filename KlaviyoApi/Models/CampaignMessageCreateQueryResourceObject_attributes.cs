// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Klaviyo.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    #pragma warning disable CS1591
    public partial class CampaignMessageCreateQueryResourceObject_attributes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The channel the message is to be sent on (email or sms, for example)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Channel { get; set; }
#nullable restore
#else
        public string Channel { get; set; }
#endif
        /// <summary>Additional attributes relating to the content of the message</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.CampaignMessageCreateQueryResourceObject_attributes.CampaignMessageCreateQueryResourceObject_attributes_content? Content { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.CampaignMessageCreateQueryResourceObject_attributes.CampaignMessageCreateQueryResourceObject_attributes_content Content { get; set; }
#endif
        /// <summary>The label or name on the message</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label { get; set; }
#nullable restore
#else
        public string Label { get; set; }
#endif
        /// <summary>The render_options property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.RenderOptionsSubObject? RenderOptions { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.RenderOptionsSubObject RenderOptions { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.CampaignMessageCreateQueryResourceObject_attributes"/> and sets the default values.
        /// </summary>
        public CampaignMessageCreateQueryResourceObject_attributes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.CampaignMessageCreateQueryResourceObject_attributes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.CampaignMessageCreateQueryResourceObject_attributes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.CampaignMessageCreateQueryResourceObject_attributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "channel", n => { Channel = n.GetStringValue(); } },
                { "content", n => { Content = n.GetObjectValue<global::Klaviyo.Models.CampaignMessageCreateQueryResourceObject_attributes.CampaignMessageCreateQueryResourceObject_attributes_content>(global::Klaviyo.Models.CampaignMessageCreateQueryResourceObject_attributes.CampaignMessageCreateQueryResourceObject_attributes_content.CreateFromDiscriminatorValue); } },
                { "label", n => { Label = n.GetStringValue(); } },
                { "render_options", n => { RenderOptions = n.GetObjectValue<global::Klaviyo.Models.RenderOptionsSubObject>(global::Klaviyo.Models.RenderOptionsSubObject.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("channel", Channel);
            writer.WriteObjectValue<global::Klaviyo.Models.CampaignMessageCreateQueryResourceObject_attributes.CampaignMessageCreateQueryResourceObject_attributes_content>("content", Content);
            writer.WriteStringValue("label", Label);
            writer.WriteObjectValue<global::Klaviyo.Models.RenderOptionsSubObject>("render_options", RenderOptions);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Klaviyo.Models.EmailContentSubObject"/>, <see cref="global::Klaviyo.Models.SMSContentSubObjectCreate"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class CampaignMessageCreateQueryResourceObject_attributes_content : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.EmailContentSubObject"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.EmailContentSubObject? EmailContentSubObject { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.EmailContentSubObject EmailContentSubObject { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.SMSContentSubObjectCreate"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.SMSContentSubObjectCreate? SMSContentSubObjectCreate { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.SMSContentSubObjectCreate SMSContentSubObjectCreate { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Klaviyo.Models.CampaignMessageCreateQueryResourceObject_attributes.CampaignMessageCreateQueryResourceObject_attributes_content"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Klaviyo.Models.CampaignMessageCreateQueryResourceObject_attributes.CampaignMessageCreateQueryResourceObject_attributes_content CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Klaviyo.Models.CampaignMessageCreateQueryResourceObject_attributes.CampaignMessageCreateQueryResourceObject_attributes_content();
                if("EmailContentSubObject".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.EmailContentSubObject = new global::Klaviyo.Models.EmailContentSubObject();
                }
                else if("SMSContentSubObjectCreate".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SMSContentSubObjectCreate = new global::Klaviyo.Models.SMSContentSubObjectCreate();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(EmailContentSubObject != null)
                {
                    return EmailContentSubObject.GetFieldDeserializers();
                }
                else if(SMSContentSubObjectCreate != null)
                {
                    return SMSContentSubObjectCreate.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(EmailContentSubObject != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.EmailContentSubObject>(null, EmailContentSubObject);
                }
                else if(SMSContentSubObjectCreate != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.SMSContentSubObjectCreate>(null, SMSContentSubObjectCreate);
                }
            }
        }
    }
}
#pragma warning restore CS0618
