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
    public partial class FormVersionResponseObjectResource_attributes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The ab_test property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.FormVersionABTest? AbTest { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.FormVersionABTest AbTest { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>ISO8601 timestamp when the form version was created.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The type of form.</summary>
        public global::Klaviyo.Models.FormVersionResponseObjectResource_attributes_form_type? FormType { get; set; }
        /// <summary>Status of the form version. &quot;live&quot; means it&apos;s live on site.</summary>
        public global::Klaviyo.Models.FormVersionResponseObjectResource_attributes_status? Status { get; set; }
        /// <summary>ISO8601 timestamp when the form version was last updated.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.FormVersionResponseObjectResource_attributes"/> and sets the default values.
        /// </summary>
        public FormVersionResponseObjectResource_attributes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.FormVersionResponseObjectResource_attributes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.FormVersionResponseObjectResource_attributes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.FormVersionResponseObjectResource_attributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "ab_test", n => { AbTest = n.GetObjectValue<global::Klaviyo.Models.FormVersionABTest>(global::Klaviyo.Models.FormVersionABTest.CreateFromDiscriminatorValue); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "form_type", n => { FormType = n.GetEnumValue<global::Klaviyo.Models.FormVersionResponseObjectResource_attributes_form_type>(); } },
                { "status", n => { Status = n.GetEnumValue<global::Klaviyo.Models.FormVersionResponseObjectResource_attributes_status>(); } },
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
            writer.WriteObjectValue<global::Klaviyo.Models.FormVersionABTest>("ab_test", AbTest);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteEnumValue<global::Klaviyo.Models.FormVersionResponseObjectResource_attributes_form_type>("form_type", FormType);
            writer.WriteEnumValue<global::Klaviyo.Models.FormVersionResponseObjectResource_attributes_status>("status", Status);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
