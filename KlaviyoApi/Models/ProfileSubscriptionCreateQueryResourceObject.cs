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
    public partial class ProfileSubscriptionCreateQueryResourceObject : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The attributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.ProfileSubscriptionCreateQueryResourceObject_attributes? Attributes { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.ProfileSubscriptionCreateQueryResourceObject_attributes Attributes { get; set; }
#endif
        /// <summary>The ID of the profile to subscribe. If provided, this will be used to perform the lookup.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The type property</summary>
        public global::Klaviyo.Models.ProfileEnum? Type { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.ProfileSubscriptionCreateQueryResourceObject"/> and sets the default values.
        /// </summary>
        public ProfileSubscriptionCreateQueryResourceObject()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.ProfileSubscriptionCreateQueryResourceObject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.ProfileSubscriptionCreateQueryResourceObject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.ProfileSubscriptionCreateQueryResourceObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attributes", n => { Attributes = n.GetObjectValue<global::Klaviyo.Models.ProfileSubscriptionCreateQueryResourceObject_attributes>(global::Klaviyo.Models.ProfileSubscriptionCreateQueryResourceObject_attributes.CreateFromDiscriminatorValue); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<global::Klaviyo.Models.ProfileEnum>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Klaviyo.Models.ProfileSubscriptionCreateQueryResourceObject_attributes>("attributes", Attributes);
            writer.WriteStringValue("id", Id);
            writer.WriteEnumValue<global::Klaviyo.Models.ProfileEnum>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
