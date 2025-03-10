// <auto-generated/>
#pragma warning disable CS0618
using Klaviyo.Api.Segments.Item;
using Klaviyo.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Klaviyo.Api.Segments
{
    /// <summary>
    /// Builds and executes requests for operations under \api\segments
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class SegmentsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Klaviyo.api.segments.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Klaviyo.Api.Segments.Item.SegmentsItemRequestBuilder"/></returns>
        public global::Klaviyo.Api.Segments.Item.SegmentsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Klaviyo.Api.Segments.Item.SegmentsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.Segments.SegmentsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SegmentsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/segments{?fields%5Bflow%5D,fields%5Bsegment%5D,fields%5Btag%5D,filter*,include,page%5Bcursor%5D*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.Segments.SegmentsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SegmentsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/segments{?fields%5Bflow%5D,fields%5Bsegment%5D,fields%5Btag%5D,filter*,include,page%5Bcursor%5D*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Get all segments in an account.Filter to request a subset of all segments. Segments can be filtered by `name`, `created`, and `updated` fields.Returns a maximum of 10 results per page.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`segments:read`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetSegmentListResponseCollectionCompoundDocument"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.GetSegmentListResponseCollectionCompoundDocument4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.GetSegmentListResponseCollectionCompoundDocument5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.GetSegmentListResponseCollectionCompoundDocument?> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.Segments.SegmentsRequestBuilder.SegmentsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.GetSegmentListResponseCollectionCompoundDocument> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.Segments.SegmentsRequestBuilder.SegmentsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.GetSegmentListResponseCollectionCompoundDocument4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.GetSegmentListResponseCollectionCompoundDocument5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.GetSegmentListResponseCollectionCompoundDocument>(requestInfo, global::Klaviyo.Models.GetSegmentListResponseCollectionCompoundDocument.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a segment.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`&lt;br&gt;Daily: `100/d`**Scopes:**`segments:write`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.PostSegmentCreateResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.PostSegmentCreateResponse4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.PostSegmentCreateResponse5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.PostSegmentCreateResponse?> PostAsync(global::Klaviyo.Models.SegmentCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.PostSegmentCreateResponse> PostAsync(global::Klaviyo.Models.SegmentCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.PostSegmentCreateResponse4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.PostSegmentCreateResponse5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.PostSegmentCreateResponse>(requestInfo, global::Klaviyo.Models.PostSegmentCreateResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all segments in an account.Filter to request a subset of all segments. Segments can be filtered by `name`, `created`, and `updated` fields.Returns a maximum of 10 results per page.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`segments:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.Segments.SegmentsRequestBuilder.SegmentsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.Segments.SegmentsRequestBuilder.SegmentsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/vnd.api+json");
            return requestInfo;
        }
        /// <summary>
        /// Create a segment.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`&lt;br&gt;Daily: `100/d`**Scopes:**`segments:write`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Klaviyo.Models.SegmentCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Klaviyo.Models.SegmentCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Klaviyo.Api.Segments.SegmentsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Klaviyo.Api.Segments.SegmentsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Klaviyo.Api.Segments.SegmentsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get all segments in an account.Filter to request a subset of all segments. Segments can be filtered by `name`, `created`, and `updated` fields.Returns a maximum of 10 results per page.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`segments:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SegmentsRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldsflowAsGetFieldsFlowQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bflow%5D")]
            public string[]? Fieldsflow { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bflow%5D")]
            public string[] Fieldsflow { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bflow%5D")]
            public global::Klaviyo.Api.Segments.GetFieldsFlowQueryParameterType[]? FieldsflowAsGetFieldsFlowQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bflow%5D")]
            public global::Klaviyo.Api.Segments.GetFieldsFlowQueryParameterType[] FieldsflowAsGetFieldsFlowQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldssegmentAsGetFieldsSegmentQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bsegment%5D")]
            public string[]? Fieldssegment { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bsegment%5D")]
            public string[] Fieldssegment { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bsegment%5D")]
            public global::Klaviyo.Api.Segments.GetFieldsSegmentQueryParameterType[]? FieldssegmentAsGetFieldsSegmentQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bsegment%5D")]
            public global::Klaviyo.Api.Segments.GetFieldsSegmentQueryParameterType[] FieldssegmentAsGetFieldsSegmentQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldstagAsGetFieldsTagQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Btag%5D")]
            public string[]? Fieldstag { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Btag%5D")]
            public string[] Fieldstag { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Btag%5D")]
            public global::Klaviyo.Api.Segments.GetFieldsTagQueryParameterType[]? FieldstagAsGetFieldsTagQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Btag%5D")]
            public global::Klaviyo.Api.Segments.GetFieldsTagQueryParameterType[] FieldstagAsGetFieldsTagQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#filtering&lt;br&gt;Allowed field(s)/operator(s):&lt;br&gt;`name`: `any`, `equals`&lt;br&gt;`id`: `any`, `equals`&lt;br&gt;`created`: `greater-than`&lt;br&gt;`updated`: `greater-than`&lt;br&gt;`is_active`: `any`, `equals`&lt;br&gt;`is_starred`: `equals`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("filter")]
            public string Filter { get; set; }
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
            public global::Klaviyo.Api.Segments.GetIncludeQueryParameterType[]? IncludeAsGetIncludeQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("include")]
            public global::Klaviyo.Api.Segments.GetIncludeQueryParameterType[] IncludeAsGetIncludeQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#pagination</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("page%5Bcursor%5D")]
            public string? Pagecursor { get; set; }
#nullable restore
#else
            [QueryParameter("page%5Bcursor%5D")]
            public string Pagecursor { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sorting</summary>
            [Obsolete("This property is deprecated, use SortAsGetSortQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string Sort { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sorting</summary>
            [QueryParameter("sort")]
            public global::Klaviyo.Api.Segments.GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SegmentsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Klaviyo.Api.Segments.SegmentsRequestBuilder.SegmentsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class SegmentsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
