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
    public partial class ReviewPatchQueryResourceObject_attributes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The updated status intended for the review with this ID</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.ReviewPatchQueryResourceObject_attributes.ReviewPatchQueryResourceObject_attributes_status? Status { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.ReviewPatchQueryResourceObject_attributes.ReviewPatchQueryResourceObject_attributes_status Status { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.ReviewPatchQueryResourceObject_attributes"/> and sets the default values.
        /// </summary>
        public ReviewPatchQueryResourceObject_attributes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.ReviewPatchQueryResourceObject_attributes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.ReviewPatchQueryResourceObject_attributes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.ReviewPatchQueryResourceObject_attributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "status", n => { Status = n.GetObjectValue<global::Klaviyo.Models.ReviewPatchQueryResourceObject_attributes.ReviewPatchQueryResourceObject_attributes_status>(global::Klaviyo.Models.ReviewPatchQueryResourceObject_attributes.ReviewPatchQueryResourceObject_attributes_status.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Klaviyo.Models.ReviewPatchQueryResourceObject_attributes.ReviewPatchQueryResourceObject_attributes_status>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="global::Klaviyo.Models.ReviewStatusFeatured"/>, <see cref="global::Klaviyo.Models.ReviewStatusPending"/>, <see cref="global::Klaviyo.Models.ReviewStatusPublished"/>, <see cref="global::Klaviyo.Models.ReviewStatusRejected"/>, <see cref="global::Klaviyo.Models.ReviewStatusUnpublished"/>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ReviewPatchQueryResourceObject_attributes_status : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.ReviewStatusFeatured"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.ReviewStatusFeatured? ReviewStatusFeatured { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.ReviewStatusFeatured ReviewStatusFeatured { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.ReviewStatusPending"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.ReviewStatusPending? ReviewStatusPending { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.ReviewStatusPending ReviewStatusPending { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.ReviewStatusPublished"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.ReviewStatusPublished? ReviewStatusPublished { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.ReviewStatusPublished ReviewStatusPublished { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.ReviewStatusRejected"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.ReviewStatusRejected? ReviewStatusRejected { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.ReviewStatusRejected ReviewStatusRejected { get; set; }
#endif
            /// <summary>Composed type representation for type <see cref="global::Klaviyo.Models.ReviewStatusUnpublished"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public global::Klaviyo.Models.ReviewStatusUnpublished? ReviewStatusUnpublished { get; set; }
#nullable restore
#else
            public global::Klaviyo.Models.ReviewStatusUnpublished ReviewStatusUnpublished { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Klaviyo.Models.ReviewPatchQueryResourceObject_attributes.ReviewPatchQueryResourceObject_attributes_status"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Klaviyo.Models.ReviewPatchQueryResourceObject_attributes.ReviewPatchQueryResourceObject_attributes_status CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Klaviyo.Models.ReviewPatchQueryResourceObject_attributes.ReviewPatchQueryResourceObject_attributes_status();
                if("ReviewStatusFeatured".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ReviewStatusFeatured = new global::Klaviyo.Models.ReviewStatusFeatured();
                }
                else if("ReviewStatusPending".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ReviewStatusPending = new global::Klaviyo.Models.ReviewStatusPending();
                }
                else if("ReviewStatusPublished".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ReviewStatusPublished = new global::Klaviyo.Models.ReviewStatusPublished();
                }
                else if("ReviewStatusRejected".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ReviewStatusRejected = new global::Klaviyo.Models.ReviewStatusRejected();
                }
                else if("ReviewStatusUnpublished".Equals(mappingValue, StringComparison.OrdinalIgnoreCase))
                {
                    result.ReviewStatusUnpublished = new global::Klaviyo.Models.ReviewStatusUnpublished();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                if(ReviewStatusFeatured != null)
                {
                    return ReviewStatusFeatured.GetFieldDeserializers();
                }
                else if(ReviewStatusPending != null)
                {
                    return ReviewStatusPending.GetFieldDeserializers();
                }
                else if(ReviewStatusPublished != null)
                {
                    return ReviewStatusPublished.GetFieldDeserializers();
                }
                else if(ReviewStatusRejected != null)
                {
                    return ReviewStatusRejected.GetFieldDeserializers();
                }
                else if(ReviewStatusUnpublished != null)
                {
                    return ReviewStatusUnpublished.GetFieldDeserializers();
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
                if(ReviewStatusFeatured != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.ReviewStatusFeatured>(null, ReviewStatusFeatured);
                }
                else if(ReviewStatusPending != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.ReviewStatusPending>(null, ReviewStatusPending);
                }
                else if(ReviewStatusPublished != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.ReviewStatusPublished>(null, ReviewStatusPublished);
                }
                else if(ReviewStatusRejected != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.ReviewStatusRejected>(null, ReviewStatusRejected);
                }
                else if(ReviewStatusUnpublished != null)
                {
                    writer.WriteObjectValue<global::Klaviyo.Models.ReviewStatusUnpublished>(null, ReviewStatusUnpublished);
                }
            }
        }
    }
}
#pragma warning restore CS0618
