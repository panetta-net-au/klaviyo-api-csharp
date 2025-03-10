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
    public partial class CampaignValuesRequestDTOResourceObject_attributes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>ID of the metric to be used for conversion statistics</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConversionMetricId { get; set; }
#nullable restore
#else
        public string ConversionMetricId { get; set; }
#endif
        /// <summary>API filter string used to filter the query.Allowed filters are send_channel, campaign_id.Allowed operators are equals, contains-any.Only one filter can be used per attribute, only AND can be used as a combination operator.Max of 100 messages per ANY filter.When filtering on send_channel, allowed values are email, sms, push-notification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Filter { get; set; }
#nullable restore
#else
        public string Filter { get; set; }
#endif
        /// <summary>List of statistics to query for. All rate statistics will be returned in fractional form [0.0, 1.0]</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Klaviyo.Models.CampaignValuesRequestDTOResourceObject_attributes_statistics?>? Statistics { get; set; }
#nullable restore
#else
        public List<global::Klaviyo.Models.CampaignValuesRequestDTOResourceObject_attributes_statistics?> Statistics { get; set; }
#endif
        /// <summary>The timeframe to query for data within. The max length a timeframe can be is 1 year</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.CampaignValuesRequestDTOResourceObject_attributes.CampaignValuesRequestDTOResourceObject_attributes_timeframe? Timeframe { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.CampaignValuesRequestDTOResourceObject_attributes.CampaignValuesRequestDTOResourceObject_attributes_timeframe Timeframe { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.CampaignValuesRequestDTOResourceObject_attributes"/> and sets the default values.
        /// </summary>
        public CampaignValuesRequestDTOResourceObject_attributes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.CampaignValuesRequestDTOResourceObject_attributes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.CampaignValuesRequestDTOResourceObject_attributes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.CampaignValuesRequestDTOResourceObject_attributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "conversion_metric_id", n => { ConversionMetricId = n.GetStringValue(); } },
                { "filter", n => { Filter = n.GetStringValue(); } },
                { "statistics", n => { Statistics = n.GetCollectionOfEnumValues<global::Klaviyo.Models.CampaignValuesRequestDTOResourceObject_attributes_statistics>()?.AsList(); } },
                { "timeframe", n => { Timeframe = n.GetObjectValue<global::Klaviyo.Models.CampaignValuesRequestDTOResourceObject_attributes.CampaignValuesRequestDTOResourceObject_attributes_timeframe>(global::Klaviyo.Models.CampaignValuesRequestDTOResourceObject_attributes.CampaignValuesRequestDTOResourceObject_attributes_timeframe.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("conversion_metric_id", ConversionMetricId);
            writer.WriteStringValue("filter", Filter);
            writer.WriteCollectionOfEnumValues<global::Klaviyo.Models.CampaignValuesRequestDTOResourceObject_attributes_statistics>("statistics", Statistics);
            writer.WriteObjectValue<global::Klaviyo.Models.CampaignValuesRequestDTOResourceObject_attributes.CampaignValuesRequestDTOResourceObject_attributes_timeframe>("timeframe", Timeframe);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Klaviyo.Models.CustomTimeframe"/>, <see cref="global::Klaviyo.Models.Timeframe"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CampaignValuesRequestDTOResourceObject_attributes_timeframe : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.CustomTimeframe"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.CustomTimeframe? CustomTimeframe { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.CustomTimeframe CustomTimeframe { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.Timeframe"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.Timeframe? Timeframe { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.Timeframe Timeframe { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Klaviyo.Models.CampaignValuesRequestDTOResourceObject_attributes.CampaignValuesRequestDTOResourceObject_attributes_timeframe"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Klaviyo.Models.CampaignValuesRequestDTOResourceObject_attributes.CampaignValuesRequestDTOResourceObject_attributes_timeframe CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Klaviyo.Models.CampaignValuesRequestDTOResourceObject_attributes.CampaignValuesRequestDTOResourceObject_attributes_timeframe();
                if("CustomTimeframe".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.CustomTimeframe = new global::Klaviyo.Models.CustomTimeframe();
                }
                else if("Timeframe".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.Timeframe = new global::Klaviyo.Models.Timeframe();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(CustomTimeframe != null)
                {
                    return CustomTimeframe.GetFieldDeserializers();
                }
                else if(Timeframe != null)
                {
                    return Timeframe.GetFieldDeserializers();
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
                if(CustomTimeframe != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.CustomTimeframe>(null, CustomTimeframe);
                }
                else if(Timeframe != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.Timeframe>(null, Timeframe);
                }
            }
        }
    }
}
#pragma warning restore CS0618
