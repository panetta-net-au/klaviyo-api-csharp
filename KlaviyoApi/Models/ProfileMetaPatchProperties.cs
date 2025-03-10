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
    public partial class ProfileMetaPatchProperties : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Append a simple value or values to this property array</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.ProfileMetaPatchProperties_append? Append { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.ProfileMetaPatchProperties_append Append { get; set; }
#endif
        /// <summary>Remove a simple value or values from this property array</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.ProfileMetaPatchProperties_unappend? Unappend { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.ProfileMetaPatchProperties_unappend Unappend { get; set; }
#endif
        /// <summary>Remove a key or keys (and their values) completely from properties</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Klaviyo.Models.ProfileMetaPatchProperties.ProfileMetaPatchProperties_unset? Unset { get; set; }
#nullable restore
#else
        public global::Klaviyo.Models.ProfileMetaPatchProperties.ProfileMetaPatchProperties_unset Unset { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.ProfileMetaPatchProperties"/> and sets the default values.
        /// </summary>
        public ProfileMetaPatchProperties()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.ProfileMetaPatchProperties"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.ProfileMetaPatchProperties CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.ProfileMetaPatchProperties();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "append", n => { Append = n.GetObjectValue<global::Klaviyo.Models.ProfileMetaPatchProperties_append>(global::Klaviyo.Models.ProfileMetaPatchProperties_append.CreateFromDiscriminatorValue); } },
                { "unappend", n => { Unappend = n.GetObjectValue<global::Klaviyo.Models.ProfileMetaPatchProperties_unappend>(global::Klaviyo.Models.ProfileMetaPatchProperties_unappend.CreateFromDiscriminatorValue); } },
                { "unset", n => { Unset = n.GetObjectValue<global::Klaviyo.Models.ProfileMetaPatchProperties.ProfileMetaPatchProperties_unset>(global::Klaviyo.Models.ProfileMetaPatchProperties.ProfileMetaPatchProperties_unset.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Klaviyo.Models.ProfileMetaPatchProperties_append>("append", Append);
            writer.WriteObjectValue<global::Klaviyo.Models.ProfileMetaPatchProperties_unappend>("unappend", Unappend);
            writer.WriteObjectValue<global::Klaviyo.Models.ProfileMetaPatchProperties.ProfileMetaPatchProperties_unset>("unset", Unset);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes <see cref="string"/>, List&lt;string&gt;
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ProfileMetaPatchProperties_unset : IComposedTypeWrapper, IParsable
        {
            /// <summary>Composed type representation for type <see cref="string"/></summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? ProfileMetaPatchPropertiesUnsetString { get; set; }
#nullable restore
#else
            public string ProfileMetaPatchPropertiesUnsetString { get; set; }
#endif
            /// <summary>Composed type representation for type List&lt;string&gt;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public List<string>? String { get; set; }
#nullable restore
#else
            public List<string> String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <returns>A <see cref="global::Klaviyo.Models.ProfileMetaPatchProperties.ProfileMetaPatchProperties_unset"/></returns>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static global::Klaviyo.Models.ProfileMetaPatchProperties.ProfileMetaPatchProperties_unset CreateFromDiscriminatorValue(IParseNode parseNode)
            {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new global::Klaviyo.Models.ProfileMetaPatchProperties.ProfileMetaPatchProperties_unset();
                if(parseNode.GetStringValue() is string profileMetaPatchPropertiesUnsetStringValue)
                {
                    result.ProfileMetaPatchPropertiesUnsetString = profileMetaPatchPropertiesUnsetStringValue;
                }
                else if(parseNode.GetCollectionOfPrimitiveValues<string>()?.AsList() is List<string> stringValue)
                {
                    result.String = stringValue;
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
            {
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer)
            {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(ProfileMetaPatchPropertiesUnsetString != null)
                {
                    writer.WriteStringValue(null, ProfileMetaPatchPropertiesUnsetString);
                }
                else if(String != null)
                {
                    writer.WriteCollectionOfPrimitiveValues<string>(null, String);
                }
            }
        }
    }
}
#pragma warning restore CS0618
