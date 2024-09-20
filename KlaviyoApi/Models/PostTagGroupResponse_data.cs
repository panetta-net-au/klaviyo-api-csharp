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
    public partial class PostTagGroupResponse_data : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The attributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.PostTagGroupResponse_data_attributes? Attributes { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.PostTagGroupResponse_data_attributes Attributes { get; set; }
#endif
        /// <summary>The Tag Group ID</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.ObjectLinks? Links { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.ObjectLinks Links { get; set; }
#endif
        /// <summary>The relationships property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.PostTagGroupResponse_data_relationships? Relationships { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.PostTagGroupResponse_data_relationships Relationships { get; set; }
#endif
        /// <summary>The type property</summary>
        public global::Klaviyo.Models.TagGroupEnum? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.PostTagGroupResponse_data"/> and sets the default values.
        /// </summary>
        public PostTagGroupResponse_data()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.PostTagGroupResponse_data"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.PostTagGroupResponse_data CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.PostTagGroupResponse_data();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attributes", n => { Attributes = n.GetObjectValue<global::Klaviyo.Models.PostTagGroupResponse_data_attributes>(global::Klaviyo.Models.PostTagGroupResponse_data_attributes.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "links", n => { Links = n.GetObjectValue<global::Klaviyo.Models.ObjectLinks>(global::Klaviyo.Models.ObjectLinks.CreateFromDiscriminatorValue); } },
                { "relationships", n => { Relationships = n.GetObjectValue<global::Klaviyo.Models.PostTagGroupResponse_data_relationships>(global::Klaviyo.Models.PostTagGroupResponse_data_relationships.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetEnumValue<global::Klaviyo.Models.TagGroupEnum>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Klaviyo.Models.PostTagGroupResponse_data_attributes>("attributes", Attributes);
            writer.WriteStringValue("id", Id);
            writer.WriteObjectValue<global::Klaviyo.Models.ObjectLinks>("links", Links);
            writer.WriteObjectValue<global::Klaviyo.Models.PostTagGroupResponse_data_relationships>("relationships", Relationships);
            writer.WriteEnumValue<global::Klaviyo.Models.TagGroupEnum>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
