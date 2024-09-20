// <auto-generated/>
#pragma warning disable CS0618
using Klaviyo.Api.FlowActions.Item.Flow;
using Klaviyo.Api.FlowActions.Item.FlowMessages;
using Klaviyo.Api.FlowActions.Item.Relationships;
using Klaviyo.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Klaviyo.Api.FlowActions.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \api\flow-actions\{id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public partial class FlowActionsItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The flow property</summary>
        public global::Klaviyo.Api.FlowActions.Item.Flow.FlowRequestBuilder Flow
        {
            get => new global::Klaviyo.Api.FlowActions.Item.Flow.FlowRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The flowMessages property</summary>
        public global::Klaviyo.Api.FlowActions.Item.FlowMessages.FlowMessagesRequestBuilder FlowMessages
        {
            get => new global::Klaviyo.Api.FlowActions.Item.FlowMessages.FlowMessagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The relationships property</summary>
        public global::Klaviyo.Api.FlowActions.Item.Relationships.RelationshipsRequestBuilder Relationships
        {
            get => new global::Klaviyo.Api.FlowActions.Item.Relationships.RelationshipsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.FlowActions.Item.FlowActionsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FlowActionsItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/flow-actions/{id}{?fields%5Bflow%2Daction%5D,fields%5Bflow%2Dmessage%5D,fields%5Bflow%5D,include}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.FlowActions.Item.FlowActionsItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FlowActionsItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/flow-actions/{id}{?fields%5Bflow%2Daction%5D,fields%5Bflow%2Dmessage%5D,fields%5Bflow%5D,include}", rawUrl)
        {
        }
        /// <summary>
        /// Get a flow action from a flow with the given flow action ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`flows:read`
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.GetFlowActionResponseCompoundDocument"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Klaviyo.Models.GetFlowActionResponseCompoundDocument4XXError">When receiving a 4XX status code</exception>
        /// <exception cref="global::Klaviyo.Models.GetFlowActionResponseCompoundDocument5XXError">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Klaviyo.Models.GetFlowActionResponseCompoundDocument?> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.FlowActions.Item.FlowActionsItemRequestBuilder.FlowActionsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Klaviyo.Models.GetFlowActionResponseCompoundDocument> GetAsync(Action<RequestConfiguration<global::Klaviyo.Api.FlowActions.Item.FlowActionsItemRequestBuilder.FlowActionsItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "4XX", global::Klaviyo.Models.GetFlowActionResponseCompoundDocument4XXError.CreateFromDiscriminatorValue },
                { "5XX", global::Klaviyo.Models.GetFlowActionResponseCompoundDocument5XXError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Klaviyo.Models.GetFlowActionResponseCompoundDocument>(requestInfo, global::Klaviyo.Models.GetFlowActionResponseCompoundDocument.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a flow action from a flow with the given flow action ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`flows:read`
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.FlowActions.Item.FlowActionsItemRequestBuilder.FlowActionsItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Klaviyo.Api.FlowActions.Item.FlowActionsItemRequestBuilder.FlowActionsItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Klaviyo.Api.FlowActions.Item.FlowActionsItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Klaviyo.Api.FlowActions.Item.FlowActionsItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Klaviyo.Api.FlowActions.Item.FlowActionsItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get a flow action from a flow with the given flow action ID.&lt;br&gt;&lt;br&gt;*Rate limits*:&lt;br&gt;Burst: `3/s`&lt;br&gt;Steady: `60/m`**Scopes:**`flows:read`
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class FlowActionsItemRequestBuilderGetQueryParameters 
        {
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
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
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldsflowActionAsGetFieldsFlowActionQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bflow%2Daction%5D")]
            public string[]? FieldsflowAction { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bflow%2Daction%5D")]
            public string[] FieldsflowAction { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bflow%2Daction%5D")]
            public global::Klaviyo.Api.FlowActions.Item.GetFieldsFlowActionQueryParameterType[]? FieldsflowActionAsGetFieldsFlowActionQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bflow%2Daction%5D")]
            public global::Klaviyo.Api.FlowActions.Item.GetFieldsFlowActionQueryParameterType[] FieldsflowActionAsGetFieldsFlowActionQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bflow%5D")]
            public global::Klaviyo.Api.FlowActions.Item.GetFieldsFlowQueryParameterType[]? FieldsflowAsGetFieldsFlowQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bflow%5D")]
            public global::Klaviyo.Api.FlowActions.Item.GetFieldsFlowQueryParameterType[] FieldsflowAsGetFieldsFlowQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
            [Obsolete("This property is deprecated, use FieldsflowMessageAsGetFieldsFlowMessageQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bflow%2Dmessage%5D")]
            public string[]? FieldsflowMessage { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bflow%2Dmessage%5D")]
            public string[] FieldsflowMessage { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#sparse-fieldsets</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields%5Bflow%2Dmessage%5D")]
            public global::Klaviyo.Api.FlowActions.Item.GetFieldsFlowMessageQueryParameterType[]? FieldsflowMessageAsGetFieldsFlowMessageQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("fields%5Bflow%2Dmessage%5D")]
            public global::Klaviyo.Api.FlowActions.Item.GetFieldsFlowMessageQueryParameterType[] FieldsflowMessageAsGetFieldsFlowMessageQueryParameterType { get; set; }
#endif
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#relationships</summary>
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
            /// <summary>For more information please visit https://developers.klaviyo.com/en/v2024-07-15/reference/api-overview#relationships</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("include")]
            public global::Klaviyo.Api.FlowActions.Item.GetIncludeQueryParameterType[]? IncludeAsGetIncludeQueryParameterType { get; set; }
#nullable restore
#else
            [QueryParameter("include")]
            public global::Klaviyo.Api.FlowActions.Item.GetIncludeQueryParameterType[] IncludeAsGetIncludeQueryParameterType { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
        public partial class FlowActionsItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Klaviyo.Api.FlowActions.Item.FlowActionsItemRequestBuilder.FlowActionsItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
