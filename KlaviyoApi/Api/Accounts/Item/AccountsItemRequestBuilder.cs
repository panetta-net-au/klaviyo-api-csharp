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
namespace Klaviyo.Api.Accounts.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\accounts\{id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AccountsItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.Accounts.Item.AccountsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountsItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/accounts/{id}{?fields%5Baccount%5D}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.Accounts.Item.AccountsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountsItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/accounts/{id}{?fields%5Baccount%5D}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve a single account object by its account ID. You can only request the account by which the private API key was generated.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`**Scopes:**`accounts:read`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetAccountResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.GetAccountResponse4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.GetAccountResponse5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.GetAccountResponse?> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.Accounts.Item.AccountsItemRequestBuilder.AccountsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.GetAccountResponse> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.Accounts.Item.AccountsItemRequestBuilder.AccountsItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.GetAccountResponse4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.GetAccountResponse5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.GetAccountResponse>(requestInfo, global::Klaviyo.Models.GetAccountResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve a single account object by its account ID. You can only request the account by which the private API key was generated.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`**Scopes:**`accounts:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.Accounts.Item.AccountsItemRequestBuilder.AccountsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.Accounts.Item.AccountsItemRequestBuilder.AccountsItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Klaviyo.Api.Accounts.Item.AccountsItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Klaviyo.Api.Accounts.Item.AccountsItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Klaviyo.Api.Accounts.Item.AccountsItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve a single account object by its account ID. You can only request the account by which the private API key was generated.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `1/s`&lt;br&gt;Steady: `15/m`**Scopes:**`accounts:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AccountsItemRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldsaccountAsGetFieldsAccountQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Baccount%5D")]
            public string[]? Fieldsaccount { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Baccount%5D")]
            public string[] Fieldsaccount { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2025-01-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Baccount%5D")]
            public global::Klaviyo.Api.Accounts.Item.GetFieldsAccountQueryParameterType[]? FieldsaccountAsGetFieldsAccountQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Baccount%5D")]
            public global::Klaviyo.Api.Accounts.Item.GetFieldsAccountQueryParameterType[] FieldsaccountAsGetFieldsAccountQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class AccountsItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Klaviyo.Api.Accounts.Item.AccountsItemRequestBuilder.AccountsItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
