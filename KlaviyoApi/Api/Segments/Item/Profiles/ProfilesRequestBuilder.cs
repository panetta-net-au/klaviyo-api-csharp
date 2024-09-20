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
namespace Klaviyo.Api.Segments.Item.Profiles
{
    /// <summary>
    /// Builds and executes requests for operations under \api\segments\{id}\profiles
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ProfilesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.Segments.Item.Profiles.ProfilesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProfilesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/segments/{id}/profiles{?additional%2Dfields%5Bprofile%5D,fields%5Bprofile%5D,filter*,page%5Bcursor%5D*,page%5Bsize%5D*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.Segments.Item.Profiles.ProfilesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProfilesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/segments/{id}/profiles{?additional%2Dfields%5Bprofile%5D,fields%5Bprofile%5D,filter*,page%5Bcursor%5D*,page%5Bsize%5D*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Get all profiles within a segment with the given segment ID.Filter to request a subset of all profiles. Profiles can be filtered by `email`, `phone_number`, `push_token`, and `joined_group_at` fields. Profiles can be sorted by the following fields, in ascending and descending order: `joined_group_at`&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`profiles:read``segments:read`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetSegmentMemberResponseCollection"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.GetSegmentMemberResponseCollection4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.GetSegmentMemberResponseCollection5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.GetSegmentMemberResponseCollection?> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.Segments.Item.Profiles.ProfilesRequestBuilder.ProfilesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.GetSegmentMemberResponseCollection> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.Segments.Item.Profiles.ProfilesRequestBuilder.ProfilesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.GetSegmentMemberResponseCollection4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.GetSegmentMemberResponseCollection5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.GetSegmentMemberResponseCollection>(requestInfo, global::Klaviyo.Models.GetSegmentMemberResponseCollection.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all profiles within a segment with the given segment ID.Filter to request a subset of all profiles. Profiles can be filtered by `email`, `phone_number`, `push_token`, and `joined_group_at` fields. Profiles can be sorted by the following fields, in ascending and descending order: `joined_group_at`&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`profiles:read``segments:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.Segments.Item.Profiles.ProfilesRequestBuilder.ProfilesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.Segments.Item.Profiles.ProfilesRequestBuilder.ProfilesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Api.Segments.Item.Profiles.ProfilesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Klaviyo.Api.Segments.Item.Profiles.ProfilesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Klaviyo.Api.Segments.Item.Profiles.ProfilesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get all profiles within a segment with the given segment ID.Filter to request a subset of all profiles. Profiles can be filtered by `email`, `phone_number`, `push_token`, and `joined_group_at` fields. Profiles can be sorted by the following fields, in ascending and descending order: `joined_group_at`&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`profiles:read``segments:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ProfilesRequestBuilderGetQueryParameters 
        {
            /// <summary>Request additional fields not included by default in the response. Supported values: &apos;subscriptions&apos;, &apos;predictive_analytics&apos;</summary>
            [Obsolete("This property is deprecated, use AdditionalFieldsprofileAsGetAdditionalFieldsProfileQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("additional%2Dfields%5Bprofile%5D")]
            public string[]? AdditionalFieldsprofile { get; set; }
#nullable restore
#else
            [QueryParameter("additional%2Dfields%5Bprofile%5D")]
            public string[] AdditionalFieldsprofile { get; set; }
#endif
            /// <summary>Request additional fields not included by default in the response. Supported values: &apos;subscriptions&apos;, &apos;predictive_analytics&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("additional%2Dfields%5Bprofile%5D")]
            public global::Klaviyo.Api.Segments.Item.Profiles.GetAdditionalFieldsProfileQueryParameterType[]? AdditionalFieldsprofileAsGetAdditionalFieldsProfileQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("additional%2Dfields%5Bprofile%5D")]
            public global::Klaviyo.Api.Segments.Item.Profiles.GetAdditionalFieldsProfileQueryParameterType[] AdditionalFieldsprofileAsGetAdditionalFieldsProfileQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldsprofileAsGetFieldsProfileQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bprofile%5D")]
            public string[]? Fieldsprofile { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bprofile%5D")]
            public string[] Fieldsprofile { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bprofile%5D")]
            public global::Klaviyo.Api.Segments.Item.Profiles.GetFieldsProfileQueryParameterType[]? FieldsprofileAsGetFieldsProfileQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bprofile%5D")]
            public global::Klaviyo.Api.Segments.Item.Profiles.GetFieldsProfileQueryParameterType[] FieldsprofileAsGetFieldsProfileQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#filtering&lt;br&gt;Allowed field(s)/operator(s):&lt;br&gt;`email`: `any`, `equals`&lt;br&gt;`phone_number`: `any`, `equals`&lt;br&gt;`push_token`: `any`, `equals`&lt;br&gt;`_kx`: `equals`&lt;br&gt;`joined_group_at`: `greater-or-equal`, `greater-than`, `less-or-equal`, `less-than`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("filter")]
            public string Filter { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#pagination</summary>
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
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sorting</summary>
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
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sorting</summary>
            [QueryParameter("sort")]
            public global::Klaviyo.Api.Segments.Item.Profiles.GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ProfilesRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Klaviyo.Api.Segments.Item.Profiles.ProfilesRequestBuilder.ProfilesRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
