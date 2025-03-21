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
    public partial class ReviewResponseDTO20240715ObjectResource_attributes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The author of this review</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Author { get; set; }
#nullable restore
#else
        public string Author { get; set; }
#endif
        /// <summary>The content of this review</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Content { get; set; }
#nullable restore
#else
        public string Content { get; set; }
#endif
        /// <summary>The datetime when this review was created</summary>
        public DateTimeOffset? Created { get; set; }
        /// <summary>The email of the author of this review</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The list of images submitted with this review (represented as a list of urls). If there are no images, this field will be an empty list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Images { get; set; }
#nullable restore
#else
        public List<string> Images { get; set; }
#endif
        /// <summary>The product property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.ReviewProductDTO? Product { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.ReviewProductDTO Product { get; set; }
#endif
        /// <summary>The public_reply property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.ReviewPublicReply? PublicReply { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.ReviewPublicReply PublicReply { get; set; }
#endif
        /// <summary>The rating of this review on a scale from 1-5. If the review type is &quot;question&quot;, this field will be null.</summary>
        public int? Rating { get; set; }
        /// <summary>The type of this review — either a review, question, or rating</summary>
        public global::Klaviyo.Models.ReviewResponseDTO20240715ObjectResource_attributes_review_type? ReviewType { get; set; }
        /// <summary>A quote from this review that summarizes the content</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SmartQuote { get; set; }
#nullable restore
#else
        public string SmartQuote { get; set; }
#endif
        /// <summary>The status of this review</summary>
        public global::Klaviyo.Models.ReviewResponseDTO20240715ObjectResource_attributes_status? Status { get; set; }
        /// <summary>The title of this review</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The datetime when this review was updated</summary>
        public DateTimeOffset? Updated { get; set; }
        /// <summary>The verification status of this review (aka whether or not we have confirmation that the customer bought the product)</summary>
        public bool? Verified { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.ReviewResponseDTO20240715ObjectResource_attributes"/> and sets the default values.
        /// </summary>
        public ReviewResponseDTO20240715ObjectResource_attributes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.ReviewResponseDTO20240715ObjectResource_attributes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.ReviewResponseDTO20240715ObjectResource_attributes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.ReviewResponseDTO20240715ObjectResource_attributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "author", n => { Author = n.GetStringValue(); } },
                { "content", n => { Content = n.GetStringValue(); } },
                { "created", n => { Created = n.GetDateTimeOffsetValue(); } },
                { "email", n => { Email = n.GetStringValue(); } },
                { "images", n => { Images = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "product", n => { Product = n.GetObjectValue<global::Klaviyo.Models.ReviewProductDTO>(global::Klaviyo.Models.ReviewProductDTO.CreateFromDiscriminatorValue); } },
                { "public_reply", n => { PublicReply = n.GetObjectValue<global::Klaviyo.Models.ReviewPublicReply>(global::Klaviyo.Models.ReviewPublicReply.CreateFromDiscriminatorValue); } },
                { "rating", n => { Rating = n.GetIntValue(); } },
                { "review_type", n => { ReviewType = n.GetEnumValue<global::Klaviyo.Models.ReviewResponseDTO20240715ObjectResource_attributes_review_type>(); } },
                { "smart_quote", n => { SmartQuote = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Klaviyo.Models.ReviewResponseDTO20240715ObjectResource_attributes_status>(); } },
                { "title", n => { Title = n.GetStringValue(); } },
                { "updated", n => { Updated = n.GetDateTimeOffsetValue(); } },
                { "verified", n => { Verified = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("author", Author);
            writer.WriteStringValue("content", Content);
            writer.WriteDateTimeOffsetValue("created", Created);
            writer.WriteStringValue("email", Email);
            writer.WriteCollectionOfPrimitiveValues<string>("images", Images);
            writer.WriteObjectValue<global::Klaviyo.Models.ReviewProductDTO>("product", Product);
            writer.WriteObjectValue<global::Klaviyo.Models.ReviewPublicReply>("public_reply", PublicReply);
            writer.WriteIntValue("rating", Rating);
            writer.WriteEnumValue<global::Klaviyo.Models.ReviewResponseDTO20240715ObjectResource_attributes_review_type>("review_type", ReviewType);
            writer.WriteStringValue("smart_quote", SmartQuote);
            writer.WriteEnumValue<global::Klaviyo.Models.ReviewResponseDTO20240715ObjectResource_attributes_status>("status", Status);
            writer.WriteStringValue("title", Title);
            writer.WriteDateTimeOffsetValue("updated", Updated);
            writer.WriteBoolValue("verified", Verified);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
