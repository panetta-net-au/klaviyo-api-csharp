// <auto-generated/>
#pragma warning disable CS0618
using Klaviyo.Api.TrackingSettings.Item;
using Klaviyo.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Klaviyo.Api.TrackingSettings
{
    /// <summary>
    /// Builds and executes requests for operations under \api\tracking-settings
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class TrackingSettingsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Klaviyo.api.trackingSettings.item collection</summary>
        /// <param name="position">The id of the tracking setting (account ID).</param>
        /// <returns>A <see cref="global::Klaviyo.Api.TrackingSettings.Item.TrackingSettingsItemRequestBuilder"/></returns>
        public global::Klaviyo.Api.TrackingSettings.Item.TrackingSettingsItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("id", position);
                return new global::Klaviyo.Api.TrackingSettings.Item.TrackingSettingsItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.TrackingSettings.TrackingSettingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TrackingSettingsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/tracking-settings{?fields%5Btracking%2Dsetting%5D,page%5Bcursor%5D*,page%5Bsize%5D*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.TrackingSettings.TrackingSettingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TrackingSettingsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/tracking-settings{?fields%5Btracking%2Dsetting%5D,page%5Bcursor%5D*,page%5Bsize%5D*}", rawUrl)
        {
        }
        /// <summary>
        /// Get all tracking settings in an account. Returns an array with a single tracking setting.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `10/s`&lt;br&gt;Steady: `150/m`**Scopes:**`tracking-settings:read`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetTrackingSettingResponseCollection"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.GetTrackingSettingResponseCollection4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.GetTrackingSettingResponseCollection5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.GetTrackingSettingResponseCollection?> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.TrackingSettings.TrackingSettingsRequestBuilder.TrackingSettingsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.GetTrackingSettingResponseCollection> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.TrackingSettings.TrackingSettingsRequestBuilder.TrackingSettingsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.GetTrackingSettingResponseCollection4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.GetTrackingSettingResponseCollection5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.GetTrackingSettingResponseCollection>(requestInfo, global::Klaviyo.Models.GetTrackingSettingResponseCollection.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all tracking settings in an account. Returns an array with a single tracking setting.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `10/s`&lt;br&gt;Steady: `150/m`**Scopes:**`tracking-settings:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.TrackingSettings.TrackingSettingsRequestBuilder.TrackingSettingsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.TrackingSettings.TrackingSettingsRequestBuilder.TrackingSettingsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Klaviyo.Api.TrackingSettings.TrackingSettingsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Klaviyo.Api.TrackingSettings.TrackingSettingsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Klaviyo.Api.TrackingSettings.TrackingSettingsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get all tracking settings in an account. Returns an array with a single tracking setting.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `10/s`&lt;br&gt;Steady: `150/m`**Scopes:**`tracking-settings:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class TrackingSettingsRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-10-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldstrackingSettingAsGetFieldsTrackingSettingQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Btracking%2Dsetting%5D")]
            public string[]? FieldstrackingSetting { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Btracking%2Dsetting%5D")]
            public string[] FieldstrackingSetting { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-10-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Btracking%2Dsetting%5D")]
            public global::Klaviyo.Api.TrackingSettings.GetFieldsTrackingSettingQueryParameterType[]? FieldstrackingSettingAsGetFieldsTrackingSettingQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Btracking%2Dsetting%5D")]
            public global::Klaviyo.Api.TrackingSettings.GetFieldsTrackingSettingQueryParameterType[] FieldstrackingSettingAsGetFieldsTrackingSettingQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-10-15/reference/api-overview#pagination</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("page%5Bcursor%5D")]
            public string? Pagecursor { get; set; }
#nullable restore
#else
            [QueryParameter("page%5Bcursor%5D")]
            public string Pagecursor { get; set; }
#endif
            /// <summary>Default: 1. Min: 1. Max: 1.</summary>
            [QueryParameter("page%5Bsize%5D")]
            public int? Pagesize { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class TrackingSettingsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Klaviyo.Api.TrackingSettings.TrackingSettingsRequestBuilder.TrackingSettingsRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
