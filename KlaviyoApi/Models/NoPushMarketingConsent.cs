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
    public partial class NoPushMarketingConsent : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The can_receive_marketing property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? CanReceiveMarketing { get; set; }
#nullable restore
#else
        public UntypedNode CanReceiveMarketing { get; set; }
#endif
        /// <summary>The channel property</summary>
        public global::Klaviyo.Models.PushEnum? Channel { get; set; }
        /// <summary>The consent_status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.NoPushMarketing? ConsentStatus { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.NoPushMarketing ConsentStatus { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.NoPushMarketingConsent"/> and sets the default values.
        /// </summary>
        public NoPushMarketingConsent()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.NoPushMarketingConsent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.NoPushMarketingConsent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.NoPushMarketingConsent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "can_receive_marketing", n => { CanReceiveMarketing = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "channel", n => { Channel = n.GetEnumValue<global::Klaviyo.Models.PushEnum>(); } },
                { "consent_status", n => { ConsentStatus = n.GetObjectValue<global::Klaviyo.Models.NoPushMarketing>(global::Klaviyo.Models.NoPushMarketing.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("can_receive_marketing", CanReceiveMarketing);
            writer.WriteEnumValue<global::Klaviyo.Models.PushEnum>("channel", Channel);
            writer.WriteObjectValue<global::Klaviyo.Models.NoPushMarketing>("consent_status", ConsentStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
