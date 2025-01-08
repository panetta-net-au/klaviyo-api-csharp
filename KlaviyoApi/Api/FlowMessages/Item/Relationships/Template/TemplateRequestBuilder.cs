// <auto-generated/>
#pragma warning disable CS0618
using Klaviyo.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Klaviyo.Api.FlowMessages.Item.Relationships.Template
{
    /// <summary>
    /// Builds and executes requests for operations under \api\flow-messages\{id}\relationships\template
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class TemplateRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.FlowMessages.Item.Relationships.Template.TemplateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TemplateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/flow-messages/{id}/relationships/template", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.FlowMessages.Item.Relationships.Template.TemplateRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TemplateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/flow-messages/{id}/relationships/template", rawUrl)
        {
        }
        /// <summary>
        /// Returns the ID of the related template&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`templates:read`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetFlowMessageTemplateRelationshipResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.GetFlowMessageTemplateRelationshipResponse4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.GetFlowMessageTemplateRelationshipResponse5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.GetFlowMessageTemplateRelationshipResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.GetFlowMessageTemplateRelationshipResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.GetFlowMessageTemplateRelationshipResponse4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.GetFlowMessageTemplateRelationshipResponse5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.GetFlowMessageTemplateRelationshipResponse>(requestInfo, global::Klaviyo.Models.GetFlowMessageTemplateRelationshipResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the ID of the related template&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`templates:read`
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
            requestInfo.Headers.TryAdd("Accept", "application/vnd.api+json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Api.FlowMessages.Item.Relationships.Template.TemplateRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Klaviyo.Api.FlowMessages.Item.Relationships.Template.TemplateRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Klaviyo.Api.FlowMessages.Item.Relationships.Template.TemplateRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class TemplateRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
