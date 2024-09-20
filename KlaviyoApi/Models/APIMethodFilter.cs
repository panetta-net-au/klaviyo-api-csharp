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
    public partial class APIMethodFilter : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The field property</summary>
        public global::Klaviyo.Models.MethodEnum? Field { get; set; }
        /// <summary>The filter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.InStringArrayFilter? Filter { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.InStringArrayFilter Filter { get; set; }
#endif
        /// <summary>The method property</summary>
        public global::Klaviyo.Models.ApiEnum? Method { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.APIMethodFilter"/> and sets the default values.
        /// </summary>
        public APIMethodFilter()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.APIMethodFilter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.APIMethodFilter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.APIMethodFilter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "field", n => { Field = n.GetEnumValue<global::Klaviyo.Models.MethodEnum>(); } },
                { "filter", n => { Filter = n.GetObjectValue<global::Klaviyo.Models.InStringArrayFilter>(global::Klaviyo.Models.InStringArrayFilter.CreateFromDiscriminatorValue); } },
                { "method", n => { Method = n.GetEnumValue<global::Klaviyo.Models.ApiEnum>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Klaviyo.Models.MethodEnum>("field", Field);
            writer.WriteObjectValue<global::Klaviyo.Models.InStringArrayFilter>("filter", Filter);
            writer.WriteEnumValue<global::Klaviyo.Models.ApiEnum>("method", Method);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
