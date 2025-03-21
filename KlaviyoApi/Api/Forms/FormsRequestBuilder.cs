// <auto-generated/>
#pragma warning disable CS0618
using Klaviyo.Api.Forms.Item;
using Klaviyo.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Klaviyo.Api.Forms
{
    /// <summary>
    /// Builds and executes requests for operations under \api\forms
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class FormsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Klaviyo.api.forms.item collection</summary>
        /// <param name="position">The ID of the form</param>
        /// <returns>A <see cref="global::Klaviyo.Api.Forms.Item.FormsItemRequestBuilder"/></returns>
        public global::Klaviyo.Api.Forms.Item.FormsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Klaviyo.Api.Forms.Item.FormsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.Forms.FormsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FormsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/forms{?fields%5Bform%5D,filter*,page%5Bcursor%5D*,page%5Bsize%5D*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.Forms.FormsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FormsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/forms{?fields%5Bform%5D,filter*,page%5Bcursor%5D*,page%5Bsize%5D*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Get all forms in an account.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`forms:read`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetFormResponseCollectionCompoundDocument"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.GetFormResponseCollectionCompoundDocument4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.GetFormResponseCollectionCompoundDocument5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.GetFormResponseCollectionCompoundDocument?> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.Forms.FormsRequestBuilder.FormsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.GetFormResponseCollectionCompoundDocument> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.Forms.FormsRequestBuilder.FormsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.GetFormResponseCollectionCompoundDocument4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.GetFormResponseCollectionCompoundDocument5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.GetFormResponseCollectionCompoundDocument>(requestInfo, global::Klaviyo.Models.GetFormResponseCollectionCompoundDocument.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all forms in an account.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`forms:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.Forms.FormsRequestBuilder.FormsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.Forms.FormsRequestBuilder.FormsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Klaviyo.Api.Forms.FormsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Klaviyo.Api.Forms.FormsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Klaviyo.Api.Forms.FormsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get all forms in an account.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`forms:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class FormsRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldsformAsGetFieldsFormQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bform%5D")]
            public string[]? Fieldsform { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bform%5D")]
            public string[] Fieldsform { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bform%5D")]
            public global::Klaviyo.Api.Forms.GetFieldsFormQueryParameterType[]? FieldsformAsGetFieldsFormQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bform%5D")]
            public global::Klaviyo.Api.Forms.GetFieldsFormQueryParameterType[] FieldsformAsGetFieldsFormQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#filtering&lt;br&gt;Allowed field(s)/operator(s):&lt;br&gt;`id`: `any`, `equals`&lt;br&gt;`name`: `any`, `contains`, `equals`&lt;br&gt;`ab_test`: `equals`&lt;br&gt;`updated_at`: `greater-or-equal`, `greater-than`, `less-or-equal`, `less-than`&lt;br&gt;`created_at`: `greater-or-equal`, `greater-than`, `less-or-equal`, `less-than`&lt;br&gt;`status`: `equals`</summary>
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
            /// <summary>Default: 20. Min: 1. Max: 100.</summary>
            [QueryParameter("page%5Bsize%5D")]
            public int? Pagesize { get; set; }
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
            public global::Klaviyo.Api.Forms.GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class FormsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Klaviyo.Api.Forms.FormsRequestBuilder.FormsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
