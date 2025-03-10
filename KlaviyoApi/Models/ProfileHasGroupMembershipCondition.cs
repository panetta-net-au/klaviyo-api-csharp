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
    public partial class ProfileHasGroupMembershipCondition : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The group_ids property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? GroupIds { get; set; }
#nullable restore
#else
        public List<string> GroupIds { get; set; }
#endif
        /// <summary>The is_member property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? IsMember { get; set; }
#nullable restore
#else
        public UntypedNode IsMember { get; set; }
#endif
        /// <summary>The timeframe_filter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.ProfileHasGroupMembershipCondition.ProfileHasGroupMembershipCondition_timeframe_filter? TimeframeFilter { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.ProfileHasGroupMembershipCondition.ProfileHasGroupMembershipCondition_timeframe_filter TimeframeFilter { get; set; }
#endif
        /// <summary>The type property</summary>
        public global::Klaviyo.Models.ProfileGroupMembershipEnum? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.ProfileHasGroupMembershipCondition"/> and sets the default values.
        /// </summary>
        public ProfileHasGroupMembershipCondition()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.ProfileHasGroupMembershipCondition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.ProfileHasGroupMembershipCondition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.ProfileHasGroupMembershipCondition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "group_ids", n => { GroupIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "is_member", n => { IsMember = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "timeframe_filter", n => { TimeframeFilter = n.GetObjectValue<global::Klaviyo.Models.ProfileHasGroupMembershipCondition.ProfileHasGroupMembershipCondition_timeframe_filter>(global::Klaviyo.Models.ProfileHasGroupMembershipCondition.ProfileHasGroupMembershipCondition_timeframe_filter.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetEnumValue<global::Klaviyo.Models.ProfileGroupMembershipEnum>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("group_ids", GroupIds);
            writer.WriteObjectValue<UntypedNode>("is_member", IsMember);
            writer.WriteObjectValue<global::Klaviyo.Models.ProfileHasGroupMembershipCondition.ProfileHasGroupMembershipCondition_timeframe_filter>("timeframe_filter", TimeframeFilter);
            writer.WriteEnumValue<global::Klaviyo.Models.ProfileGroupMembershipEnum>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Klaviyo.Models.RelativeDateOperatorBaseFilter"/>, <see cref="global::Klaviyo.Models.RelativeDateRangeFilter"/>, <see cref="global::Klaviyo.Models.StaticDateFilter"/>, <see cref="global::Klaviyo.Models.StaticDateRangeFilter"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ProfileHasGroupMembershipCondition_timeframe_filter : IComposedTypeWrapper, IParsable
        {
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
            /// <returns>A <see cref="global::Klaviyo.Models.ProfileHasGroupMembershipCondition.ProfileHasGroupMembershipCondition_timeframe_filter"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Klaviyo.Models.ProfileHasGroupMembershipCondition.ProfileHasGroupMembershipCondition_timeframe_filter CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Klaviyo.Models.ProfileHasGroupMembershipCondition.ProfileHasGroupMembershipCondition_timeframe_filter();
                if("RelativeDateOperatorBaseFilter".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
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
                if(RelativeDateOperatorBaseFilter != null)
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
                if(RelativeDateOperatorBaseFilter != null)
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
