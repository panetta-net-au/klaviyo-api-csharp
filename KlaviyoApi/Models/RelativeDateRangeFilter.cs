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
    public partial class RelativeDateRangeFilter : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The end property</summary>
        public int? End { get; set; }
        /// <summary>Operators for relative date range filters.e.g. &quot;between 10 and 20 days ago&quot;</summary>
        public global::Klaviyo.Models.RelativeDateRangeFilter_operator? Operator { get; set; }
        /// <summary>The start property</summary>
        public int? Start { get; set; }
        /// <summary>The type property</summary>
        public global::Klaviyo.Models.DateEnum? Type { get; set; }
        /// <summary>Units for relative date filters.</summary>
        public global::Klaviyo.Models.RelativeDateRangeFilter_unit? Unit { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.RelativeDateRangeFilter"/> and sets the default values.
        /// </summary>
        public RelativeDateRangeFilter()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.RelativeDateRangeFilter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.RelativeDateRangeFilter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.RelativeDateRangeFilter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "end", n => { End = n.GetIntValue(); } },
                { "operator", n => { Operator = n.GetEnumValue<global::Klaviyo.Models.RelativeDateRangeFilter_operator>(); } },
                { "start", n => { Start = n.GetIntValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::Klaviyo.Models.DateEnum>(); } },
                { "unit", n => { Unit = n.GetEnumValue<global::Klaviyo.Models.RelativeDateRangeFilter_unit>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("end", End);
            writer.WriteEnumValue<global::Klaviyo.Models.RelativeDateRangeFilter_operator>("operator", Operator);
            writer.WriteIntValue("start", Start);
            writer.WriteEnumValue<global::Klaviyo.Models.DateEnum>("type", Type);
            writer.WriteEnumValue<global::Klaviyo.Models.RelativeDateRangeFilter_unit>("unit", Unit);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
