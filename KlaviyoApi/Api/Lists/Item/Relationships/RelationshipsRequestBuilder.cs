// <auto-generated/>
#pragma warning disable CS0618
using Klaviyo.Api.Lists.Item.Relationships.Profiles;
using Klaviyo.Api.Lists.Item.Relationships.Tags;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Klaviyo.Api.Lists.Item.Relationships
{
    /// <summary>
    /// Builds and executes requests for operations under \api\lists\{id}\relationships
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class RelationshipsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The profiles property</summary>
        public global::Klaviyo.Api.Lists.Item.Relationships.Profiles.ProfilesRequestBuilder Profiles
        {
            get => new global::Klaviyo.Api.Lists.Item.Relationships.Profiles.ProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tags property</summary>
        public global::Klaviyo.Api.Lists.Item.Relationships.Tags.TagsRequestBuilder Tags
        {
            get => new global::Klaviyo.Api.Lists.Item.Relationships.Tags.TagsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.Lists.Item.Relationships.RelationshipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RelationshipsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/lists/{id}/relationships", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.Lists.Item.Relationships.RelationshipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RelationshipsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/lists/{id}/relationships", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
