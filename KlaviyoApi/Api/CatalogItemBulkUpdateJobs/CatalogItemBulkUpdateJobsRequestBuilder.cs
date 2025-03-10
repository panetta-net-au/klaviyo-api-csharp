// <auto-generated/>
#pragma warning disable CS0618
using Klaviyo.Api.CatalogItemBulkUpdateJobs.Item;
using Klaviyo.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Klaviyo.Api.CatalogItemBulkUpdateJobs
{
    /// <summary>
    /// Builds and executes requests for operations under \api\catalog-item-bulk-update-jobs
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CatalogItemBulkUpdateJobsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Klaviyo.api.catalogItemBulkUpdateJobs.item collection</summary>
        /// <param name="position">ID of the job to retrieve.</param>
        /// <returns>A <see cref="global::Klaviyo.Api.CatalogItemBulkUpdateJobs.Item.WithJob_ItemRequestBuilder"/></returns>
        public global::Klaviyo.Api.CatalogItemBulkUpdateJobs.Item.WithJob_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("job_id", position);
                return new global::Klaviyo.Api.CatalogItemBulkUpdateJobs.Item.WithJob_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.CatalogItemBulkUpdateJobs.CatalogItemBulkUpdateJobsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CatalogItemBulkUpdateJobsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/catalog-item-bulk-update-jobs{?fields%5Bcatalog%2Ditem%2Dbulk%2Dupdate%2Djob%5D,filter*,page%5Bcursor%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.CatalogItemBulkUpdateJobs.CatalogItemBulkUpdateJobsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CatalogItemBulkUpdateJobsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/catalog-item-bulk-update-jobs{?fields%5Bcatalog%2Ditem%2Dbulk%2Dupdate%2Djob%5D,filter*,page%5Bcursor%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Get all catalog item bulk update jobs.Returns a maximum of 100 jobs per request.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `350/s`&lt;br&gt;Steady: `3500/m`**Scopes:**`catalogs:read`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetCatalogItemUpdateJobResponseCollectionCompoundDocument"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.GetCatalogItemUpdateJobResponseCollectionCompoundDocument4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.GetCatalogItemUpdateJobResponseCollectionCompoundDocument5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.GetCatalogItemUpdateJobResponseCollectionCompoundDocument?> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.CatalogItemBulkUpdateJobs.CatalogItemBulkUpdateJobsRequestBuilder.CatalogItemBulkUpdateJobsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.GetCatalogItemUpdateJobResponseCollectionCompoundDocument> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.CatalogItemBulkUpdateJobs.CatalogItemBulkUpdateJobsRequestBuilder.CatalogItemBulkUpdateJobsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.GetCatalogItemUpdateJobResponseCollectionCompoundDocument4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.GetCatalogItemUpdateJobResponseCollectionCompoundDocument5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.GetCatalogItemUpdateJobResponseCollectionCompoundDocument>(requestInfo, global::Klaviyo.Models.GetCatalogItemUpdateJobResponseCollectionCompoundDocument.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a catalog item bulk update job to update a batch of catalog items.Accepts up to 100 catalog items per request. The maximum allowed payload size is 5MB.The maximum number of jobs in progress at one time is 500.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`catalogs:write`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.PostCatalogItemUpdateJobResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.PostCatalogItemUpdateJobResponse4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.PostCatalogItemUpdateJobResponse5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.PostCatalogItemUpdateJobResponse?> PostAsync(global::Klaviyo.Models.CatalogItemUpdateJobCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.PostCatalogItemUpdateJobResponse> PostAsync(global::Klaviyo.Models.CatalogItemUpdateJobCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.PostCatalogItemUpdateJobResponse4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.PostCatalogItemUpdateJobResponse5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.PostCatalogItemUpdateJobResponse>(requestInfo, global::Klaviyo.Models.PostCatalogItemUpdateJobResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all catalog item bulk update jobs.Returns a maximum of 100 jobs per request.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `350/s`&lt;br&gt;Steady: `3500/m`**Scopes:**`catalogs:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.CatalogItemBulkUpdateJobs.CatalogItemBulkUpdateJobsRequestBuilder.CatalogItemBulkUpdateJobsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.CatalogItemBulkUpdateJobs.CatalogItemBulkUpdateJobsRequestBuilder.CatalogItemBulkUpdateJobsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/vnd.api+json");
            return requestInfo;
        }
        /// <summary>
        /// Create a catalog item bulk update job to update a batch of catalog items.Accepts up to 100 catalog items per request. The maximum allowed payload size is 5MB.The maximum number of jobs in progress at one time is 500.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`catalogs:write`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Klaviyo.Models.CatalogItemUpdateJobCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Klaviyo.Models.CatalogItemUpdateJobCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Klaviyo.Api.CatalogItemBulkUpdateJobs.CatalogItemBulkUpdateJobsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Klaviyo.Api.CatalogItemBulkUpdateJobs.CatalogItemBulkUpdateJobsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Klaviyo.Api.CatalogItemBulkUpdateJobs.CatalogItemBulkUpdateJobsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get all catalog item bulk update jobs.Returns a maximum of 100 jobs per request.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `350/s`&lt;br&gt;Steady: `3500/m`**Scopes:**`catalogs:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CatalogItemBulkUpdateJobsRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldscatalogItemBulkUpdateJobAsGetFieldsCatalogItemBulkUpdateJobQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bcatalog%2Ditem%2Dbulk%2Dupdate%2Djob%5D")]
            public string[]? FieldscatalogItemBulkUpdateJob { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bcatalog%2Ditem%2Dbulk%2Dupdate%2Djob%5D")]
            public string[] FieldscatalogItemBulkUpdateJob { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bcatalog%2Ditem%2Dbulk%2Dupdate%2Djob%5D")]
            public global::Klaviyo.Api.CatalogItemBulkUpdateJobs.GetFieldsCatalogItemBulkUpdateJobQueryParameterType[]? FieldscatalogItemBulkUpdateJobAsGetFieldsCatalogItemBulkUpdateJobQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bcatalog%2Ditem%2Dbulk%2Dupdate%2Djob%5D")]
            public global::Klaviyo.Api.CatalogItemBulkUpdateJobs.GetFieldsCatalogItemBulkUpdateJobQueryParameterType[] FieldscatalogItemBulkUpdateJobAsGetFieldsCatalogItemBulkUpdateJobQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#filtering&lt;br&gt;Allowed field(s)/operator(s):&lt;br&gt;`status`: `equals`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("filter")]
            public string Filter { get; set; }
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
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CatalogItemBulkUpdateJobsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Klaviyo.Api.CatalogItemBulkUpdateJobs.CatalogItemBulkUpdateJobsRequestBuilder.CatalogItemBulkUpdateJobsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CatalogItemBulkUpdateJobsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
