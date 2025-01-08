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
namespace Klaviyo.Api.Segments.Item.FlowTriggers
{
    /// <summary>
    /// Builds and executes requests for operations under \api\segments\{id}\flow-triggers
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class FlowTriggersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.Segments.Item.FlowTriggers.FlowTriggersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FlowTriggersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/segments/{id}/flow-triggers{?fields%5Bflow%5D}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.Segments.Item.FlowTriggers.FlowTriggersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FlowTriggersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/segments/{id}/flow-triggers{?fields%5Bflow%5D}", rawUrl)
        {
        }
        /// <summary>
        /// Get all flows where the given segment ID is being used as the trigger.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`flows:read``segments:read`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetFlowResponseCollection"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.GetFlowResponseCollection4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.GetFlowResponseCollection5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.GetFlowResponseCollection?> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.Segments.Item.FlowTriggers.FlowTriggersRequestBuilder.FlowTriggersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.GetFlowResponseCollection> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.Segments.Item.FlowTriggers.FlowTriggersRequestBuilder.FlowTriggersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.GetFlowResponseCollection4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.GetFlowResponseCollection5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.GetFlowResponseCollection>(requestInfo, global::Klaviyo.Models.GetFlowResponseCollection.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all flows where the given segment ID is being used as the trigger.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`flows:read``segments:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.Segments.Item.FlowTriggers.FlowTriggersRequestBuilder.FlowTriggersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.Segments.Item.FlowTriggers.FlowTriggersRequestBuilder.FlowTriggersRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Klaviyo.Api.Segments.Item.FlowTriggers.FlowTriggersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Klaviyo.Api.Segments.Item.FlowTriggers.FlowTriggersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Klaviyo.Api.Segments.Item.FlowTriggers.FlowTriggersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get all flows where the given segment ID is being used as the trigger.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`flows:read``segments:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class FlowTriggersRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-10-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldsflowAsGetFieldsFlowQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bflow%5D")]
            public string[]? Fieldsflow { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bflow%5D")]
            public string[] Fieldsflow { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-10-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bflow%5D")]
            public global::Klaviyo.Api.Segments.Item.FlowTriggers.GetFieldsFlowQueryParameterType[]? FieldsflowAsGetFieldsFlowQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bflow%5D")]
            public global::Klaviyo.Api.Segments.Item.FlowTriggers.GetFieldsFlowQueryParameterType[] FieldsflowAsGetFieldsFlowQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class FlowTriggersRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Klaviyo.Api.Segments.Item.FlowTriggers.FlowTriggersRequestBuilder.FlowTriggersRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
