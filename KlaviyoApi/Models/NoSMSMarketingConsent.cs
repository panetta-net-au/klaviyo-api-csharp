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
    public partial class NoSMSMarketingConsent : IAdditionalDataHolder, IParsable
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
        public global::Klaviyo.Models.SmsEnum? Channel { get; set; }
        /// <summary>The consent_status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.NoSMSMarketingConsent.NoSMSMarketingConsent_consent_status? ConsentStatus { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.NoSMSMarketingConsent.NoSMSMarketingConsent_consent_status ConsentStatus { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.NoSMSMarketingConsent"/> and sets the default values.
        /// </summary>
        public NoSMSMarketingConsent()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.NoSMSMarketingConsent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.NoSMSMarketingConsent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.NoSMSMarketingConsent();
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
                { "channel", n => { Channel = n.GetEnumValue<global::Klaviyo.Models.SmsEnum>(); } },
                { "consent_status", n => { ConsentStatus = n.GetObjectValue<global::Klaviyo.Models.NoSMSMarketingConsent.NoSMSMarketingConsent_consent_status>(global::Klaviyo.Models.NoSMSMarketingConsent.NoSMSMarketingConsent_consent_status.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<global::Klaviyo.Models.SmsEnum>("channel", Channel);
            writer.WriteObjectValue<global::Klaviyo.Models.NoSMSMarketingConsent.NoSMSMarketingConsent_consent_status>("consent_status", ConsentStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Klaviyo.Models.NoSMSMarketing"/>, <see cref="global::Klaviyo.Models.NoSMSMarketingNeverSubscribed"/>, <see cref="global::Klaviyo.Models.NoSMSMarketingUnsubscribed"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class NoSMSMarketingConsent_consent_status : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.NoSMSMarketing"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.NoSMSMarketing? NoSMSMarketing { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.NoSMSMarketing NoSMSMarketing { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.NoSMSMarketingNeverSubscribed"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.NoSMSMarketingNeverSubscribed? NoSMSMarketingNeverSubscribed { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.NoSMSMarketingNeverSubscribed NoSMSMarketingNeverSubscribed { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.NoSMSMarketingUnsubscribed"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.NoSMSMarketingUnsubscribed? NoSMSMarketingUnsubscribed { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.NoSMSMarketingUnsubscribed NoSMSMarketingUnsubscribed { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Klaviyo.Models.NoSMSMarketingConsent.NoSMSMarketingConsent_consent_status"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Klaviyo.Models.NoSMSMarketingConsent.NoSMSMarketingConsent_consent_status CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Klaviyo.Models.NoSMSMarketingConsent.NoSMSMarketingConsent_consent_status();
                if("NoSMSMarketing".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.NoSMSMarketing = new global::Klaviyo.Models.NoSMSMarketing();
                }
                else if("NoSMSMarketingNeverSubscribed".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.NoSMSMarketingNeverSubscribed = new global::Klaviyo.Models.NoSMSMarketingNeverSubscribed();
                }
                else if("NoSMSMarketingUnsubscribed".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.NoSMSMarketingUnsubscribed = new global::Klaviyo.Models.NoSMSMarketingUnsubscribed();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(NoSMSMarketing != null)
                {
                    return NoSMSMarketing.GetFieldDeserializers();
                }
                else if(NoSMSMarketingNeverSubscribed != null)
                {
                    return NoSMSMarketingNeverSubscribed.GetFieldDeserializers();
                }
                else if(NoSMSMarketingUnsubscribed != null)
                {
                    return NoSMSMarketingUnsubscribed.GetFieldDeserializers();
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
                if(NoSMSMarketing != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.NoSMSMarketing>(null, NoSMSMarketing);
                }
                else if(NoSMSMarketingNeverSubscribed != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.NoSMSMarketingNeverSubscribed>(null, NoSMSMarketingNeverSubscribed);
                }
                else if(NoSMSMarketingUnsubscribed != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.NoSMSMarketingUnsubscribed>(null, NoSMSMarketingUnsubscribed);
                }
            }
        }
    }
}
#pragma warning restore CS0618
