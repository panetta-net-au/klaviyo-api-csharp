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
namespace Klaviyo.Api.CampaignValuesReports
{
    /// <summary>
    /// Builds and executes requests for operations under \api\campaign-values-reports
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class CampaignValuesReportsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.CampaignValuesReports.CampaignValuesReportsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CampaignValuesReportsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/campaign-values-reports{?page_cursor*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.CampaignValuesReports.CampaignValuesReportsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CampaignValuesReportsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/campaign-values-reports{?page_cursor*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns the requested campaign analytics values data&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `2/m`&lt;br&gt;Daily: `225/d`**Scopes:**`campaigns:read`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.PostCampaignValuesResponseDTO"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.PostCampaignValuesResponseDTO4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.PostCampaignValuesResponseDTO5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.PostCampaignValuesResponseDTO?> PostAsync(global::Klaviyo.Models.CampaignValuesRequestDTO body, Action<RequestConfiguration<global::Klaviyo.Api.CampaignValuesReports.CampaignValuesReportsRequestBuilder.CampaignValuesReportsRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.PostCampaignValuesResponseDTO> PostAsync(global::Klaviyo.Models.CampaignValuesRequestDTO body, Action<RequestConfiguration<global::Klaviyo.Api.CampaignValuesReports.CampaignValuesReportsRequestBuilder.CampaignValuesReportsRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.PostCampaignValuesResponseDTO4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.PostCampaignValuesResponseDTO5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.PostCampaignValuesResponseDTO>(requestInfo, global::Klaviyo.Models.PostCampaignValuesResponseDTO.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the requested campaign analytics values data&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `2/m`&lt;br&gt;Daily: `225/d`**Scopes:**`campaigns:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Klaviyo.Models.CampaignValuesRequestDTO body, Action<RequestConfiguration<global::Klaviyo.Api.CampaignValuesReports.CampaignValuesReportsRequestBuilder.CampaignValuesReportsRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Klaviyo.Models.CampaignValuesRequestDTO body, Action<RequestConfiguration<global::Klaviyo.Api.CampaignValuesReports.CampaignValuesReportsRequestBuilder.CampaignValuesReportsRequestBuilderPostQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/vnd.api+json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/vnd.api+json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Api.CampaignValuesReports.CampaignValuesReportsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Klaviyo.Api.CampaignValuesReports.CampaignValuesReportsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Klaviyo.Api.CampaignValuesReports.CampaignValuesReportsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns the requested campaign analytics values data&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `2/m`&lt;br&gt;Daily: `225/d`**Scopes:**`campaigns:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class CampaignValuesReportsRequestBuilderPostQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-10-15/reference/api-overview#pagination</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("page_cursor")]
            public string? PageCursor { get; set; }
#nullable restore
#else
            [QueryParameter("page_cursor")]
            public string PageCursor { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class CampaignValuesReportsRequestBuilderPostRequestConfiguration : RequestConfiguration<global::Klaviyo.Api.CampaignValuesReports.CampaignValuesReportsRequestBuilder.CampaignValuesReportsRequestBuilderPostQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
