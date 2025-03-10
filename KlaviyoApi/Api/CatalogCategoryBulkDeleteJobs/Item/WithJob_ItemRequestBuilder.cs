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
namespace Klaviyo.Api.CatalogCategoryBulkDeleteJobs.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\catalog-category-bulk-delete-jobs\{job_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithJob_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.CatalogCategoryBulkDeleteJobs.Item.WithJob_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithJob_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/catalog-category-bulk-delete-jobs/{job_id}{?fields%5Bcatalog%2Dcategory%2Dbulk%2Ddelete%2Djob%5D}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.CatalogCategoryBulkDeleteJobs.Item.WithJob_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithJob_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/catalog-category-bulk-delete-jobs/{job_id}{?fields%5Bcatalog%2Dcategory%2Dbulk%2Ddelete%2Djob%5D}", rawUrl)
        {
        }
        /// <summary>
        /// Get a catalog category bulk delete job with the given job ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `350/s`&lt;br&gt;Steady: `3500/m`**Scopes:**`catalogs:read`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetCatalogCategoryDeleteJobResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.GetCatalogCategoryDeleteJobResponse4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.GetCatalogCategoryDeleteJobResponse5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.GetCatalogCategoryDeleteJobResponse?> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.CatalogCategoryBulkDeleteJobs.Item.WithJob_ItemRequestBuilder.WithJob_ItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.GetCatalogCategoryDeleteJobResponse> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.CatalogCategoryBulkDeleteJobs.Item.WithJob_ItemRequestBuilder.WithJob_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.GetCatalogCategoryDeleteJobResponse4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.GetCatalogCategoryDeleteJobResponse5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.GetCatalogCategoryDeleteJobResponse>(requestInfo, global::Klaviyo.Models.GetCatalogCategoryDeleteJobResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a catalog category bulk delete job with the given job ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `350/s`&lt;br&gt;Steady: `3500/m`**Scopes:**`catalogs:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.CatalogCategoryBulkDeleteJobs.Item.WithJob_ItemRequestBuilder.WithJob_ItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.CatalogCategoryBulkDeleteJobs.Item.WithJob_ItemRequestBuilder.WithJob_ItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Klaviyo.Api.CatalogCategoryBulkDeleteJobs.Item.WithJob_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Klaviyo.Api.CatalogCategoryBulkDeleteJobs.Item.WithJob_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Klaviyo.Api.CatalogCategoryBulkDeleteJobs.Item.WithJob_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get a catalog category bulk delete job with the given job ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `350/s`&lt;br&gt;Steady: `3500/m`**Scopes:**`catalogs:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithJob_ItemRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldscatalogCategoryBulkDeleteJobAsGetFieldsCatalogCategoryBulkDeleteJobQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bcatalog%2Dcategory%2Dbulk%2Ddelete%2Djob%5D")]
            public string[]? FieldscatalogCategoryBulkDeleteJob { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bcatalog%2Dcategory%2Dbulk%2Ddelete%2Djob%5D")]
            public string[] FieldscatalogCategoryBulkDeleteJob { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bcatalog%2Dcategory%2Dbulk%2Ddelete%2Djob%5D")]
            public global::Klaviyo.Api.CatalogCategoryBulkDeleteJobs.Item.GetFieldsCatalogCategoryBulkDeleteJobQueryParameterType[]? FieldscatalogCategoryBulkDeleteJobAsGetFieldsCatalogCategoryBulkDeleteJobQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bcatalog%2Dcategory%2Dbulk%2Ddelete%2Djob%5D")]
            public global::Klaviyo.Api.CatalogCategoryBulkDeleteJobs.Item.GetFieldsCatalogCategoryBulkDeleteJobQueryParameterType[] FieldscatalogCategoryBulkDeleteJobAsGetFieldsCatalogCategoryBulkDeleteJobQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithJob_ItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Klaviyo.Api.CatalogCategoryBulkDeleteJobs.Item.WithJob_ItemRequestBuilder.WithJob_ItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
