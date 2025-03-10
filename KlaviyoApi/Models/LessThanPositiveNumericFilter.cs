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
    public partial class LessThanPositiveNumericFilter : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The operator property</summary>
        public global::Klaviyo.Models.LessThanEnum? Operator { get; set; }
        /// <summary>The type property</summary>
        public global::Klaviyo.Models.NumericEnum? Type { get; set; }
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.LessThanPositiveNumericFilter.LessThanPositiveNumericFilter_value? Value { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.LessThanPositiveNumericFilter.LessThanPositiveNumericFilter_value Value { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.LessThanPositiveNumericFilter"/> and sets the default values.
        /// </summary>
        public LessThanPositiveNumericFilter()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.LessThanPositiveNumericFilter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.LessThanPositiveNumericFilter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.LessThanPositiveNumericFilter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "operator", n => { Operator = n.GetEnumValue<global::Klaviyo.Models.LessThanEnum>(); } },
                { "type", n => { Type = n.GetEnumValue<global::Klaviyo.Models.NumericEnum>(); } },
                { "value", n => { Value = n.GetObjectValue<global::Klaviyo.Models.LessThanPositiveNumericFilter.LessThanPositiveNumericFilter_value>(global::Klaviyo.Models.LessThanPositiveNumericFilter.LessThanPositiveNumericFilter_value.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Klaviyo.Models.LessThanEnum>("operator", Operator);
            writer.WriteEnumValue<global::Klaviyo.Models.NumericEnum>("type", Type);
            writer.WriteObjectValue<global::Klaviyo.Models.LessThanPositiveNumericFilter.LessThanPositiveNumericFilter_value>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="double"/>, <see cref="int"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LessThanPositiveNumericFilter_value : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="double"/></summary>
            public double? Double { get; set; }
            /// <summary>Composed type representation for type <see cref="int"/></summary>
            public int? Integer { get; set; }
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Klaviyo.Models.LessThanPositiveNumericFilter.LessThanPositiveNumericFilter_value"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Klaviyo.Models.LessThanPositiveNumericFilter.LessThanPositiveNumericFilter_value CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Klaviyo.Models.LessThanPositiveNumericFilter.LessThanPositiveNumericFilter_value();
                if(parseNode.GetDoubleValue() is double doubleValue)
                {
                    result.Double = doubleValue;
                }
                else if(parseNode.GetIntValue() is int integerValue)
                {
                    result.Integer = integerValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(Double != null)
                {
                    writer.WriteDoubleValue(null, Double);
                }
                else if(Integer != null)
                {
                    writer.WriteIntValue(null, Integer);
                }
            }
        }
    }
}
#pragma warning restore CS0618
