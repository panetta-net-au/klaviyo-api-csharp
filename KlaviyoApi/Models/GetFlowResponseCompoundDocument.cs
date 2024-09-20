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
    public partial class GetFlowResponseCompoundDocument : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.FlowResponseObjectResource? Data { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.FlowResponseObjectResource Data { get; set; }
#endif
        /// <summary>The included property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Klaviyo.Models.GetFlowResponseCompoundDocument.GetFlowResponseCompoundDocument_included>? Included { get; set; }
#nullable restore
#else
        public List<global::Klaviyo.Models.GetFlowResponseCompoundDocument.GetFlowResponseCompoundDocument_included> Included { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.GetFlowResponseCompoundDocument"/> and sets the default values.
        /// </summary>
        public GetFlowResponseCompoundDocument()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetFlowResponseCompoundDocument"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.GetFlowResponseCompoundDocument CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.GetFlowResponseCompoundDocument();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "data", n => { Data = n.GetObjectValue<global::Klaviyo.Models.FlowResponseObjectResource>(global::Klaviyo.Models.FlowResponseObjectResource.CreateFromDiscriminatorValue); } },
                { "included", n => { Included = n.GetCollectionOfObjectValues<global::Klaviyo.Models.GetFlowResponseCompoundDocument.GetFlowResponseCompoundDocument_included>(global::Klaviyo.Models.GetFlowResponseCompoundDocument.GetFlowResponseCompoundDocument_included.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Klaviyo.Models.FlowResponseObjectResource>("data", Data);
            writer.WriteCollectionOfObjectValues<global::Klaviyo.Models.GetFlowResponseCompoundDocument.GetFlowResponseCompoundDocument_included>("included", Included);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Klaviyo.Models.FlowActionResponseObjectResource"/>, <see cref="global::Klaviyo.Models.TagResponseObjectResource"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class GetFlowResponseCompoundDocument_included : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.FlowActionResponseObjectResource"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.FlowActionResponseObjectResource? FlowActionResponseObjectResource { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.FlowActionResponseObjectResource FlowActionResponseObjectResource { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.TagResponseObjectResource"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.TagResponseObjectResource? TagResponseObjectResource { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.TagResponseObjectResource TagResponseObjectResource { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Klaviyo.Models.GetFlowResponseCompoundDocument.GetFlowResponseCompoundDocument_included"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Klaviyo.Models.GetFlowResponseCompoundDocument.GetFlowResponseCompoundDocument_included CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Klaviyo.Models.GetFlowResponseCompoundDocument.GetFlowResponseCompoundDocument_included();
                if("FlowActionResponseObjectResource".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.FlowActionResponseObjectResource = new global::Klaviyo.Models.FlowActionResponseObjectResource();
                }
                else if("TagResponseObjectResource".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.TagResponseObjectResource = new global::Klaviyo.Models.TagResponseObjectResource();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(FlowActionResponseObjectResource != null)
                {
                    return FlowActionResponseObjectResource.GetFieldDeserializers();
                }
                else if(TagResponseObjectResource != null)
                {
                    return TagResponseObjectResource.GetFieldDeserializers();
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
                if(FlowActionResponseObjectResource != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.FlowActionResponseObjectResource>(null, FlowActionResponseObjectResource);
                }
                else if(TagResponseObjectResource != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.TagResponseObjectResource>(null, TagResponseObjectResource);
                }
            }
        }
    }
}
#pragma warning restore CS0618
