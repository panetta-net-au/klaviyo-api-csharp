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
    public partial class BaseEventCreateQueryBulkEntryResourceObject_attributes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The metric property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.BaseEventCreateQueryBulkEntryResourceObject_attributes_metric? Metric { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.BaseEventCreateQueryBulkEntryResourceObject_attributes_metric Metric { get; set; }
#endif
        /// <summary>Properties of this event. Any top level property (that are not objects) can beused to create segments. The $extra property is a special property. This records anynon-segmentable values that can be referenced later. For example, HTML templates areuseful on a segment but are not used to create a segment. There are limitsplaced onto the size of the data present. This must not exceed 5 MB. This must notexceed 300 event properties. A single string cannot be larger than 100 KB. Each arraymust not exceed 4000 elements. The properties cannot contain more than 10 nested levels.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.BaseEventCreateQueryBulkEntryResourceObject_attributes_properties? Properties { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.BaseEventCreateQueryBulkEntryResourceObject_attributes_properties Properties { get; set; }
#endif
        /// <summary>When this event occurred. By default, the time the request was received will be used.The time is truncated to the second. The time must be after the year 2000 and can onlybe up to 1 year in the future.</summary>
        public DateTimeOffset? Time { get; set; }
        /// <summary>A unique identifier for an event. If a unique_id is repeated for the same profile and metric,the request will fail and no events will be processed. If this field is notpresent, this field will use the time to the second. Using the default, this limits only oneevent per profile per second.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UniqueId { get; set; }
#nullable restore
#else
        public string UniqueId { get; set; }
#endif
        /// <summary>A numeric, monetary value to associate with this event. For example, the dollar amount of a purchase.</summary>
        public double? Value { get; set; }
        /// <summary>The ISO 4217 currency code of the value associated with the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValueCurrency { get; set; }
#nullable restore
#else
        public string ValueCurrency { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.BaseEventCreateQueryBulkEntryResourceObject_attributes"/> and sets the default values.
        /// </summary>
        public BaseEventCreateQueryBulkEntryResourceObject_attributes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.BaseEventCreateQueryBulkEntryResourceObject_attributes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.BaseEventCreateQueryBulkEntryResourceObject_attributes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.BaseEventCreateQueryBulkEntryResourceObject_attributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "metric", n => { Metric = n.GetObjectValue<global::Klaviyo.Models.BaseEventCreateQueryBulkEntryResourceObject_attributes_metric>(global::Klaviyo.Models.BaseEventCreateQueryBulkEntryResourceObject_attributes_metric.CreateFromDiscriminatorValue); } },
                { "properties", n => { Properties = n.GetObjectValue<global::Klaviyo.Models.BaseEventCreateQueryBulkEntryResourceObject_attributes_properties>(global::Klaviyo.Models.BaseEventCreateQueryBulkEntryResourceObject_attributes_properties.CreateFromDiscriminatorValue); } },
                { "time", n => { Time = n.GetDateTimeOffsetValue(); } },
                { "unique_id", n => { UniqueId = n.GetStringValue(); } },
                { "value", n => { Value = n.GetDoubleValue(); } },
                { "value_currency", n => { ValueCurrency = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Klaviyo.Models.BaseEventCreateQueryBulkEntryResourceObject_attributes_metric>("metric", Metric);
            writer.WriteObjectValue<global::Klaviyo.Models.BaseEventCreateQueryBulkEntryResourceObject_attributes_properties>("properties", Properties);
            writer.WriteDateTimeOffsetValue("time", Time);
            writer.WriteStringValue("unique_id", UniqueId);
            writer.WriteDoubleValue("value", Value);
            writer.WriteStringValue("value_currency", ValueCurrency);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
