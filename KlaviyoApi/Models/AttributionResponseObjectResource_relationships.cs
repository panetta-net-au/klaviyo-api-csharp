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
    public partial class AttributionResponseObjectResource_relationships : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The attributedEvent property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.AttributionResponseObjectResource_relationships_attributedEvent? AttributedEvent { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.AttributionResponseObjectResource_relationships_attributedEvent AttributedEvent { get; set; }
#endif
        /// <summary>The campaign property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.AttributionResponseObjectResource_relationships_campaign? Campaign { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.AttributionResponseObjectResource_relationships_campaign Campaign { get; set; }
#endif
        /// <summary>The campaignMessage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.AttributionResponseObjectResource_relationships_campaignMessage? CampaignMessage { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.AttributionResponseObjectResource_relationships_campaignMessage CampaignMessage { get; set; }
#endif
        /// <summary>The event property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.AttributionResponseObjectResource_relationships_event? Event { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.AttributionResponseObjectResource_relationships_event Event { get; set; }
#endif
        /// <summary>The flow property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.AttributionResponseObjectResource_relationships_flow? Flow { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.AttributionResponseObjectResource_relationships_flow Flow { get; set; }
#endif
        /// <summary>The flowMessage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.AttributionResponseObjectResource_relationships_flowMessage? FlowMessage { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.AttributionResponseObjectResource_relationships_flowMessage FlowMessage { get; set; }
#endif
        /// <summary>The flowMessageVariation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.AttributionResponseObjectResource_relationships_flowMessageVariation? FlowMessageVariation { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.AttributionResponseObjectResource_relationships_flowMessageVariation FlowMessageVariation { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.AttributionResponseObjectResource_relationships"/> and sets the default values.
        /// </summary>
        public AttributionResponseObjectResource_relationships()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.AttributionResponseObjectResource_relationships"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.AttributionResponseObjectResource_relationships CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.AttributionResponseObjectResource_relationships();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attributed-event", n => { AttributedEvent = n.GetObjectValue<global::Klaviyo.Models.AttributionResponseObjectResource_relationships_attributedEvent>(global::Klaviyo.Models.AttributionResponseObjectResource_relationships_attributedEvent.CreateFromDiscriminatorValue); } },
                { "campaign", n => { Campaign = n.GetObjectValue<global::Klaviyo.Models.AttributionResponseObjectResource_relationships_campaign>(global::Klaviyo.Models.AttributionResponseObjectResource_relationships_campaign.CreateFromDiscriminatorValue); } },
                { "campaign-message", n => { CampaignMessage = n.GetObjectValue<global::Klaviyo.Models.AttributionResponseObjectResource_relationships_campaignMessage>(global::Klaviyo.Models.AttributionResponseObjectResource_relationships_campaignMessage.CreateFromDiscriminatorValue); } },
                { "event", n => { Event = n.GetObjectValue<global::Klaviyo.Models.AttributionResponseObjectResource_relationships_event>(global::Klaviyo.Models.AttributionResponseObjectResource_relationships_event.CreateFromDiscriminatorValue); } },
                { "flow", n => { Flow = n.GetObjectValue<global::Klaviyo.Models.AttributionResponseObjectResource_relationships_flow>(global::Klaviyo.Models.AttributionResponseObjectResource_relationships_flow.CreateFromDiscriminatorValue); } },
                { "flow-message", n => { FlowMessage = n.GetObjectValue<global::Klaviyo.Models.AttributionResponseObjectResource_relationships_flowMessage>(global::Klaviyo.Models.AttributionResponseObjectResource_relationships_flowMessage.CreateFromDiscriminatorValue); } },
                { "flow-message-variation", n => { FlowMessageVariation = n.GetObjectValue<global::Klaviyo.Models.AttributionResponseObjectResource_relationships_flowMessageVariation>(global::Klaviyo.Models.AttributionResponseObjectResource_relationships_flowMessageVariation.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Klaviyo.Models.AttributionResponseObjectResource_relationships_attributedEvent>("attributed-event", AttributedEvent);
            writer.WriteObjectValue<global::Klaviyo.Models.AttributionResponseObjectResource_relationships_campaign>("campaign", Campaign);
            writer.WriteObjectValue<global::Klaviyo.Models.AttributionResponseObjectResource_relationships_campaignMessage>("campaign-message", CampaignMessage);
            writer.WriteObjectValue<global::Klaviyo.Models.AttributionResponseObjectResource_relationships_event>("event", Event);
            writer.WriteObjectValue<global::Klaviyo.Models.AttributionResponseObjectResource_relationships_flow>("flow", Flow);
            writer.WriteObjectValue<global::Klaviyo.Models.AttributionResponseObjectResource_relationships_flowMessage>("flow-message", FlowMessage);
            writer.WriteObjectValue<global::Klaviyo.Models.AttributionResponseObjectResource_relationships_flowMessageVariation>("flow-message-variation", FlowMessageVariation);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
