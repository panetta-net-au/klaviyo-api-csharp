// <auto-generated/>
#pragma warning disable CS0618
using Klaviyo.Api.WebhookTopics.Item;
using Klaviyo.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Klaviyo.Api.WebhookTopics
{
    /// <summary>
    /// Builds and executes requests for operations under \api\webhook-topics
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class WebhookTopicsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Klaviyo.api.webhookTopics.item collection</summary>
        /// <param name="position">The ID of the webhook topic.</param>
        /// <returns>A <see cref="global::Klaviyo.Api.WebhookTopics.Item.WebhookTopicsItemRequestBuilder"/></returns>
        public global::Klaviyo.Api.WebhookTopics.Item.WebhookTopicsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Klaviyo.Api.WebhookTopics.Item.WebhookTopicsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.WebhookTopics.WebhookTopicsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WebhookTopicsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/webhook-topics", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.WebhookTopics.WebhookTopicsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WebhookTopicsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/webhook-topics", rawUrl)
        {
        }
        /// <summary>
        /// Get all webhook topics in a Klaviyo account.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`**Scopes:**`webhooks:read`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetWebhookTopicResponseCollection"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.GetWebhookTopicResponseCollection4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.GetWebhookTopicResponseCollection5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.GetWebhookTopicResponseCollection?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.GetWebhookTopicResponseCollection> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.GetWebhookTopicResponseCollection4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.GetWebhookTopicResponseCollection5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.GetWebhookTopicResponseCollection>(requestInfo, global::Klaviyo.Models.GetWebhookTopicResponseCollection.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all webhook topics in a Klaviyo account.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`**Scopes:**`webhooks:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Api.WebhookTopics.WebhookTopicsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Klaviyo.Api.WebhookTopics.WebhookTopicsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Klaviyo.Api.WebhookTopics.WebhookTopicsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class WebhookTopicsRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
