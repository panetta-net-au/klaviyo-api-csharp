// <auto-generated/>
#pragma warning disable CS0618
using Klaviyo.Api.FlowMessages.Item.Relationships.FlowAction;
using Klaviyo.Api.FlowMessages.Item.Relationships.Template;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Klaviyo.Api.FlowMessages.Item.Relationships
{
    /// <summary>
    /// Builds and executes requests for operations under \api\flow-messages\{id}\relationships
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RelationshipsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The flowAction property</summary>
        public global::Klaviyo.Api.FlowMessages.Item.Relationships.FlowAction.FlowActionRequestBuilder FlowAction
        {
            get => new global::Klaviyo.Api.FlowMessages.Item.Relationships.FlowAction.FlowActionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The template property</summary>
        public global::Klaviyo.Api.FlowMessages.Item.Relationships.Template.TemplateRequestBuilder Template
        {
            get => new global::Klaviyo.Api.FlowMessages.Item.Relationships.Template.TemplateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.FlowMessages.Item.Relationships.RelationshipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RelationshipsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/flow-messages/{id}/relationships", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.FlowMessages.Item.Relationships.RelationshipsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RelationshipsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api/flow-messages/{id}/relationships", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
