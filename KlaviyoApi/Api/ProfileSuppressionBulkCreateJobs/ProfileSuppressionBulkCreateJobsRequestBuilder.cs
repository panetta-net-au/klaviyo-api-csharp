// <auto-generated/>
#pragma warning disable CS0618
using Klaviyo.Api.ProfileSuppressionBulkCreateJobs.Item;
using Klaviyo.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Klaviyo.Api.ProfileSuppressionBulkCreateJobs
{
    /// <summary>
    /// Builds and executes requests for operations under \api\profile-suppression-bulk-create-jobs
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ProfileSuppressionBulkCreateJobsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Klaviyo.api.profileSuppressionBulkCreateJobs.item collection</summary>
        /// <param name="position">ID of the job to retrieve.</param>
        /// <returns>A <see cref="global::Klaviyo.Api.ProfileSuppressionBulkCreateJobs.Item.WithJob_ItemRequestBuilder"/></returns>
        public global::Klaviyo.Api.ProfileSuppressionBulkCreateJobs.Item.WithJob_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("job_id", position);
                return new global::Klaviyo.Api.ProfileSuppressionBulkCreateJobs.Item.WithJob_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.ProfileSuppressionBulkCreateJobs.ProfileSuppressionBulkCreateJobsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProfileSuppressionBulkCreateJobsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/profile-suppression-bulk-create-jobs{?fields%5Bprofile%2Dsuppression%2Dbulk%2Dcreate%2Djob%5D,filter*,page%5Bcursor%5D*,sort*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.ProfileSuppressionBulkCreateJobs.ProfileSuppressionBulkCreateJobsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProfileSuppressionBulkCreateJobsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/profile-suppression-bulk-create-jobs{?fields%5Bprofile%2Dsuppression%2Dbulk%2Dcreate%2Djob%5D,filter*,page%5Bcursor%5D*,sort*}", rawUrl)
        {
        }
        /// <summary>
        /// Get the status of all bulk profile suppression jobs.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`subscriptions:read`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetBulkProfileSuppressionsCreateJobResponseCollection"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.GetBulkProfileSuppressionsCreateJobResponseCollection4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.GetBulkProfileSuppressionsCreateJobResponseCollection5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.GetBulkProfileSuppressionsCreateJobResponseCollection?> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.ProfileSuppressionBulkCreateJobs.ProfileSuppressionBulkCreateJobsRequestBuilder.ProfileSuppressionBulkCreateJobsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.GetBulkProfileSuppressionsCreateJobResponseCollection> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.ProfileSuppressionBulkCreateJobs.ProfileSuppressionBulkCreateJobsRequestBuilder.ProfileSuppressionBulkCreateJobsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.GetBulkProfileSuppressionsCreateJobResponseCollection4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.GetBulkProfileSuppressionsCreateJobResponseCollection5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.GetBulkProfileSuppressionsCreateJobResponseCollection>(requestInfo, global::Klaviyo.Models.GetBulkProfileSuppressionsCreateJobResponseCollection.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Manually suppress profiles by email address or specify a segment/list ID to suppress all current members of a segment/list.Suppressed profiles cannot receive email marketing, independent of their consent status. To learn more, see our guides on [email suppressions](https://help.klaviyo.com/hc/en-us/articles/115005246108#what-is-a-suppressed-profile-1) and [collecting consent](https://developers.klaviyo.com/en/docs/collect_email_and_sms_consent_via_api).Email address per request limit: 100&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`profiles:write``subscriptions:write`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.PostBulkProfileSuppressionsCreateJobResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.PostBulkProfileSuppressionsCreateJobResponse4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.PostBulkProfileSuppressionsCreateJobResponse5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.PostBulkProfileSuppressionsCreateJobResponse?> PostAsync(global::Klaviyo.Models.SuppressionCreateJobCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.PostBulkProfileSuppressionsCreateJobResponse> PostAsync(global::Klaviyo.Models.SuppressionCreateJobCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.PostBulkProfileSuppressionsCreateJobResponse4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.PostBulkProfileSuppressionsCreateJobResponse5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.PostBulkProfileSuppressionsCreateJobResponse>(requestInfo, global::Klaviyo.Models.PostBulkProfileSuppressionsCreateJobResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the status of all bulk profile suppression jobs.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`subscriptions:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.ProfileSuppressionBulkCreateJobs.ProfileSuppressionBulkCreateJobsRequestBuilder.ProfileSuppressionBulkCreateJobsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.ProfileSuppressionBulkCreateJobs.ProfileSuppressionBulkCreateJobsRequestBuilder.ProfileSuppressionBulkCreateJobsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/vnd.api+json");
            return requestInfo;
        }
        /// <summary>
        /// Manually suppress profiles by email address or specify a segment/list ID to suppress all current members of a segment/list.Suppressed profiles cannot receive email marketing, independent of their consent status. To learn more, see our guides on [email suppressions](https://help.klaviyo.com/hc/en-us/articles/115005246108#what-is-a-suppressed-profile-1) and [collecting consent](https://developers.klaviyo.com/en/docs/collect_email_and_sms_consent_via_api).Email address per request limit: 100&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`profiles:write``subscriptions:write`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Klaviyo.Models.SuppressionCreateJobCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Klaviyo.Models.SuppressionCreateJobCreateQuery body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Klaviyo.Api.ProfileSuppressionBulkCreateJobs.ProfileSuppressionBulkCreateJobsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Klaviyo.Api.ProfileSuppressionBulkCreateJobs.ProfileSuppressionBulkCreateJobsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Klaviyo.Api.ProfileSuppressionBulkCreateJobs.ProfileSuppressionBulkCreateJobsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get the status of all bulk profile suppression jobs.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`subscriptions:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ProfileSuppressionBulkCreateJobsRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-10-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldsprofileSuppressionBulkCreateJobAsGetFieldsProfileSuppressionBulkCreateJobQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bprofile%2Dsuppression%2Dbulk%2Dcreate%2Djob%5D")]
            public string[]? FieldsprofileSuppressionBulkCreateJob { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bprofile%2Dsuppression%2Dbulk%2Dcreate%2Djob%5D")]
            public string[] FieldsprofileSuppressionBulkCreateJob { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-10-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bprofile%2Dsuppression%2Dbulk%2Dcreate%2Djob%5D")]
            public global::Klaviyo.Api.ProfileSuppressionBulkCreateJobs.GetFieldsProfileSuppressionBulkCreateJobQueryParameterType[]? FieldsprofileSuppressionBulkCreateJobAsGetFieldsProfileSuppressionBulkCreateJobQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bprofile%2Dsuppression%2Dbulk%2Dcreate%2Djob%5D")]
            public global::Klaviyo.Api.ProfileSuppressionBulkCreateJobs.GetFieldsProfileSuppressionBulkCreateJobQueryParameterType[] FieldsprofileSuppressionBulkCreateJobAsGetFieldsProfileSuppressionBulkCreateJobQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-10-15/reference/api-overview#filtering&lt;br&gt;Allowed field(s)/operator(s):&lt;br&gt;`status`: `equals`&lt;br&gt;`list_id`: `equals`&lt;br&gt;`segment_id`: `equals`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("filter")]
            public string Filter { get; set; }
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
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-10-15/reference/api-overview#sorting</summary>
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
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-10-15/reference/api-overview#sorting</summary>
            [QueryParameter("sort")]
            public global::Klaviyo.Api.ProfileSuppressionBulkCreateJobs.GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ProfileSuppressionBulkCreateJobsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Klaviyo.Api.ProfileSuppressionBulkCreateJobs.ProfileSuppressionBulkCreateJobsRequestBuilder.ProfileSuppressionBulkCreateJobsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ProfileSuppressionBulkCreateJobsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
