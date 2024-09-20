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
    public partial class PostCatalogVariantResponse_data_relationships_item : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.PostCatalogVariantResponse_data_relationships_item_data? Data { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.PostCatalogVariantResponse_data_relationships_item_data Data { get; set; }
#endif
        /// <summary>The links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.RelationshipLinks? Links { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.RelationshipLinks Links { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.PostCatalogVariantResponse_data_relationships_item"/> and sets the default values.
        /// </summary>
        public PostCatalogVariantResponse_data_relationships_item()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.PostCatalogVariantResponse_data_relationships_item"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.PostCatalogVariantResponse_data_relationships_item CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.PostCatalogVariantResponse_data_relationships_item();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "data", n => { Data = n.GetObjectValue<global::Klaviyo.Models.PostCatalogVariantResponse_data_relationships_item_data>(global::Klaviyo.Models.PostCatalogVariantResponse_data_relationships_item_data.CreateFromDiscriminatorValue); } },
                { "links", n => { Links = n.GetObjectValue<global::Klaviyo.Models.RelationshipLinks>(global::Klaviyo.Models.RelationshipLinks.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Klaviyo.Models.PostCatalogVariantResponse_data_relationships_item_data>("data", Data);
            writer.WriteObjectValue<global::Klaviyo.Models.RelationshipLinks>("links", Links);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
