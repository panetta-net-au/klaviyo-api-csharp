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
    public partial class GetCampaignResponseCompoundDocument_data_relationships : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The campaignMessages property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.GetCampaignResponseCompoundDocument_data_relationships_campaignMessages? CampaignMessages { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.GetCampaignResponseCompoundDocument_data_relationships_campaignMessages CampaignMessages { get; set; }
#endif
        /// <summary>The tags property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.GetCampaignResponseCompoundDocument_data_relationships_tags? Tags { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.GetCampaignResponseCompoundDocument_data_relationships_tags Tags { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.GetCampaignResponseCompoundDocument_data_relationships"/> and sets the default values.
        /// </summary>
        public GetCampaignResponseCompoundDocument_data_relationships()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetCampaignResponseCompoundDocument_data_relationships"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.GetCampaignResponseCompoundDocument_data_relationships CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.GetCampaignResponseCompoundDocument_data_relationships();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "campaign-messages", n => { CampaignMessages = n.GetObjectValue<global::Klaviyo.Models.GetCampaignResponseCompoundDocument_data_relationships_campaignMessages>(global::Klaviyo.Models.GetCampaignResponseCompoundDocument_data_relationships_campaignMessages.CreateFromDiscriminatorValue); } },
                { "tags", n => { Tags = n.GetObjectValue<global::Klaviyo.Models.GetCampaignResponseCompoundDocument_data_relationships_tags>(global::Klaviyo.Models.GetCampaignResponseCompoundDocument_data_relationships_tags.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Klaviyo.Models.GetCampaignResponseCompoundDocument_data_relationships_campaignMessages>("campaign-messages", CampaignMessages);
            writer.WriteObjectValue<global::Klaviyo.Models.GetCampaignResponseCompoundDocument_data_relationships_tags>("tags", Tags);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
