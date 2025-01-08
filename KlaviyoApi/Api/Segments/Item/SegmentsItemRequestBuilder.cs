// <auto-generated/>
#pragma warning disable CS0618
using Klaviyo.Api.Segments.Item.FlowTriggers;
using Klaviyo.Api.Segments.Item.Profiles;
using Klaviyo.Api.Segments.Item.Relationships;
using Klaviyo.Api.Segments.Item.Tags;
using Klaviyo.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Klaviyo.Api.Segments.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\segments\{id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class SegmentsItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The flowTriggers property</summary>
        public global::Klaviyo.Api.Segments.Item.FlowTriggers.FlowTriggersRequestBuilder FlowTriggers
        {
            get => new global::Klaviyo.Api.Segments.Item.FlowTriggers.FlowTriggersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The profiles property</summary>
        public global::Klaviyo.Api.Segments.Item.Profiles.ProfilesRequestBuilder Profiles
        {
            get => new global::Klaviyo.Api.Segments.Item.Profiles.ProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The relationships property</summary>
        public global::Klaviyo.Api.Segments.Item.Relationships.RelationshipsRequestBuilder Relationships
        {
            get => new global::Klaviyo.Api.Segments.Item.Relationships.RelationshipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tags property</summary>
        public global::Klaviyo.Api.Segments.Item.Tags.TagsRequestBuilder Tags
        {
            get => new global::Klaviyo.Api.Segments.Item.Tags.TagsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.Segments.Item.SegmentsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SegmentsItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/segments/{id}{?additional%2Dfields%5Bsegment%5D,fields%5Bflow%5D,fields%5Bsegment%5D,fields%5Btag%5D,include}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.Segments.Item.SegmentsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SegmentsItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/segments/{id}{?additional%2Dfields%5Bsegment%5D,fields%5Bflow%5D,fields%5Bsegment%5D,fields%5Btag%5D,include}", rawUrl)
        {
        }
        /// <summary>
        /// Delete a segment with the given segment ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`segments:write`
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.Segments4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.Segments5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.Segments4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.Segments5XXError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a segment with the given segment ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`&lt;br&gt;&lt;br&gt;Rate limits when using the `additional-fields[segment]=profile_count` parameter in your API request:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`&lt;br&gt;&lt;br&gt;To learn more about how the `additional-fields` parameter impacts rate limits, check out our [Rate limits, status codes, and errors](https://developers.klaviyo.com/en/v2024-10-15/docs/rate_limits_and_error_handling) guide.**Scopes:**`segments:read`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetSegmentRetrieveResponseCompoundDocument"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.GetSegmentRetrieveResponseCompoundDocument4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.GetSegmentRetrieveResponseCompoundDocument5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.GetSegmentRetrieveResponseCompoundDocument?> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.Segments.Item.SegmentsItemRequestBuilder.SegmentsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.GetSegmentRetrieveResponseCompoundDocument> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.Segments.Item.SegmentsItemRequestBuilder.SegmentsItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.GetSegmentRetrieveResponseCompoundDocument4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.GetSegmentRetrieveResponseCompoundDocument5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.GetSegmentRetrieveResponseCompoundDocument>(requestInfo, global::Klaviyo.Models.GetSegmentRetrieveResponseCompoundDocument.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update a segment with the given segment ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`&lt;br&gt;Daily: `100/d`**Scopes:**`segments:write`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.PatchSegmentPartialUpdateResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.PatchSegmentPartialUpdateResponse4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.PatchSegmentPartialUpdateResponse5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.PatchSegmentPartialUpdateResponse?> PatchAsync(global::Klaviyo.Models.SegmentPartialUpdateQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.PatchSegmentPartialUpdateResponse> PatchAsync(global::Klaviyo.Models.SegmentPartialUpdateQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.PatchSegmentPartialUpdateResponse4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.PatchSegmentPartialUpdateResponse5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.PatchSegmentPartialUpdateResponse>(requestInfo, global::Klaviyo.Models.PatchSegmentPartialUpdateResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a segment with the given segment ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`segments:write`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/vnd.api+json");
            return requestInfo;
        }
        /// <summary>
        /// Get a segment with the given segment ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`&lt;br&gt;&lt;br&gt;Rate limits when using the `additional-fields[segment]=profile_count` parameter in your API request:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`&lt;br&gt;&lt;br&gt;To learn more about how the `additional-fields` parameter impacts rate limits, check out our [Rate limits, status codes, and errors](https://developers.klaviyo.com/en/v2024-10-15/docs/rate_limits_and_error_handling) guide.**Scopes:**`segments:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.Segments.Item.SegmentsItemRequestBuilder.SegmentsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.Segments.Item.SegmentsItemRequestBuilder.SegmentsItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/vnd.api+json");
            return requestInfo;
        }
        /// <summary>
        /// Update a segment with the given segment ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`&lt;br&gt;Daily: `100/d`**Scopes:**`segments:write`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Klaviyo.Models.SegmentPartialUpdateQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Klaviyo.Models.SegmentPartialUpdateQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Klaviyo.Api.Segments.Item.SegmentsItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Klaviyo.Api.Segments.Item.SegmentsItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Klaviyo.Api.Segments.Item.SegmentsItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class SegmentsItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Get a segment with the given segment ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`&lt;br&gt;&lt;br&gt;Rate limits when using the `additional-fields[segment]=profile_count` parameter in your API request:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`&lt;br&gt;&lt;br&gt;To learn more about how the `additional-fields` parameter impacts rate limits, check out our [Rate limits, status codes, and errors](https://developers.klaviyo.com/en/v2024-10-15/docs/rate_limits_and_error_handling) guide.**Scopes:**`segments:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class SegmentsItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Request additional fields not included by default in the response. Supported values: &apos;profile_count&apos;</summary>
            [Obsolete("This property is deprecated, use AdditionalFieldssegmentAsGetAdditionalFieldsSegmentQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("additional%2Dfields%5Bsegment%5D")]
            public string[]? AdditionalFieldssegment { get; set; }
#nullable restore
#else
            [QueryParameter("additional%2Dfields%5Bsegment%5D")]
            public string[] AdditionalFieldssegment { get; set; }
#endif
            /// <summary>Request additional fields not included by default in the response. Supported values: &apos;profile_count&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("additional%2Dfields%5Bsegment%5D")]
            public global::Klaviyo.Api.Segments.Item.GetAdditionalFieldsSegmentQueryParameterType[]? AdditionalFieldssegmentAsGetAdditionalFieldsSegmentQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("additional%2Dfields%5Bsegment%5D")]
            public global::Klaviyo.Api.Segments.Item.GetAdditionalFieldsSegmentQueryParameterType[] AdditionalFieldssegmentAsGetAdditionalFieldsSegmentQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-10-15/reference/api-overview#sparse-fieldsets</summary>
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
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-10-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bflow%5D")]
            public global::Klaviyo.Api.Segments.Item.GetFieldsFlowQueryParameterType[]? FieldsflowAsGetFieldsFlowQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bflow%5D")]
            public global::Klaviyo.Api.Segments.Item.GetFieldsFlowQueryParameterType[] FieldsflowAsGetFieldsFlowQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-10-15/reference/api-overview#sparse-fieldsets</summary>
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
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-10-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bsegment%5D")]
            public global::Klaviyo.Api.Segments.Item.GetFieldsSegmentQueryParameterType[]? FieldssegmentAsGetFieldsSegmentQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bsegment%5D")]
            public global::Klaviyo.Api.Segments.Item.GetFieldsSegmentQueryParameterType[] FieldssegmentAsGetFieldsSegmentQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-10-15/reference/api-overview#sparse-fieldsets</summary>
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
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-10-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Btag%5D")]
            public global::Klaviyo.Api.Segments.Item.GetFieldsTagQueryParameterType[]? FieldstagAsGetFieldsTagQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Btag%5D")]
            public global::Klaviyo.Api.Segments.Item.GetFieldsTagQueryParameterType[] FieldstagAsGetFieldsTagQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-10-15/reference/api-overview#relationships</summary>
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
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-10-15/reference/api-overview#relationships</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("include")]
            public global::Klaviyo.Api.Segments.Item.GetIncludeQueryParameterType[]? IncludeAsGetIncludeQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("include")]
            public global::Klaviyo.Api.Segments.Item.GetIncludeQueryParameterType[] IncludeAsGetIncludeQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class SegmentsItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Klaviyo.Api.Segments.Item.SegmentsItemRequestBuilder.SegmentsItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class SegmentsItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
