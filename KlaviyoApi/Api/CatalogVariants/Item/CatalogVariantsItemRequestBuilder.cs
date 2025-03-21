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
namespace Klaviyo.Api.CatalogVariants.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\catalog-variants\{id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CatalogVariantsItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.CatalogVariants.Item.CatalogVariantsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CatalogVariantsItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/catalog-variants/{id}{?fields%5Bcatalog%2Dvariant%5D}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.CatalogVariants.Item.CatalogVariantsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CatalogVariantsItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/catalog-variants/{id}{?fields%5Bcatalog%2Dvariant%5D}", rawUrl)
        {
        }
        /// <summary>
        /// Delete a catalog item variant with the given variant ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`catalogs:write`
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.CatalogVariants4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.CatalogVariants5XXError">When receiving a 5XX status code</exception>
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
                { "4XX", global::Klaviyo.Models.CatalogVariants4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.CatalogVariants5XXError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a catalog item variant with the given variant ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `350/s`&lt;br&gt;Steady: `3500/m`**Scopes:**`catalogs:read`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetCatalogVariantResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.GetCatalogVariantResponse4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.GetCatalogVariantResponse5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.GetCatalogVariantResponse?> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.CatalogVariants.Item.CatalogVariantsItemRequestBuilder.CatalogVariantsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.GetCatalogVariantResponse> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.CatalogVariants.Item.CatalogVariantsItemRequestBuilder.CatalogVariantsItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.GetCatalogVariantResponse4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.GetCatalogVariantResponse5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.GetCatalogVariantResponse>(requestInfo, global::Klaviyo.Models.GetCatalogVariantResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update a catalog item variant with the given variant ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`catalogs:write`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.PatchCatalogVariantResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.PatchCatalogVariantResponse4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.PatchCatalogVariantResponse5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.PatchCatalogVariantResponse?> PatchAsync(global::Klaviyo.Models.CatalogVariantUpdateQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.PatchCatalogVariantResponse> PatchAsync(global::Klaviyo.Models.CatalogVariantUpdateQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.PatchCatalogVariantResponse4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.PatchCatalogVariantResponse5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.PatchCatalogVariantResponse>(requestInfo, global::Klaviyo.Models.PatchCatalogVariantResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a catalog item variant with the given variant ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`catalogs:write`
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
        /// Get a catalog item variant with the given variant ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `350/s`&lt;br&gt;Steady: `3500/m`**Scopes:**`catalogs:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.CatalogVariants.Item.CatalogVariantsItemRequestBuilder.CatalogVariantsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.CatalogVariants.Item.CatalogVariantsItemRequestBuilder.CatalogVariantsItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/vnd.api+json");
            return requestInfo;
        }
        /// <summary>
        /// Update a catalog item variant with the given variant ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`catalogs:write`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Klaviyo.Models.CatalogVariantUpdateQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Klaviyo.Models.CatalogVariantUpdateQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Klaviyo.Api.CatalogVariants.Item.CatalogVariantsItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Klaviyo.Api.CatalogVariants.Item.CatalogVariantsItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Klaviyo.Api.CatalogVariants.Item.CatalogVariantsItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CatalogVariantsItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Get a catalog item variant with the given variant ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `350/s`&lt;br&gt;Steady: `3500/m`**Scopes:**`catalogs:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CatalogVariantsItemRequestBuilderGetQueryParameters 
        {
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
            public global::Klaviyo.Api.CatalogVariants.Item.GetFieldsCatalogVariantQueryParameterType[]? FieldscatalogVariantAsGetFieldsCatalogVariantQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bcatalog%2Dvariant%5D")]
            public global::Klaviyo.Api.CatalogVariants.Item.GetFieldsCatalogVariantQueryParameterType[] FieldscatalogVariantAsGetFieldsCatalogVariantQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CatalogVariantsItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Klaviyo.Api.CatalogVariants.Item.CatalogVariantsItemRequestBuilder.CatalogVariantsItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CatalogVariantsItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
