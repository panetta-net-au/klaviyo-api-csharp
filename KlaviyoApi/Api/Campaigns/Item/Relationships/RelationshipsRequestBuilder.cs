// <auto-generated/>
#pragma warning disable CS0618
using Klaviyo.Api.Campaigns.Item.Relationships.CampaignMessages;
using Klaviyo.Api.Campaigns.Item.Relationships.Tags;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Klaviyo.Api.Campaigns.Item.Relationships
{
    /// <summary>
    /// Builds and executes requests for operations under \api\campaigns\{id}\relationships
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RelationshipsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The campaignMessages property</summary>
        public global::Klaviyo.Api.Campaigns.Item.Relationships.CampaignMessages.CampaignMessagesRequestBuilder CampaignMessages
        {
            get => new global::Klaviyo.Api.Campaigns.Item.Relationships.CampaignMessages.CampaignMessagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tags property</summary>
        public global::Klaviyo.Api.Campaigns.Item.Relationships.Tags.TagsRequestBuilder Tags
        {
            get => new global::Klaviyo.Api.Campaigns.Item.Relationships.Tags.TagsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.Campaigns.Item.Relationships.RelationshipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RelationshipsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/campaigns/{id}/relationships", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.Campaigns.Item.Relationships.RelationshipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RelationshipsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/campaigns/{id}/relationships", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
