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
    public partial class PatchCatalogItemResponse_data_attributes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date and time when the catalog item was created, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).</summary>
        public DateTimeOffset? Created { get; set; }
        /// <summary>Flat JSON blob to provide custom metadata about the catalog item. May not exceed 100kb.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.PatchCatalogItemResponse_data_attributes_custom_metadata? CustomMetadata { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.PatchCatalogItemResponse_data_attributes_custom_metadata CustomMetadata { get; set; }
#endif
        /// <summary>A description of the catalog item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The ID of the catalog item in an external system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>URL pointing to the location of a full image of the catalog item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageFullUrl { get; set; }
#nullable restore
#else
        public string ImageFullUrl { get; set; }
#endif
        /// <summary>List of URLs pointing to the locations of images of the catalog item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Images { get; set; }
#nullable restore
#else
        public List<string> Images { get; set; }
#endif
        /// <summary>URL pointing to the location of an image thumbnail of the catalog item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageThumbnailUrl { get; set; }
#nullable restore
#else
        public string ImageThumbnailUrl { get; set; }
#endif
        /// <summary>This field can be used to set the price on the catalog item, which is what gets displayed for the item when included in emails. For most price-update use cases, you will also want to update the `price` on any child variants, using the [Update Catalog Variant Endpoint](https://developers.klaviyo.com/en/reference/update_catalog_variant).</summary>
        public double? Price { get; set; }
        /// <summary>Boolean value indicating whether the catalog item is published.</summary>
        public bool? Published { get; set; }
        /// <summary>The title of the catalog item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>Date and time when the catalog item was last updated, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).</summary>
        public DateTimeOffset? Updated { get; set; }
        /// <summary>URL pointing to the location of the catalog item on your website.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.PatchCatalogItemResponse_data_attributes"/> and sets the default values.
        /// </summary>
        public PatchCatalogItemResponse_data_attributes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.PatchCatalogItemResponse_data_attributes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.PatchCatalogItemResponse_data_attributes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.PatchCatalogItemResponse_data_attributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created", n => { Created = n.GetDateTimeOffsetValue(); } },
                { "custom_metadata", n => { CustomMetadata = n.GetObjectValue<global::Klaviyo.Models.PatchCatalogItemResponse_data_attributes_custom_metadata>(global::Klaviyo.Models.PatchCatalogItemResponse_data_attributes_custom_metadata.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "external_id", n => { ExternalId = n.GetStringValue(); } },
                { "image_full_url", n => { ImageFullUrl = n.GetStringValue(); } },
                { "image_thumbnail_url", n => { ImageThumbnailUrl = n.GetStringValue(); } },
                { "images", n => { Images = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "price", n => { Price = n.GetDoubleValue(); } },
                { "published", n => { Published = n.GetBoolValue(); } },
                { "title", n => { Title = n.GetStringValue(); } },
                { "updated", n => { Updated = n.GetDateTimeOffsetValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("created", Created);
            writer.WriteObjectValue<global::Klaviyo.Models.PatchCatalogItemResponse_data_attributes_custom_metadata>("custom_metadata", CustomMetadata);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("external_id", ExternalId);
            writer.WriteStringValue("image_full_url", ImageFullUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("images", Images);
            writer.WriteStringValue("image_thumbnail_url", ImageThumbnailUrl);
            writer.WriteDoubleValue("price", Price);
            writer.WriteBoolValue("published", Published);
            writer.WriteStringValue("title", Title);
            writer.WriteDateTimeOffsetValue("updated", Updated);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
