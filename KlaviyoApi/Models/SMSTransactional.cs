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
    public partial class SMSTransactional : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether or not this profile is subscribed to receive transactional SMS.</summary>
        public bool? CanReceiveSmsTransactional { get; set; }
        /// <summary>The consent status for SMS Transactional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Consent { get; set; }
#nullable restore
#else
        public string Consent { get; set; }
#endif
        /// <summary>The timestamp when consent was recorded or updated for Transactional SMS messaging , in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).</summary>
        public DateTimeOffset? ConsentTimestamp { get; set; }
        /// <summary>The timestamp when the SMS consent record was last modified, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).</summary>
        public DateTimeOffset? LastUpdated { get; set; }
        /// <summary>The method by which the profile was subscribed to Transactional SMS messaging .</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Method { get; set; }
#nullable restore
#else
        public string Method { get; set; }
#endif
        /// <summary>Additional details about the method which the profile was subscribed to Transactional SMS messaging. This may be empty if no details were provided.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MethodDetail { get; set; }
#nullable restore
#else
        public string MethodDetail { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.SMSTransactional"/> and sets the default values.
        /// </summary>
        public SMSTransactional()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.SMSTransactional"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.SMSTransactional CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.SMSTransactional();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "can_receive_sms_transactional", n => { CanReceiveSmsTransactional = n.GetBoolValue(); } },
                { "consent", n => { Consent = n.GetStringValue(); } },
                { "consent_timestamp", n => { ConsentTimestamp = n.GetDateTimeOffsetValue(); } },
                { "last_updated", n => { LastUpdated = n.GetDateTimeOffsetValue(); } },
                { "method", n => { Method = n.GetStringValue(); } },
                { "method_detail", n => { MethodDetail = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("can_receive_sms_transactional", CanReceiveSmsTransactional);
            writer.WriteStringValue("consent", Consent);
            writer.WriteDateTimeOffsetValue("consent_timestamp", ConsentTimestamp);
            writer.WriteDateTimeOffsetValue("last_updated", LastUpdated);
            writer.WriteStringValue("method", Method);
            writer.WriteStringValue("method_detail", MethodDetail);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
