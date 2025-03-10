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
    public partial class CatalogVariantCreateJobResponseObjectResource_attributes : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date and time the job was completed in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).</summary>
        public DateTimeOffset? CompletedAt { get; set; }
        /// <summary>The total number of operations that have been completed by the job.</summary>
        public int? CompletedCount { get; set; }
        /// <summary>The date and time the job was created in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>Array of errors encountered during the processing of the job.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Klaviyo.Models.APIJobErrorPayload>? Errors { get; set; }
#nullable restore
#else
        public List<global::Klaviyo.Models.APIJobErrorPayload> Errors { get; set; }
#endif
        /// <summary>Date and time the job expires in ISO 8601 format (YYYY-MM-DDTHH:MM:SS.mmmmmm).</summary>
        public DateTimeOffset? ExpiresAt { get; set; }
        /// <summary>The total number of operations that have failed as part of the job.</summary>
        public int? FailedCount { get; set; }
        /// <summary>Status of the asynchronous job.</summary>
        public global::Klaviyo.Models.CatalogVariantCreateJobResponseObjectResource_attributes_status? Status { get; set; }
        /// <summary>The total number of operations to be processed by the job. See `completed_count` for the job&apos;s current progress.</summary>
        public int? TotalCount { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.CatalogVariantCreateJobResponseObjectResource_attributes"/> and sets the default values.
        /// </summary>
        public CatalogVariantCreateJobResponseObjectResource_attributes()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.CatalogVariantCreateJobResponseObjectResource_attributes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.CatalogVariantCreateJobResponseObjectResource_attributes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.CatalogVariantCreateJobResponseObjectResource_attributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "completed_at", n => { CompletedAt = n.GetDateTimeOffsetValue(); } },
                { "completed_count", n => { CompletedCount = n.GetIntValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "errors", n => { Errors = n.GetCollectionOfObjectValues<global::Klaviyo.Models.APIJobErrorPayload>(global::Klaviyo.Models.APIJobErrorPayload.CreateFromDiscriminatorValue)?.AsList(); } },
                { "expires_at", n => { ExpiresAt = n.GetDateTimeOffsetValue(); } },
                { "failed_count", n => { FailedCount = n.GetIntValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Klaviyo.Models.CatalogVariantCreateJobResponseObjectResource_attributes_status>(); } },
                { "total_count", n => { TotalCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("completed_at", CompletedAt);
            writer.WriteIntValue("completed_count", CompletedCount);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteCollectionOfObjectValues<global::Klaviyo.Models.APIJobErrorPayload>("errors", Errors);
            writer.WriteDateTimeOffsetValue("expires_at", ExpiresAt);
            writer.WriteIntValue("failed_count", FailedCount);
            writer.WriteEnumValue<global::Klaviyo.Models.CatalogVariantCreateJobResponseObjectResource_attributes_status>("status", Status);
            writer.WriteIntValue("total_count", TotalCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
