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
    public partial class GetCampaignMessageResponseCollectionCompoundDocument : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Klaviyo.Models.GetCampaignMessageResponseCollectionCompoundDocument_data>? Data { get; set; }
#nullable restore
#else
        public List<global::Klaviyo.Models.GetCampaignMessageResponseCollectionCompoundDocument_data> Data { get; set; }
#endif
        /// <summary>The included property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Klaviyo.Models.GetCampaignMessageResponseCollectionCompoundDocument.GetCampaignMessageResponseCollectionCompoundDocument_included>? Included { get; set; }
#nullable restore
#else
        public List<global::Klaviyo.Models.GetCampaignMessageResponseCollectionCompoundDocument.GetCampaignMessageResponseCollectionCompoundDocument_included> Included { get; set; }
#endif
        /// <summary>The links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.CollectionLinks? Links { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.CollectionLinks Links { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.GetCampaignMessageResponseCollectionCompoundDocument"/> and sets the default values.
        /// </summary>
        public GetCampaignMessageResponseCollectionCompoundDocument()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetCampaignMessageResponseCollectionCompoundDocument"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.GetCampaignMessageResponseCollectionCompoundDocument CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.GetCampaignMessageResponseCollectionCompoundDocument();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "data", n => { Data = n.GetCollectionOfObjectValues<global::Klaviyo.Models.GetCampaignMessageResponseCollectionCompoundDocument_data>(global::Klaviyo.Models.GetCampaignMessageResponseCollectionCompoundDocument_data.CreateFromDiscriminatorValue)?.AsList(); } },
                { "included", n => { Included = n.GetCollectionOfObjectValues<global::Klaviyo.Models.GetCampaignMessageResponseCollectionCompoundDocument.GetCampaignMessageResponseCollectionCompoundDocument_included>(global::Klaviyo.Models.GetCampaignMessageResponseCollectionCompoundDocument.GetCampaignMessageResponseCollectionCompoundDocument_included.CreateFromDiscriminatorValue)?.AsList(); } },
                { "links", n => { Links = n.GetObjectValue<global::Klaviyo.Models.CollectionLinks>(global::Klaviyo.Models.CollectionLinks.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Klaviyo.Models.GetCampaignMessageResponseCollectionCompoundDocument_data>("data", Data);
            writer.WriteCollectionOfObjectValues<global::Klaviyo.Models.GetCampaignMessageResponseCollectionCompoundDocument.GetCampaignMessageResponseCollectionCompoundDocument_included>("included", Included);
            writer.WriteObjectValue<global::Klaviyo.Models.CollectionLinks>("links", Links);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Klaviyo.Models.CampaignResponseObjectResource"/>, <see cref="global::Klaviyo.Models.ImageResponseObjectResource"/>, <see cref="global::Klaviyo.Models.TemplateResponseObjectResource"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class GetCampaignMessageResponseCollectionCompoundDocument_included : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.CampaignResponseObjectResource"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.CampaignResponseObjectResource? CampaignResponseObjectResource { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.CampaignResponseObjectResource CampaignResponseObjectResource { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.ImageResponseObjectResource"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.ImageResponseObjectResource? ImageResponseObjectResource { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.ImageResponseObjectResource ImageResponseObjectResource { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.TemplateResponseObjectResource"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.TemplateResponseObjectResource? TemplateResponseObjectResource { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.TemplateResponseObjectResource TemplateResponseObjectResource { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Klaviyo.Models.GetCampaignMessageResponseCollectionCompoundDocument.GetCampaignMessageResponseCollectionCompoundDocument_included"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Klaviyo.Models.GetCampaignMessageResponseCollectionCompoundDocument.GetCampaignMessageResponseCollectionCompoundDocument_included CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Klaviyo.Models.GetCampaignMessageResponseCollectionCompoundDocument.GetCampaignMessageResponseCollectionCompoundDocument_included();
                if("CampaignResponseObjectResource".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.CampaignResponseObjectResource = new global::Klaviyo.Models.CampaignResponseObjectResource();
                }
                else if("ImageResponseObjectResource".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ImageResponseObjectResource = new global::Klaviyo.Models.ImageResponseObjectResource();
                }
                else if("TemplateResponseObjectResource".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.TemplateResponseObjectResource = new global::Klaviyo.Models.TemplateResponseObjectResource();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CampaignResponseObjectResource != null)
                {
                    return CampaignResponseObjectResource.GetFieldDeserializers();
                }
                else if(ImageResponseObjectResource != null)
                {
                    return ImageResponseObjectResource.GetFieldDeserializers();
                }
                else if(TemplateResponseObjectResource != null)
                {
                    return TemplateResponseObjectResource.GetFieldDeserializers();
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
                if(CampaignResponseObjectResource != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.CampaignResponseObjectResource>(null, CampaignResponseObjectResource);
                }
                else if(ImageResponseObjectResource != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.ImageResponseObjectResource>(null, ImageResponseObjectResource);
                }
                else if(TemplateResponseObjectResource != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.TemplateResponseObjectResource>(null, TemplateResponseObjectResource);
                }
            }
        }
    }
}
#pragma warning restore CS0618
