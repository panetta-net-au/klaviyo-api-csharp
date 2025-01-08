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
namespace Klaviyo.Api.ProfileImport
{
    /// <summary>
    /// Builds and executes requests for operations under \api\profile-import
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class ProfileImportRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.ProfileImport.ProfileImportRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProfileImportRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/profile-import{?additional%2Dfields%5Bprofile%5D}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.ProfileImport.ProfileImportRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProfileImportRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/profile-import{?additional%2Dfields%5Bprofile%5D}", rawUrl)
        {
        }
        /// <summary>
        /// Given a set of profile attributes and optionally an ID, create or update a profile.Returns 201 if a new profile was created, 200 if an existing profile was updated.Use the `additional-fields` parameter to include subscriptions and predictive analytics data in your response.Note that setting a field to `null` will clear out the field, whereas not including a field in your request will leave it unchanged.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`profiles:write`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.PostProfileResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.PostProfileResponse4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.PostProfileResponse5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.PostProfileResponse?> PostAsync(global::Klaviyo.Models.ProfileUpsertQuery body, Action<RequestConfiguration<global::Klaviyo.Api.ProfileImport.ProfileImportRequestBuilder.ProfileImportRequestBuilderPostQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.PostProfileResponse> PostAsync(global::Klaviyo.Models.ProfileUpsertQuery body, Action<RequestConfiguration<global::Klaviyo.Api.ProfileImport.ProfileImportRequestBuilder.ProfileImportRequestBuilderPostQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.PostProfileResponse4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.PostProfileResponse5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.PostProfileResponse>(requestInfo, global::Klaviyo.Models.PostProfileResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Given a set of profile attributes and optionally an ID, create or update a profile.Returns 201 if a new profile was created, 200 if an existing profile was updated.Use the `additional-fields` parameter to include subscriptions and predictive analytics data in your response.Note that setting a field to `null` will clear out the field, whereas not including a field in your request will leave it unchanged.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`profiles:write`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Klaviyo.Models.ProfileUpsertQuery body, Action<RequestConfiguration<global::Klaviyo.Api.ProfileImport.ProfileImportRequestBuilder.ProfileImportRequestBuilderPostQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Klaviyo.Models.ProfileUpsertQuery body, Action<RequestConfiguration<global::Klaviyo.Api.ProfileImport.ProfileImportRequestBuilder.ProfileImportRequestBuilderPostQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Klaviyo.Api.ProfileImport.ProfileImportRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Klaviyo.Api.ProfileImport.ProfileImportRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Klaviyo.Api.ProfileImport.ProfileImportRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Given a set of profile attributes and optionally an ID, create or update a profile.Returns 201 if a new profile was created, 200 if an existing profile was updated.Use the `additional-fields` parameter to include subscriptions and predictive analytics data in your response.Note that setting a field to `null` will clear out the field, whereas not including a field in your request will leave it unchanged.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `75/s`&lt;br&gt;Steady: `700/m`**Scopes:**`profiles:write`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ProfileImportRequestBuilderPostQueryParameters 
        {
            /// <summary>Request additional fields not included by default in the response. Supported values: &apos;subscriptions&apos;, &apos;predictive_analytics&apos;</summary>
            [Obsolete("This property is deprecated, use AdditionalFieldsprofileAsPostAdditionalFieldsProfileQueryParameterType instead")]
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
            public global::Klaviyo.Api.ProfileImport.PostAdditionalFieldsProfileQueryParameterType[]? AdditionalFieldsprofileAsPostAdditionalFieldsProfileQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("additional%2Dfields%5Bprofile%5D")]
            public global::Klaviyo.Api.ProfileImport.PostAdditionalFieldsProfileQueryParameterType[] AdditionalFieldsprofileAsPostAdditionalFieldsProfileQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class ProfileImportRequestBuilderPostRequestConfiguration : RequestConfiguration<global::Klaviyo.Api.ProfileImport.ProfileImportRequestBuilder.ProfileImportRequestBuilderPostQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
