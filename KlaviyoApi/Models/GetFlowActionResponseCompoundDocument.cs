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
    public partial class GetFlowActionResponseCompoundDocument : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.GetFlowActionResponseCompoundDocument_data? Data { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.GetFlowActionResponseCompoundDocument_data Data { get; set; }
#endif
        /// <summary>The included property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Klaviyo.Models.GetFlowActionResponseCompoundDocument.GetFlowActionResponseCompoundDocument_included>? Included { get; set; }
#nullable restore
#else
        public List<global::Klaviyo.Models.GetFlowActionResponseCompoundDocument.GetFlowActionResponseCompoundDocument_included> Included { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.GetFlowActionResponseCompoundDocument"/> and sets the default values.
        /// </summary>
        public GetFlowActionResponseCompoundDocument()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetFlowActionResponseCompoundDocument"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.GetFlowActionResponseCompoundDocument CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.GetFlowActionResponseCompoundDocument();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "data", n => { Data = n.GetObjectValue<global::Klaviyo.Models.GetFlowActionResponseCompoundDocument_data>(global::Klaviyo.Models.GetFlowActionResponseCompoundDocument_data.CreateFromDiscriminatorValue); } },
                { "included", n => { Included = n.GetCollectionOfObjectValues<global::Klaviyo.Models.GetFlowActionResponseCompoundDocument.GetFlowActionResponseCompoundDocument_included>(global::Klaviyo.Models.GetFlowActionResponseCompoundDocument.GetFlowActionResponseCompoundDocument_included.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Klaviyo.Models.GetFlowActionResponseCompoundDocument_data>("data", Data);
            writer.WriteCollectionOfObjectValues<global::Klaviyo.Models.GetFlowActionResponseCompoundDocument.GetFlowActionResponseCompoundDocument_included>("included", Included);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Klaviyo.Models.FlowMessageResponseObjectResource"/>, <see cref="global::Klaviyo.Models.FlowResponseObjectResource"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class GetFlowActionResponseCompoundDocument_included : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.FlowMessageResponseObjectResource"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.FlowMessageResponseObjectResource? FlowMessageResponseObjectResource { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.FlowMessageResponseObjectResource FlowMessageResponseObjectResource { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.FlowResponseObjectResource"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.FlowResponseObjectResource? FlowResponseObjectResource { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.FlowResponseObjectResource FlowResponseObjectResource { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Klaviyo.Models.GetFlowActionResponseCompoundDocument.GetFlowActionResponseCompoundDocument_included"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Klaviyo.Models.GetFlowActionResponseCompoundDocument.GetFlowActionResponseCompoundDocument_included CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Klaviyo.Models.GetFlowActionResponseCompoundDocument.GetFlowActionResponseCompoundDocument_included();
                if("FlowMessageResponseObjectResource".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.FlowMessageResponseObjectResource = new global::Klaviyo.Models.FlowMessageResponseObjectResource();
                }
                else if("FlowResponseObjectResource".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.FlowResponseObjectResource = new global::Klaviyo.Models.FlowResponseObjectResource();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(FlowMessageResponseObjectResource != null)
                {
                    return FlowMessageResponseObjectResource.GetFieldDeserializers();
                }
                else if(FlowResponseObjectResource != null)
                {
                    return FlowResponseObjectResource.GetFieldDeserializers();
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
                if(FlowMessageResponseObjectResource != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.FlowMessageResponseObjectResource>(null, FlowMessageResponseObjectResource);
                }
                else if(FlowResponseObjectResource != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.FlowResponseObjectResource>(null, FlowResponseObjectResource);
                }
            }
        }
    }
}
#pragma warning restore CS0618
