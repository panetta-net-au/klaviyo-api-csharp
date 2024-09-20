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
    public partial class PostCampaignResponse_data_attributes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether the campaign has been archived or not</summary>
        public bool? Archived { get; set; }
        /// <summary>The audiences property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.AudiencesSubObject? Audiences { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.AudiencesSubObject Audiences { get; set; }
#endif
        /// <summary>The datetime when the campaign was created</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The campaign name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The datetime when the campaign was scheduled for future sending</summary>
        public DateTimeOffset? ScheduledAt { get; set; }
        /// <summary>Options to use when sending a campaign</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.PostCampaignResponse_data_attributes.PostCampaignResponse_data_attributes_send_options? SendOptions { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.PostCampaignResponse_data_attributes.PostCampaignResponse_data_attributes_send_options SendOptions { get; set; }
#endif
        /// <summary>The send_strategy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.SendStrategySubObject? SendStrategy { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.SendStrategySubObject SendStrategy { get; set; }
#endif
        /// <summary>The datetime when the campaign will be / was sent or None if not yet scheduled by a send_job.</summary>
        public DateTimeOffset? SendTime { get; set; }
        /// <summary>The current status of the campaign</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>The tracking options associated with the campaign</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.PostCampaignResponse_data_attributes.PostCampaignResponse_data_attributes_tracking_options? TrackingOptions { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.PostCampaignResponse_data_attributes.PostCampaignResponse_data_attributes_tracking_options TrackingOptions { get; set; }
#endif
        /// <summary>The datetime when the campaign was last updated by a user or the system</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.PostCampaignResponse_data_attributes"/> and sets the default values.
        /// </summary>
        public PostCampaignResponse_data_attributes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.PostCampaignResponse_data_attributes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.PostCampaignResponse_data_attributes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.PostCampaignResponse_data_attributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "archived", n => { Archived = n.GetBoolValue(); } },
                { "audiences", n => { Audiences = n.GetObjectValue<global::Klaviyo.Models.AudiencesSubObject>(global::Klaviyo.Models.AudiencesSubObject.CreateFromDiscriminatorValue); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "scheduled_at", n => { ScheduledAt = n.GetDateTimeOffsetValue(); } },
                { "send_options", n => { SendOptions = n.GetObjectValue<global::Klaviyo.Models.PostCampaignResponse_data_attributes.PostCampaignResponse_data_attributes_send_options>(global::Klaviyo.Models.PostCampaignResponse_data_attributes.PostCampaignResponse_data_attributes_send_options.CreateFromDiscriminatorValue); } },
                { "send_strategy", n => { SendStrategy = n.GetObjectValue<global::Klaviyo.Models.SendStrategySubObject>(global::Klaviyo.Models.SendStrategySubObject.CreateFromDiscriminatorValue); } },
                { "send_time", n => { SendTime = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetStringValue(); } },
                { "tracking_options", n => { TrackingOptions = n.GetObjectValue<global::Klaviyo.Models.PostCampaignResponse_data_attributes.PostCampaignResponse_data_attributes_tracking_options>(global::Klaviyo.Models.PostCampaignResponse_data_attributes.PostCampaignResponse_data_attributes_tracking_options.CreateFromDiscriminatorValue); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("archived", Archived);
            writer.WriteObjectValue<global::Klaviyo.Models.AudiencesSubObject>("audiences", Audiences);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("name", Name);
            writer.WriteDateTimeOffsetValue("scheduled_at", ScheduledAt);
            writer.WriteObjectValue<global::Klaviyo.Models.PostCampaignResponse_data_attributes.PostCampaignResponse_data_attributes_send_options>("send_options", SendOptions);
            writer.WriteObjectValue<global::Klaviyo.Models.SendStrategySubObject>("send_strategy", SendStrategy);
            writer.WriteDateTimeOffsetValue("send_time", SendTime);
            writer.WriteStringValue("status", Status);
            writer.WriteObjectValue<global::Klaviyo.Models.PostCampaignResponse_data_attributes.PostCampaignResponse_data_attributes_tracking_options>("tracking_options", TrackingOptions);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Klaviyo.Models.EmailSendOptionsSubObject"/>, <see cref="global::Klaviyo.Models.SMSSendOptionsSubObject"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class PostCampaignResponse_data_attributes_send_options : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.EmailSendOptionsSubObject"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.EmailSendOptionsSubObject? EmailSendOptionsSubObject { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.EmailSendOptionsSubObject EmailSendOptionsSubObject { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.SMSSendOptionsSubObject"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.SMSSendOptionsSubObject? SMSSendOptionsSubObject { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.SMSSendOptionsSubObject SMSSendOptionsSubObject { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Klaviyo.Models.PostCampaignResponse_data_attributes.PostCampaignResponse_data_attributes_send_options"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Klaviyo.Models.PostCampaignResponse_data_attributes.PostCampaignResponse_data_attributes_send_options CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Klaviyo.Models.PostCampaignResponse_data_attributes.PostCampaignResponse_data_attributes_send_options();
                if("EmailSendOptionsSubObject".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.EmailSendOptionsSubObject = new global::Klaviyo.Models.EmailSendOptionsSubObject();
                }
                else if("SMSSendOptionsSubObject".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SMSSendOptionsSubObject = new global::Klaviyo.Models.SMSSendOptionsSubObject();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(EmailSendOptionsSubObject != null)
                {
                    return EmailSendOptionsSubObject.GetFieldDeserializers();
                }
                else if(SMSSendOptionsSubObject != null)
                {
                    return SMSSendOptionsSubObject.GetFieldDeserializers();
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
                if(EmailSendOptionsSubObject != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.EmailSendOptionsSubObject>(null, EmailSendOptionsSubObject);
                }
                else if(SMSSendOptionsSubObject != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.SMSSendOptionsSubObject>(null, SMSSendOptionsSubObject);
                }
            }
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Klaviyo.Models.EmailTrackingOptionsSubObject"/>, <see cref="global::Klaviyo.Models.SMSTrackingOptionsSubObject"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class PostCampaignResponse_data_attributes_tracking_options : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.EmailTrackingOptionsSubObject"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.EmailTrackingOptionsSubObject? EmailTrackingOptionsSubObject { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.EmailTrackingOptionsSubObject EmailTrackingOptionsSubObject { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.SMSTrackingOptionsSubObject"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.SMSTrackingOptionsSubObject? SMSTrackingOptionsSubObject { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.SMSTrackingOptionsSubObject SMSTrackingOptionsSubObject { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Klaviyo.Models.PostCampaignResponse_data_attributes.PostCampaignResponse_data_attributes_tracking_options"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Klaviyo.Models.PostCampaignResponse_data_attributes.PostCampaignResponse_data_attributes_tracking_options CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Klaviyo.Models.PostCampaignResponse_data_attributes.PostCampaignResponse_data_attributes_tracking_options();
                if("EmailTrackingOptionsSubObject".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.EmailTrackingOptionsSubObject = new global::Klaviyo.Models.EmailTrackingOptionsSubObject();
                }
                else if("SMSTrackingOptionsSubObject".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.SMSTrackingOptionsSubObject = new global::Klaviyo.Models.SMSTrackingOptionsSubObject();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(EmailTrackingOptionsSubObject != null)
                {
                    return EmailTrackingOptionsSubObject.GetFieldDeserializers();
                }
                else if(SMSTrackingOptionsSubObject != null)
                {
                    return SMSTrackingOptionsSubObject.GetFieldDeserializers();
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
                if(EmailTrackingOptionsSubObject != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.EmailTrackingOptionsSubObject>(null, EmailTrackingOptionsSubObject);
                }
                else if(SMSTrackingOptionsSubObject != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.SMSTrackingOptionsSubObject>(null, SMSTrackingOptionsSubObject);
                }
            }
        }
    }
}
#pragma warning restore CS0618
