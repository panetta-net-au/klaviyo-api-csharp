// <auto-generated/>
#pragma warning disable CS0618
using Klaviyo.Api.FormVersions.Item.Form;
using Klaviyo.Api.FormVersions.Item.Relationships;
using Klaviyo.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Klaviyo.Api.FormVersions.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\form-versions\{id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class FormVersionsItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The form property</summary>
        public global::Klaviyo.Api.FormVersions.Item.Form.FormRequestBuilder Form
        {
            get => new global::Klaviyo.Api.FormVersions.Item.Form.FormRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The relationships property</summary>
        public global::Klaviyo.Api.FormVersions.Item.Relationships.RelationshipsRequestBuilder Relationships
        {
            get => new global::Klaviyo.Api.FormVersions.Item.Relationships.RelationshipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.FormVersions.Item.FormVersionsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FormVersionsItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/form-versions/{id}{?fields%5Bform%2Dversion%5D}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.FormVersions.Item.FormVersionsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FormVersionsItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/form-versions/{id}{?fields%5Bform%2Dversion%5D}", rawUrl)
        {
        }
        /// <summary>
        /// Get the form version with the given ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`forms:read`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetFormVersionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.GetFormVersionResponse4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.GetFormVersionResponse5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.GetFormVersionResponse?> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.FormVersions.Item.FormVersionsItemRequestBuilder.FormVersionsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.GetFormVersionResponse> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.FormVersions.Item.FormVersionsItemRequestBuilder.FormVersionsItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.GetFormVersionResponse4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.GetFormVersionResponse5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.GetFormVersionResponse>(requestInfo, global::Klaviyo.Models.GetFormVersionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the form version with the given ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`forms:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.FormVersions.Item.FormVersionsItemRequestBuilder.FormVersionsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.FormVersions.Item.FormVersionsItemRequestBuilder.FormVersionsItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Klaviyo.Api.FormVersions.Item.FormVersionsItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Klaviyo.Api.FormVersions.Item.FormVersionsItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Klaviyo.Api.FormVersions.Item.FormVersionsItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get the form version with the given ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`forms:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class FormVersionsItemRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldsformVersionAsGetFieldsFormVersionQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bform%2Dversion%5D")]
            public string[]? FieldsformVersion { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bform%2Dversion%5D")]
            public string[] FieldsformVersion { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bform%2Dversion%5D")]
            public global::Klaviyo.Api.FormVersions.Item.GetFieldsFormVersionQueryParameterType[]? FieldsformVersionAsGetFieldsFormVersionQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bform%2Dversion%5D")]
            public global::Klaviyo.Api.FormVersions.Item.GetFieldsFormVersionQueryParameterType[] FieldsformVersionAsGetFieldsFormVersionQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class FormVersionsItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Klaviyo.Api.FormVersions.Item.FormVersionsItemRequestBuilder.FormVersionsItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
