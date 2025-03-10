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
    public partial class GetMetricPropertyResponseCollection_data_attributes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Inferred type for this metric property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InferredType { get; set; }
#nullable restore
#else
        public string InferredType { get; set; }
#endif
        /// <summary>The label for this metric property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label { get; set; }
#nullable restore
#else
        public string Label { get; set; }
#endif
        /// <summary>The property for this metric property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Property { get; set; }
#nullable restore
#else
        public string Property { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.GetMetricPropertyResponseCollection_data_attributes"/> and sets the default values.
        /// </summary>
        public GetMetricPropertyResponseCollection_data_attributes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetMetricPropertyResponseCollection_data_attributes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.GetMetricPropertyResponseCollection_data_attributes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.GetMetricPropertyResponseCollection_data_attributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "inferred_type", n => { InferredType = n.GetStringValue(); } },
                { "label", n => { Label = n.GetStringValue(); } },
                { "property", n => { Property = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("inferred_type", InferredType);
            writer.WriteStringValue("label", Label);
            writer.WriteStringValue("property", Property);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
