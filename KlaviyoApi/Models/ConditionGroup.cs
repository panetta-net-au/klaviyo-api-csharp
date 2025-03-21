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
    public partial class ConditionGroup : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The conditions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Klaviyo.Models.ConditionGroup.ConditionGroup_conditions>? Conditions { get; set; }
#nullable restore
#else
        public List<global::Klaviyo.Models.ConditionGroup.ConditionGroup_conditions> Conditions { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.ConditionGroup"/> and sets the default values.
        /// </summary>
        public ConditionGroup()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.ConditionGroup"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.ConditionGroup CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.ConditionGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "conditions", n => { Conditions = n.GetCollectionOfObjectValues<global::Klaviyo.Models.ConditionGroup.ConditionGroup_conditions>(global::Klaviyo.Models.ConditionGroup.ConditionGroup_conditions.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::Klaviyo.Models.ConditionGroup.ConditionGroup_conditions>("conditions", Conditions);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Klaviyo.Models.ProfileHasGroupMembershipCondition"/>, <see cref="global::Klaviyo.Models.ProfileMarketingConsentCondition"/>, <see cref="global::Klaviyo.Models.ProfileNoGroupMembershipCondition"/>, <see cref="global::Klaviyo.Models.ProfilePostalCodeDistanceCondition"/>, <see cref="global::Klaviyo.Models.ProfilePredictiveAnalyticsNumericCondition"/>, <see cref="global::Klaviyo.Models.ProfilePredictiveAnalyticsStringCondition"/>, <see cref="global::Klaviyo.Models.ProfilePropertyCondition"/>, <see cref="global::Klaviyo.Models.ProfileRegionCondition"/>, <see cref="global::Klaviyo.Models.SegmentsProfileMetricCondition"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ConditionGroup_conditions : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.ProfileHasGroupMembershipCondition"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.ProfileHasGroupMembershipCondition? ProfileHasGroupMembershipCondition { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.ProfileHasGroupMembershipCondition ProfileHasGroupMembershipCondition { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.ProfileMarketingConsentCondition"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.ProfileMarketingConsentCondition? ProfileMarketingConsentCondition { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.ProfileMarketingConsentCondition ProfileMarketingConsentCondition { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.ProfileNoGroupMembershipCondition"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.ProfileNoGroupMembershipCondition? ProfileNoGroupMembershipCondition { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.ProfileNoGroupMembershipCondition ProfileNoGroupMembershipCondition { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.ProfilePostalCodeDistanceCondition"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.ProfilePostalCodeDistanceCondition? ProfilePostalCodeDistanceCondition { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.ProfilePostalCodeDistanceCondition ProfilePostalCodeDistanceCondition { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.ProfilePredictiveAnalyticsNumericCondition"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.ProfilePredictiveAnalyticsNumericCondition? ProfilePredictiveAnalyticsNumericCondition { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.ProfilePredictiveAnalyticsNumericCondition ProfilePredictiveAnalyticsNumericCondition { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.ProfilePredictiveAnalyticsStringCondition"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.ProfilePredictiveAnalyticsStringCondition? ProfilePredictiveAnalyticsStringCondition { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.ProfilePredictiveAnalyticsStringCondition ProfilePredictiveAnalyticsStringCondition { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.ProfilePropertyCondition"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.ProfilePropertyCondition? ProfilePropertyCondition { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.ProfilePropertyCondition ProfilePropertyCondition { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.ProfileRegionCondition"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.ProfileRegionCondition? ProfileRegionCondition { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.ProfileRegionCondition ProfileRegionCondition { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.SegmentsProfileMetricCondition"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.SegmentsProfileMetricCondition? SegmentsProfileMetricCondition { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.SegmentsProfileMetricCondition SegmentsProfileMetricCondition { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Klaviyo.Models.ConditionGroup.ConditionGroup_conditions"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Klaviyo.Models.ConditionGroup.ConditionGroup_conditions CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Klaviyo.Models.ConditionGroup.ConditionGroup_conditions();
                if("ProfileHasGroupMembershipCondition".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ProfileHasGroupMembershipCondition = new global::Klaviyo.Models.ProfileHasGroupMembershipCondition();
                }
                else if("ProfileMarketingConsentCondition".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ProfileMarketingConsentCondition = new global::Klaviyo.Models.ProfileMarketingConsentCondition();
                }
                else if("ProfileNoGroupMembershipCondition".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ProfileNoGroupMembershipCondition = new global::Klaviyo.Models.ProfileNoGroupMembershipCondition();
                }
                else if("ProfilePostalCodeDistanceCondition".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ProfilePostalCodeDistanceCondition = new global::Klaviyo.Models.ProfilePostalCodeDistanceCondition();
                }
                else if("ProfilePredictiveAnalyticsNumericCondition".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ProfilePredictiveAnalyticsNumericCondition = new global::Klaviyo.Models.ProfilePredictiveAnalyticsNumericCondition();
                }
                else if("ProfilePredictiveAnalyticsStringCondition".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ProfilePredictiveAnalyticsStringCondition = new global::Klaviyo.Models.ProfilePredictiveAnalyticsStringCondition();
                }
                else if("ProfilePropertyCondition".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ProfilePropertyCondition = new global::Klaviyo.Models.ProfilePropertyCondition();
                }
                else if("ProfileRegionCondition".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ProfileRegionCondition = new global::Klaviyo.Models.ProfileRegionCondition();
                }
                else if("SegmentsProfileMetricCondition".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SegmentsProfileMetricCondition = new global::Klaviyo.Models.SegmentsProfileMetricCondition();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(ProfileHasGroupMembershipCondition != null)
                {
                    return ProfileHasGroupMembershipCondition.GetFieldDeserializers();
                }
                else if(ProfileMarketingConsentCondition != null)
                {
                    return ProfileMarketingConsentCondition.GetFieldDeserializers();
                }
                else if(ProfileNoGroupMembershipCondition != null)
                {
                    return ProfileNoGroupMembershipCondition.GetFieldDeserializers();
                }
                else if(ProfilePostalCodeDistanceCondition != null)
                {
                    return ProfilePostalCodeDistanceCondition.GetFieldDeserializers();
                }
                else if(ProfilePredictiveAnalyticsNumericCondition != null)
                {
                    return ProfilePredictiveAnalyticsNumericCondition.GetFieldDeserializers();
                }
                else if(ProfilePredictiveAnalyticsStringCondition != null)
                {
                    return ProfilePredictiveAnalyticsStringCondition.GetFieldDeserializers();
                }
                else if(ProfilePropertyCondition != null)
                {
                    return ProfilePropertyCondition.GetFieldDeserializers();
                }
                else if(ProfileRegionCondition != null)
                {
                    return ProfileRegionCondition.GetFieldDeserializers();
                }
                else if(SegmentsProfileMetricCondition != null)
                {
                    return SegmentsProfileMetricCondition.GetFieldDeserializers();
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
                if(ProfileHasGroupMembershipCondition != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.ProfileHasGroupMembershipCondition>(null, ProfileHasGroupMembershipCondition);
                }
                else if(ProfileMarketingConsentCondition != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.ProfileMarketingConsentCondition>(null, ProfileMarketingConsentCondition);
                }
                else if(ProfileNoGroupMembershipCondition != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.ProfileNoGroupMembershipCondition>(null, ProfileNoGroupMembershipCondition);
                }
                else if(ProfilePostalCodeDistanceCondition != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.ProfilePostalCodeDistanceCondition>(null, ProfilePostalCodeDistanceCondition);
                }
                else if(ProfilePredictiveAnalyticsNumericCondition != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.ProfilePredictiveAnalyticsNumericCondition>(null, ProfilePredictiveAnalyticsNumericCondition);
                }
                else if(ProfilePredictiveAnalyticsStringCondition != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.ProfilePredictiveAnalyticsStringCondition>(null, ProfilePredictiveAnalyticsStringCondition);
                }
                else if(ProfilePropertyCondition != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.ProfilePropertyCondition>(null, ProfilePropertyCondition);
                }
                else if(ProfileRegionCondition != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.ProfileRegionCondition>(null, ProfileRegionCondition);
                }
                else if(SegmentsProfileMetricCondition != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.SegmentsProfileMetricCondition>(null, SegmentsProfileMetricCondition);
                }
            }
        }
    }
}
#pragma warning restore CS0618
