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
    public partial class InvalidEmailDateFilter : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The field property</summary>
        public global::Klaviyo.Models.Invalid_email_dateEnum? Field { get; set; }
        /// <summary>The filter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.InvalidEmailDateFilter.InvalidEmailDateFilter_filter? Filter { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.InvalidEmailDateFilter.InvalidEmailDateFilter_filter Filter { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.InvalidEmailDateFilter"/> and sets the default values.
        /// </summary>
        public InvalidEmailDateFilter()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.InvalidEmailDateFilter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.InvalidEmailDateFilter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.InvalidEmailDateFilter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "field", n => { Field = n.GetEnumValue<global::Klaviyo.Models.Invalid_email_dateEnum>(); } },
                { "filter", n => { Filter = n.GetObjectValue<global::Klaviyo.Models.InvalidEmailDateFilter.InvalidEmailDateFilter_filter>(global::Klaviyo.Models.InvalidEmailDateFilter.InvalidEmailDateFilter_filter.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Klaviyo.Models.Invalid_email_dateEnum>("field", Field);
            writer.WriteObjectValue<global::Klaviyo.Models.InvalidEmailDateFilter.InvalidEmailDateFilter_filter>("filter", Filter);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Klaviyo.Models.AnniversaryDateFilter"/>, <see cref="global::Klaviyo.Models.CalendarDateFilter"/>, <see cref="global::Klaviyo.Models.IsSetExistenceFilter"/>, <see cref="global::Klaviyo.Models.RelativeAnniversaryDateFilter"/>, <see cref="global::Klaviyo.Models.RelativeDateOperatorBaseFilter"/>, <see cref="global::Klaviyo.Models.RelativeDateRangeFilter"/>, <see cref="global::Klaviyo.Models.StaticDateFilter"/>, <see cref="global::Klaviyo.Models.StaticDateRangeFilter"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class InvalidEmailDateFilter_filter : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.AnniversaryDateFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.AnniversaryDateFilter? AnniversaryDateFilter { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.AnniversaryDateFilter AnniversaryDateFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.CalendarDateFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.CalendarDateFilter? CalendarDateFilter { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.CalendarDateFilter CalendarDateFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.IsSetExistenceFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.IsSetExistenceFilter? IsSetExistenceFilter { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.IsSetExistenceFilter IsSetExistenceFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.RelativeAnniversaryDateFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.RelativeAnniversaryDateFilter? RelativeAnniversaryDateFilter { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.RelativeAnniversaryDateFilter RelativeAnniversaryDateFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.RelativeDateOperatorBaseFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.RelativeDateOperatorBaseFilter? RelativeDateOperatorBaseFilter { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.RelativeDateOperatorBaseFilter RelativeDateOperatorBaseFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.RelativeDateRangeFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.RelativeDateRangeFilter? RelativeDateRangeFilter { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.RelativeDateRangeFilter RelativeDateRangeFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.StaticDateFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.StaticDateFilter? StaticDateFilter { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.StaticDateFilter StaticDateFilter { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.StaticDateRangeFilter"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.StaticDateRangeFilter? StaticDateRangeFilter { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.StaticDateRangeFilter StaticDateRangeFilter { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Klaviyo.Models.InvalidEmailDateFilter.InvalidEmailDateFilter_filter"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Klaviyo.Models.InvalidEmailDateFilter.InvalidEmailDateFilter_filter CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Klaviyo.Models.InvalidEmailDateFilter.InvalidEmailDateFilter_filter();
                if("AnniversaryDateFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.AnniversaryDateFilter = new global::Klaviyo.Models.AnniversaryDateFilter();
                }
                else if("CalendarDateFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.CalendarDateFilter = new global::Klaviyo.Models.CalendarDateFilter();
                }
                else if("IsSetExistenceFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.IsSetExistenceFilter = new global::Klaviyo.Models.IsSetExistenceFilter();
                }
                else if("RelativeAnniversaryDateFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.RelativeAnniversaryDateFilter = new global::Klaviyo.Models.RelativeAnniversaryDateFilter();
                }
                else if("RelativeDateOperatorBaseFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.RelativeDateOperatorBaseFilter = new global::Klaviyo.Models.RelativeDateOperatorBaseFilter();
                }
                else if("RelativeDateRangeFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.RelativeDateRangeFilter = new global::Klaviyo.Models.RelativeDateRangeFilter();
                }
                else if("StaticDateFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.StaticDateFilter = new global::Klaviyo.Models.StaticDateFilter();
                }
                else if("StaticDateRangeFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.StaticDateRangeFilter = new global::Klaviyo.Models.StaticDateRangeFilter();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(AnniversaryDateFilter != null)
                {
                    return AnniversaryDateFilter.GetFieldDeserializers();
                }
                else if(CalendarDateFilter != null)
                {
                    return CalendarDateFilter.GetFieldDeserializers();
                }
                else if(IsSetExistenceFilter != null)
                {
                    return IsSetExistenceFilter.GetFieldDeserializers();
                }
                else if(RelativeAnniversaryDateFilter != null)
                {
                    return RelativeAnniversaryDateFilter.GetFieldDeserializers();
                }
                else if(RelativeDateOperatorBaseFilter != null)
                {
                    return RelativeDateOperatorBaseFilter.GetFieldDeserializers();
                }
                else if(RelativeDateRangeFilter != null)
                {
                    return RelativeDateRangeFilter.GetFieldDeserializers();
                }
                else if(StaticDateFilter != null)
                {
                    return StaticDateFilter.GetFieldDeserializers();
                }
                else if(StaticDateRangeFilter != null)
                {
                    return StaticDateRangeFilter.GetFieldDeserializers();
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
                if(AnniversaryDateFilter != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.AnniversaryDateFilter>(null, AnniversaryDateFilter);
                }
                else if(CalendarDateFilter != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.CalendarDateFilter>(null, CalendarDateFilter);
                }
                else if(IsSetExistenceFilter != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.IsSetExistenceFilter>(null, IsSetExistenceFilter);
                }
                else if(RelativeAnniversaryDateFilter != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.RelativeAnniversaryDateFilter>(null, RelativeAnniversaryDateFilter);
                }
                else if(RelativeDateOperatorBaseFilter != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.RelativeDateOperatorBaseFilter>(null, RelativeDateOperatorBaseFilter);
                }
                else if(RelativeDateRangeFilter != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.RelativeDateRangeFilter>(null, RelativeDateRangeFilter);
                }
                else if(StaticDateFilter != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.StaticDateFilter>(null, StaticDateFilter);
                }
                else if(StaticDateRangeFilter != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.StaticDateRangeFilter>(null, StaticDateRangeFilter);
                }
            }
        }
    }
}
#pragma warning restore CS0618
