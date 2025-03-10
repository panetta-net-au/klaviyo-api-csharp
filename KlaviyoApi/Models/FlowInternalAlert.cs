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
    public partial class FlowInternalAlert : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The from_email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FromEmail { get; set; }
#nullable restore
#else
        public string FromEmail { get; set; }
#endif
        /// <summary>The from_label property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FromLabel { get; set; }
#nullable restore
#else
        public string FromLabel { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The subject_line property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectLine { get; set; }
#nullable restore
#else
        public string SubjectLine { get; set; }
#endif
        /// <summary>The template_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TemplateId { get; set; }
#nullable restore
#else
        public string TemplateId { get; set; }
#endif
        /// <summary>The to_emails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ToEmails { get; set; }
#nullable restore
#else
        public List<string> ToEmails { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.FlowInternalAlert"/> and sets the default values.
        /// </summary>
        public FlowInternalAlert()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.FlowInternalAlert"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.FlowInternalAlert CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.FlowInternalAlert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "from_email", n => { FromEmail = n.GetStringValue(); } },
                { "from_label", n => { FromLabel = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "subject_line", n => { SubjectLine = n.GetStringValue(); } },
                { "template_id", n => { TemplateId = n.GetStringValue(); } },
                { "to_emails", n => { ToEmails = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("from_email", FromEmail);
            writer.WriteStringValue("from_label", FromLabel);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("subject_line", SubjectLine);
            writer.WriteStringValue("template_id", TemplateId);
            writer.WriteCollectionOfPrimitiveValues<string>("to_emails", ToEmails);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
