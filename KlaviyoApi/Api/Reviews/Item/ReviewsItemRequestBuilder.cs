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
namespace Klaviyo.Api.Reviews.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\reviews\{id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ReviewsItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.Reviews.Item.ReviewsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReviewsItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/reviews/{id}{?fields%5Bevent%5D,fields%5Breview%5D,include}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.Reviews.Item.ReviewsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReviewsItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/reviews/{id}{?fields%5Bevent%5D,fields%5Breview%5D,include}", rawUrl)
        {
        }
        /// <summary>
        /// Get the review with the given ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `10/s`&lt;br&gt;Steady: `150/m`**Scopes:**`reviews:read`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetReviewResponseDTOCompoundDocument"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.GetReviewResponseDTOCompoundDocument4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.GetReviewResponseDTOCompoundDocument5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.GetReviewResponseDTOCompoundDocument?> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.Reviews.Item.ReviewsItemRequestBuilder.ReviewsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.GetReviewResponseDTOCompoundDocument> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.Reviews.Item.ReviewsItemRequestBuilder.ReviewsItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.GetReviewResponseDTOCompoundDocument4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.GetReviewResponseDTOCompoundDocument5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.GetReviewResponseDTOCompoundDocument>(requestInfo, global::Klaviyo.Models.GetReviewResponseDTOCompoundDocument.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update a review.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `10/s`&lt;br&gt;Steady: `150/m`**Scopes:**`reviews:write`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.PatchReviewResponseDTO"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.PatchReviewResponseDTO4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.PatchReviewResponseDTO5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.PatchReviewResponseDTO?> PatchAsync(global::Klaviyo.Models.ReviewPatchQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.PatchReviewResponseDTO> PatchAsync(global::Klaviyo.Models.ReviewPatchQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.PatchReviewResponseDTO4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.PatchReviewResponseDTO5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.PatchReviewResponseDTO>(requestInfo, global::Klaviyo.Models.PatchReviewResponseDTO.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the review with the given ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `10/s`&lt;br&gt;Steady: `150/m`**Scopes:**`reviews:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.Reviews.Item.ReviewsItemRequestBuilder.ReviewsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.Reviews.Item.ReviewsItemRequestBuilder.ReviewsItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/vnd.api+json");
            return requestInfo;
        }
        /// <summary>
        /// Update a review.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `10/s`&lt;br&gt;Steady: `150/m`**Scopes:**`reviews:write`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Klaviyo.Models.ReviewPatchQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Klaviyo.Models.ReviewPatchQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/vnd.api+json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/vnd.api+json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Api.Reviews.Item.ReviewsItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Klaviyo.Api.Reviews.Item.ReviewsItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Klaviyo.Api.Reviews.Item.ReviewsItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get the review with the given ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `10/s`&lt;br&gt;Steady: `150/m`**Scopes:**`reviews:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ReviewsItemRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldseventAsGetFieldsEventQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bevent%5D")]
            public string[]? Fieldsevent { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bevent%5D")]
            public string[] Fieldsevent { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bevent%5D")]
            public global::Klaviyo.Api.Reviews.Item.GetFieldsEventQueryParameterType[]? FieldseventAsGetFieldsEventQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bevent%5D")]
            public global::Klaviyo.Api.Reviews.Item.GetFieldsEventQueryParameterType[] FieldseventAsGetFieldsEventQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldsreviewAsGetFieldsReviewQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Breview%5D")]
            public string[]? Fieldsreview { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Breview%5D")]
            public string[] Fieldsreview { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Breview%5D")]
            public global::Klaviyo.Api.Reviews.Item.GetFieldsReviewQueryParameterType[]? FieldsreviewAsGetFieldsReviewQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Breview%5D")]
            public global::Klaviyo.Api.Reviews.Item.GetFieldsReviewQueryParameterType[] FieldsreviewAsGetFieldsReviewQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#relationships</summary>
            [Obsolete("This property is deprecated, use IncludeAsGetIncludeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("include")]
            public string[]? Include { get; set; }
#nullable restore
#else
            [QueryParameter("include")]
            public string[] Include { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#relationships</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("include")]
            public global::Klaviyo.Api.Reviews.Item.GetIncludeQueryParameterType[]? IncludeAsGetIncludeQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("include")]
            public global::Klaviyo.Api.Reviews.Item.GetIncludeQueryParameterType[] IncludeAsGetIncludeQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ReviewsItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Klaviyo.Api.Reviews.Item.ReviewsItemRequestBuilder.ReviewsItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ReviewsItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
