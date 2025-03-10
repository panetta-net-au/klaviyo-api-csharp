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
    public partial class PatchListPartialUpdateResponse_data_attributes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date and time when the list was created, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm)</summary>
        public DateTimeOffset? Created { get; set; }
        /// <summary>A helpful name to label the list</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The opt-in process for this list.  Could be either &apos;single_opt_in&apos; or &apos;double_opt_in&apos;.</summary>
        public global::Klaviyo.Models.PatchListPartialUpdateResponse_data_attributes_opt_in_process? OptInProcess { get; set; }
        /// <summary>Date and time when the list was last updated, in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm)</summary>
        public DateTimeOffset? Updated { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.PatchListPartialUpdateResponse_data_attributes"/> and sets the default values.
        /// </summary>
        public PatchListPartialUpdateResponse_data_attributes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.PatchListPartialUpdateResponse_data_attributes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.PatchListPartialUpdateResponse_data_attributes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.PatchListPartialUpdateResponse_data_attributes();
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
                { "name", n => { Name = n.GetStringValue(); } },
                { "opt_in_process", n => { OptInProcess = n.GetEnumValue<global::Klaviyo.Models.PatchListPartialUpdateResponse_data_attributes_opt_in_process>(); } },
                { "updated", n => { Updated = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<global::Klaviyo.Models.PatchListPartialUpdateResponse_data_attributes_opt_in_process>("opt_in_process", OptInProcess);
            writer.WriteDateTimeOffsetValue("updated", Updated);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
