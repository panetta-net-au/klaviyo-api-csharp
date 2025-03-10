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
    public partial class FlowWhatsApp : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The additional_filters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.FlowWhatsApp_additional_filters? AdditionalFilters { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.FlowWhatsApp_additional_filters AdditionalFilters { get; set; }
#endif
        /// <summary>The add_tracking_params property</summary>
        public bool? AddTrackingParams { get; set; }
        /// <summary>The custom_tracking_params property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Klaviyo.Models.UtmParam>? CustomTrackingParams { get; set; }
#nullable restore
#else
        public List<global::Klaviyo.Models.UtmParam> CustomTrackingParams { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The smart_sending_enabled property</summary>
        public bool? SmartSendingEnabled { get; set; }
        /// <summary>The transactional property</summary>
        public bool? Transactional { get; set; }
        /// <summary>The vendor_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VendorId { get; set; }
#nullable restore
#else
        public string VendorId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.FlowWhatsApp"/> and sets the default values.
        /// </summary>
        public FlowWhatsApp()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.FlowWhatsApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.FlowWhatsApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.FlowWhatsApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "add_tracking_params", n => { AddTrackingParams = n.GetBoolValue(); } },
                { "additional_filters", n => { AdditionalFilters = n.GetObjectValue<global::Klaviyo.Models.FlowWhatsApp_additional_filters>(global::Klaviyo.Models.FlowWhatsApp_additional_filters.CreateFromDiscriminatorValue); } },
                { "custom_tracking_params", n => { CustomTrackingParams = n.GetCollectionOfObjectValues<global::Klaviyo.Models.UtmParam>(global::Klaviyo.Models.UtmParam.CreateFromDiscriminatorValue)?.AsList(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "smart_sending_enabled", n => { SmartSendingEnabled = n.GetBoolValue(); } },
                { "transactional", n => { Transactional = n.GetBoolValue(); } },
                { "vendor_id", n => { VendorId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Klaviyo.Models.FlowWhatsApp_additional_filters>("additional_filters", AdditionalFilters);
            writer.WriteBoolValue("add_tracking_params", AddTrackingParams);
            writer.WriteCollectionOfObjectValues<global::Klaviyo.Models.UtmParam>("custom_tracking_params", CustomTrackingParams);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("smart_sending_enabled", SmartSendingEnabled);
            writer.WriteBoolValue("transactional", Transactional);
            writer.WriteStringValue("vendor_id", VendorId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
