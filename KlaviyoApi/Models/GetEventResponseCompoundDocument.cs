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
    public partial class GetEventResponseCompoundDocument : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.EventResponseObjectResource? Data { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.EventResponseObjectResource Data { get; set; }
#endif
        /// <summary>The included property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Klaviyo.Models.GetEventResponseCompoundDocument.GetEventResponseCompoundDocument_included>? Included { get; set; }
#nullable restore
#else
        public List<global::Klaviyo.Models.GetEventResponseCompoundDocument.GetEventResponseCompoundDocument_included> Included { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.GetEventResponseCompoundDocument"/> and sets the default values.
        /// </summary>
        public GetEventResponseCompoundDocument()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetEventResponseCompoundDocument"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.GetEventResponseCompoundDocument CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.GetEventResponseCompoundDocument();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "data", n => { Data = n.GetObjectValue<global::Klaviyo.Models.EventResponseObjectResource>(global::Klaviyo.Models.EventResponseObjectResource.CreateFromDiscriminatorValue); } },
                { "included", n => { Included = n.GetCollectionOfObjectValues<global::Klaviyo.Models.GetEventResponseCompoundDocument.GetEventResponseCompoundDocument_included>(global::Klaviyo.Models.GetEventResponseCompoundDocument.GetEventResponseCompoundDocument_included.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Klaviyo.Models.EventResponseObjectResource>("data", Data);
            writer.WriteCollectionOfObjectValues<global::Klaviyo.Models.GetEventResponseCompoundDocument.GetEventResponseCompoundDocument_included>("included", Included);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Klaviyo.Models.AttributionResponseObjectResource"/>, <see cref="global::Klaviyo.Models.MetricResponseObjectResource"/>, <see cref="global::Klaviyo.Models.ProfileResponseObjectResource"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class GetEventResponseCompoundDocument_included : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.AttributionResponseObjectResource"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.AttributionResponseObjectResource? AttributionResponseObjectResource { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.AttributionResponseObjectResource AttributionResponseObjectResource { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.MetricResponseObjectResource"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.MetricResponseObjectResource? MetricResponseObjectResource { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.MetricResponseObjectResource MetricResponseObjectResource { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.ProfileResponseObjectResource"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.ProfileResponseObjectResource? ProfileResponseObjectResource { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.ProfileResponseObjectResource ProfileResponseObjectResource { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Klaviyo.Models.GetEventResponseCompoundDocument.GetEventResponseCompoundDocument_included"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Klaviyo.Models.GetEventResponseCompoundDocument.GetEventResponseCompoundDocument_included CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Klaviyo.Models.GetEventResponseCompoundDocument.GetEventResponseCompoundDocument_included();
                if("AttributionResponseObjectResource".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.AttributionResponseObjectResource = new global::Klaviyo.Models.AttributionResponseObjectResource();
                }
                else if("MetricResponseObjectResource".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.MetricResponseObjectResource = new global::Klaviyo.Models.MetricResponseObjectResource();
                }
                else if("ProfileResponseObjectResource".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ProfileResponseObjectResource = new global::Klaviyo.Models.ProfileResponseObjectResource();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(AttributionResponseObjectResource != null)
                {
                    return AttributionResponseObjectResource.GetFieldDeserializers();
                }
                else if(MetricResponseObjectResource != null)
                {
                    return MetricResponseObjectResource.GetFieldDeserializers();
                }
                else if(ProfileResponseObjectResource != null)
                {
                    return ProfileResponseObjectResource.GetFieldDeserializers();
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
                if(AttributionResponseObjectResource != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.AttributionResponseObjectResource>(null, AttributionResponseObjectResource);
                }
                else if(MetricResponseObjectResource != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.MetricResponseObjectResource>(null, MetricResponseObjectResource);
                }
                else if(ProfileResponseObjectResource != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.ProfileResponseObjectResource>(null, ProfileResponseObjectResource);
                }
            }
        }
    }
}
#pragma warning restore CS0618
