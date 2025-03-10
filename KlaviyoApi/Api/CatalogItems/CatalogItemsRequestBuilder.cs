// <auto-generated/>
#pragma warning disable CS0618
using Klaviyo.Api.CatalogItems.Item;
using Klaviyo.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Klaviyo.Api.CatalogItems
{
    /// <summary>
    /// Builds and executes requests for operations under \api\catalog-items
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CatalogItemsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Klaviyo.api.catalogItems.item collection</summary>
        /// <param name="position">The catalog item ID is a compound ID (string), with format: `{integration}:::{catalog}:::{external_id}`. Currently, the only supported integration type is `$custom`, and the only supported catalog is `$default`.</param>
        /// <returns>A <see cref="global::Klaviyo.Api.CatalogItems.Item.CatalogItemsItemRequestBuilder"/></returns>
        public global::Klaviyo.Api.CatalogItems.Item.CatalogItemsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Klaviyo.Api.CatalogItems.Item.CatalogItemsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.CatalogItems.CatalogItemsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CatalogItemsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/catalog-items{?fields%5Bcatalog%2Ditem%5D,fields%5Bcatalog%2Dvariant%5D,filter*,include,page%5Bcursor%5D*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.CatalogItems.CatalogItemsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CatalogItemsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/catalog-items{?fields%5Bcatalog%2Ditem%5D,fields%5Bcatalog%2Dvariant%5D,filter*,include,page%5Bcursor%5D*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Get all catalog items in an account.Catalog items can be sorted by the following fields, in ascending and descending order:`created`Currently, the only supported integration type is `$custom`, and the only supported catalog type is `$default`.Returns a maximum of 100 items per request.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `350/s`&lt;br&gt;Steady: `3500/m`**Scopes:**`catalogs:read`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetCatalogItemResponseCollectionCompoundDocument"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.GetCatalogItemResponseCollectionCompoundDocument4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.GetCatalogItemResponseCollectionCompoundDocument5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.GetCatalogItemResponseCollectionCompoundDocument?> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.CatalogItems.CatalogItemsRequestBuilder.CatalogItemsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.GetCatalogItemResponseCollectionCompoundDocument> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.CatalogItems.CatalogItemsRequestBuilder.CatalogItemsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.GetCatalogItemResponseCollectionCompoundDocument4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.GetCatalogItemResponseCollectionCompoundDocument5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.GetCatalogItemResponseCollectionCompoundDocument>(requestInfo, global::Klaviyo.Models.GetCatalogItemResponseCollectionCompoundDocument.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new catalog item.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`catalogs:write`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.PostCatalogItemResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.PostCatalogItemResponse4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.PostCatalogItemResponse5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.PostCatalogItemResponse?> PostAsync(global::Klaviyo.Models.CatalogItemCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.PostCatalogItemResponse> PostAsync(global::Klaviyo.Models.CatalogItemCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.PostCatalogItemResponse4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.PostCatalogItemResponse5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.PostCatalogItemResponse>(requestInfo, global::Klaviyo.Models.PostCatalogItemResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all catalog items in an account.Catalog items can be sorted by the following fields, in ascending and descending order:`created`Currently, the only supported integration type is `$custom`, and the only supported catalog type is `$default`.Returns a maximum of 100 items per request.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `350/s`&lt;br&gt;Steady: `3500/m`**Scopes:**`catalogs:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.CatalogItems.CatalogItemsRequestBuilder.CatalogItemsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.CatalogItems.CatalogItemsRequestBuilder.CatalogItemsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/vnd.api+json");
            return requestInfo;
        }
        /// <summary>
        /// Create a new catalog item.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`catalogs:write`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Klaviyo.Models.CatalogItemCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Klaviyo.Models.CatalogItemCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Klaviyo.Api.CatalogItems.CatalogItemsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Klaviyo.Api.CatalogItems.CatalogItemsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Klaviyo.Api.CatalogItems.CatalogItemsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get all catalog items in an account.Catalog items can be sorted by the following fields, in ascending and descending order:`created`Currently, the only supported integration type is `$custom`, and the only supported catalog type is `$default`.Returns a maximum of 100 items per request.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `350/s`&lt;br&gt;Steady: `3500/m`**Scopes:**`catalogs:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CatalogItemsRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldscatalogItemAsGetFieldsCatalogItemQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bcatalog%2Ditem%5D")]
            public string[]? FieldscatalogItem { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bcatalog%2Ditem%5D")]
            public string[] FieldscatalogItem { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bcatalog%2Ditem%5D")]
            public global::Klaviyo.Api.CatalogItems.GetFieldsCatalogItemQueryParameterType[]? FieldscatalogItemAsGetFieldsCatalogItemQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bcatalog%2Ditem%5D")]
            public global::Klaviyo.Api.CatalogItems.GetFieldsCatalogItemQueryParameterType[] FieldscatalogItemAsGetFieldsCatalogItemQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldscatalogVariantAsGetFieldsCatalogVariantQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bcatalog%2Dvariant%5D")]
            public string[]? FieldscatalogVariant { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bcatalog%2Dvariant%5D")]
            public string[] FieldscatalogVariant { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bcatalog%2Dvariant%5D")]
            public global::Klaviyo.Api.CatalogItems.GetFieldsCatalogVariantQueryParameterType[]? FieldscatalogVariantAsGetFieldsCatalogVariantQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bcatalog%2Dvariant%5D")]
            public global::Klaviyo.Api.CatalogItems.GetFieldsCatalogVariantQueryParameterType[] FieldscatalogVariantAsGetFieldsCatalogVariantQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#filtering&lt;br&gt;Allowed field(s)/operator(s):&lt;br&gt;`ids`: `any`&lt;br&gt;`category.id`: `equals`&lt;br&gt;`title`: `contains`&lt;br&gt;`published`: `equals`</summary>
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
            public global::Klaviyo.Api.CatalogItems.GetIncludeQueryParameterType[]? IncludeAsGetIncludeQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("include")]
            public global::Klaviyo.Api.CatalogItems.GetIncludeQueryParameterType[] IncludeAsGetIncludeQueryParameterType { get; set; }
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
            public global::Klaviyo.Api.CatalogItems.GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CatalogItemsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Klaviyo.Api.CatalogItems.CatalogItemsRequestBuilder.CatalogItemsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CatalogItemsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
