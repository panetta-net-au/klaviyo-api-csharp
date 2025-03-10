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
    public partial class TrackingSettingResponseObjectResource_attributes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether tracking parameters are automatically added to campaigns and flows.</summary>
        public bool? AutoAddParameters { get; set; }
        /// <summary>Additional custom tracking parameters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Klaviyo.Models.CustomTrackingParamDTO>? CustomParameters { get; set; }
#nullable restore
#else
        public List<global::Klaviyo.Models.CustomTrackingParamDTO> CustomParameters { get; set; }
#endif
        /// <summary>The utm_campaign property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.TrackingParamDTO? UtmCampaign { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.TrackingParamDTO UtmCampaign { get; set; }
#endif
        /// <summary>The utm_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.TrackingParamDTO? UtmId { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.TrackingParamDTO UtmId { get; set; }
#endif
        /// <summary>The utm_medium property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.TrackingParamDTO? UtmMedium { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.TrackingParamDTO UtmMedium { get; set; }
#endif
        /// <summary>The utm_source property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.TrackingParamDTO? UtmSource { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.TrackingParamDTO UtmSource { get; set; }
#endif
        /// <summary>The utm_term property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.TrackingParamDTO? UtmTerm { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.TrackingParamDTO UtmTerm { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.TrackingSettingResponseObjectResource_attributes"/> and sets the default values.
        /// </summary>
        public TrackingSettingResponseObjectResource_attributes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.TrackingSettingResponseObjectResource_attributes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.TrackingSettingResponseObjectResource_attributes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.TrackingSettingResponseObjectResource_attributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "auto_add_parameters", n => { AutoAddParameters = n.GetBoolValue(); } },
                { "custom_parameters", n => { CustomParameters = n.GetCollectionOfObjectValues<global::Klaviyo.Models.CustomTrackingParamDTO>(global::Klaviyo.Models.CustomTrackingParamDTO.CreateFromDiscriminatorValue)?.AsList(); } },
                { "utm_campaign", n => { UtmCampaign = n.GetObjectValue<global::Klaviyo.Models.TrackingParamDTO>(global::Klaviyo.Models.TrackingParamDTO.CreateFromDiscriminatorValue); } },
                { "utm_id", n => { UtmId = n.GetObjectValue<global::Klaviyo.Models.TrackingParamDTO>(global::Klaviyo.Models.TrackingParamDTO.CreateFromDiscriminatorValue); } },
                { "utm_medium", n => { UtmMedium = n.GetObjectValue<global::Klaviyo.Models.TrackingParamDTO>(global::Klaviyo.Models.TrackingParamDTO.CreateFromDiscriminatorValue); } },
                { "utm_source", n => { UtmSource = n.GetObjectValue<global::Klaviyo.Models.TrackingParamDTO>(global::Klaviyo.Models.TrackingParamDTO.CreateFromDiscriminatorValue); } },
                { "utm_term", n => { UtmTerm = n.GetObjectValue<global::Klaviyo.Models.TrackingParamDTO>(global::Klaviyo.Models.TrackingParamDTO.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("auto_add_parameters", AutoAddParameters);
            writer.WriteCollectionOfObjectValues<global::Klaviyo.Models.CustomTrackingParamDTO>("custom_parameters", CustomParameters);
            writer.WriteObjectValue<global::Klaviyo.Models.TrackingParamDTO>("utm_campaign", UtmCampaign);
            writer.WriteObjectValue<global::Klaviyo.Models.TrackingParamDTO>("utm_id", UtmId);
            writer.WriteObjectValue<global::Klaviyo.Models.TrackingParamDTO>("utm_medium", UtmMedium);
            writer.WriteObjectValue<global::Klaviyo.Models.TrackingParamDTO>("utm_source", UtmSource);
            writer.WriteObjectValue<global::Klaviyo.Models.TrackingParamDTO>("utm_term", UtmTerm);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
