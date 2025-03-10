// <auto-generated/>
#pragma warning disable CS0618
using Klaviyo.Api.Accounts;
using Klaviyo.Api.BackInStockSubscriptions;
using Klaviyo.Api.CampaignClone;
using Klaviyo.Api.CampaignMessageAssignTemplate;
using Klaviyo.Api.CampaignMessages;
using Klaviyo.Api.CampaignRecipientEstimationJobs;
using Klaviyo.Api.CampaignRecipientEstimations;
using Klaviyo.Api.CampaignSendJobs;
using Klaviyo.Api.CampaignValuesReports;
using Klaviyo.Api.Campaigns;
using Klaviyo.Api.CatalogCategories;
using Klaviyo.Api.CatalogCategoryBulkCreateJobs;
using Klaviyo.Api.CatalogCategoryBulkDeleteJobs;
using Klaviyo.Api.CatalogCategoryBulkUpdateJobs;
using Klaviyo.Api.CatalogItemBulkCreateJobs;
using Klaviyo.Api.CatalogItemBulkDeleteJobs;
using Klaviyo.Api.CatalogItemBulkUpdateJobs;
using Klaviyo.Api.CatalogItems;
using Klaviyo.Api.CatalogVariantBulkCreateJobs;
using Klaviyo.Api.CatalogVariantBulkDeleteJobs;
using Klaviyo.Api.CatalogVariantBulkUpdateJobs;
using Klaviyo.Api.CatalogVariants;
using Klaviyo.Api.CouponCodeBulkCreateJobs;
using Klaviyo.Api.CouponCodes;
using Klaviyo.Api.Coupons;
using Klaviyo.Api.DataPrivacyDeletionJobs;
using Klaviyo.Api.EventBulkCreateJobs;
using Klaviyo.Api.Events;
using Klaviyo.Api.FlowActions;
using Klaviyo.Api.FlowMessages;
using Klaviyo.Api.FlowSeriesReports;
using Klaviyo.Api.FlowValuesReports;
using Klaviyo.Api.Flows;
using Klaviyo.Api.FormSeriesReports;
using Klaviyo.Api.FormValuesReports;
using Klaviyo.Api.FormVersions;
using Klaviyo.Api.Forms;
using Klaviyo.Api.ImageUpload;
using Klaviyo.Api.Images;
using Klaviyo.Api.Lists;
using Klaviyo.Api.MetricAggregates;
using Klaviyo.Api.MetricProperties;
using Klaviyo.Api.Metrics;
using Klaviyo.Api.ProfileBulkImportJobs;
using Klaviyo.Api.ProfileImport;
using Klaviyo.Api.ProfileMerge;
using Klaviyo.Api.ProfileSubscriptionBulkCreateJobs;
using Klaviyo.Api.ProfileSubscriptionBulkDeleteJobs;
using Klaviyo.Api.ProfileSuppressionBulkCreateJobs;
using Klaviyo.Api.ProfileSuppressionBulkDeleteJobs;
using Klaviyo.Api.Profiles;
using Klaviyo.Api.PushTokens;
using Klaviyo.Api.Reviews;
using Klaviyo.Api.SegmentSeriesReports;
using Klaviyo.Api.SegmentValuesReports;
using Klaviyo.Api.Segments;
using Klaviyo.Api.TagGroups;
using Klaviyo.Api.Tags;
using Klaviyo.Api.TemplateClone;
using Klaviyo.Api.TemplateRender;
using Klaviyo.Api.TemplateUniversalContent;
using Klaviyo.Api.Templates;
using Klaviyo.Api.TrackingSettings;
using Klaviyo.Api.WebhookTopics;
using Klaviyo.Api.Webhooks;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Klaviyo.Api
{
    /// <summary>
    /// Builds and executes requests for operations under \api
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ApiRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The accounts property</summary>
        public global::Klaviyo.Api.Accounts.AccountsRequestBuilder Accounts
        {
            get => new global::Klaviyo.Api.Accounts.AccountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The backInStockSubscriptions property</summary>
        public global::Klaviyo.Api.BackInStockSubscriptions.BackInStockSubscriptionsRequestBuilder BackInStockSubscriptions
        {
            get => new global::Klaviyo.Api.BackInStockSubscriptions.BackInStockSubscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The campaignClone property</summary>
        public global::Klaviyo.Api.CampaignClone.CampaignCloneRequestBuilder CampaignClone
        {
            get => new global::Klaviyo.Api.CampaignClone.CampaignCloneRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The campaignMessageAssignTemplate property</summary>
        public global::Klaviyo.Api.CampaignMessageAssignTemplate.CampaignMessageAssignTemplateRequestBuilder CampaignMessageAssignTemplate
        {
            get => new global::Klaviyo.Api.CampaignMessageAssignTemplate.CampaignMessageAssignTemplateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The campaignMessages property</summary>
        public global::Klaviyo.Api.CampaignMessages.CampaignMessagesRequestBuilder CampaignMessages
        {
            get => new global::Klaviyo.Api.CampaignMessages.CampaignMessagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The campaignRecipientEstimationJobs property</summary>
        public global::Klaviyo.Api.CampaignRecipientEstimationJobs.CampaignRecipientEstimationJobsRequestBuilder CampaignRecipientEstimationJobs
        {
            get => new global::Klaviyo.Api.CampaignRecipientEstimationJobs.CampaignRecipientEstimationJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The campaignRecipientEstimations property</summary>
        public global::Klaviyo.Api.CampaignRecipientEstimations.CampaignRecipientEstimationsRequestBuilder CampaignRecipientEstimations
        {
            get => new global::Klaviyo.Api.CampaignRecipientEstimations.CampaignRecipientEstimationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The campaigns property</summary>
        public global::Klaviyo.Api.Campaigns.CampaignsRequestBuilder Campaigns
        {
            get => new global::Klaviyo.Api.Campaigns.CampaignsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The campaignSendJobs property</summary>
        public global::Klaviyo.Api.CampaignSendJobs.CampaignSendJobsRequestBuilder CampaignSendJobs
        {
            get => new global::Klaviyo.Api.CampaignSendJobs.CampaignSendJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The campaignValuesReports property</summary>
        public global::Klaviyo.Api.CampaignValuesReports.CampaignValuesReportsRequestBuilder CampaignValuesReports
        {
            get => new global::Klaviyo.Api.CampaignValuesReports.CampaignValuesReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The catalogCategories property</summary>
        public global::Klaviyo.Api.CatalogCategories.CatalogCategoriesRequestBuilder CatalogCategories
        {
            get => new global::Klaviyo.Api.CatalogCategories.CatalogCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The catalogCategoryBulkCreateJobs property</summary>
        public global::Klaviyo.Api.CatalogCategoryBulkCreateJobs.CatalogCategoryBulkCreateJobsRequestBuilder CatalogCategoryBulkCreateJobs
        {
            get => new global::Klaviyo.Api.CatalogCategoryBulkCreateJobs.CatalogCategoryBulkCreateJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The catalogCategoryBulkDeleteJobs property</summary>
        public global::Klaviyo.Api.CatalogCategoryBulkDeleteJobs.CatalogCategoryBulkDeleteJobsRequestBuilder CatalogCategoryBulkDeleteJobs
        {
            get => new global::Klaviyo.Api.CatalogCategoryBulkDeleteJobs.CatalogCategoryBulkDeleteJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The catalogCategoryBulkUpdateJobs property</summary>
        public global::Klaviyo.Api.CatalogCategoryBulkUpdateJobs.CatalogCategoryBulkUpdateJobsRequestBuilder CatalogCategoryBulkUpdateJobs
        {
            get => new global::Klaviyo.Api.CatalogCategoryBulkUpdateJobs.CatalogCategoryBulkUpdateJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The catalogItemBulkCreateJobs property</summary>
        public global::Klaviyo.Api.CatalogItemBulkCreateJobs.CatalogItemBulkCreateJobsRequestBuilder CatalogItemBulkCreateJobs
        {
            get => new global::Klaviyo.Api.CatalogItemBulkCreateJobs.CatalogItemBulkCreateJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The catalogItemBulkDeleteJobs property</summary>
        public global::Klaviyo.Api.CatalogItemBulkDeleteJobs.CatalogItemBulkDeleteJobsRequestBuilder CatalogItemBulkDeleteJobs
        {
            get => new global::Klaviyo.Api.CatalogItemBulkDeleteJobs.CatalogItemBulkDeleteJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The catalogItemBulkUpdateJobs property</summary>
        public global::Klaviyo.Api.CatalogItemBulkUpdateJobs.CatalogItemBulkUpdateJobsRequestBuilder CatalogItemBulkUpdateJobs
        {
            get => new global::Klaviyo.Api.CatalogItemBulkUpdateJobs.CatalogItemBulkUpdateJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The catalogItems property</summary>
        public global::Klaviyo.Api.CatalogItems.CatalogItemsRequestBuilder CatalogItems
        {
            get => new global::Klaviyo.Api.CatalogItems.CatalogItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The catalogVariantBulkCreateJobs property</summary>
        public global::Klaviyo.Api.CatalogVariantBulkCreateJobs.CatalogVariantBulkCreateJobsRequestBuilder CatalogVariantBulkCreateJobs
        {
            get => new global::Klaviyo.Api.CatalogVariantBulkCreateJobs.CatalogVariantBulkCreateJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The catalogVariantBulkDeleteJobs property</summary>
        public global::Klaviyo.Api.CatalogVariantBulkDeleteJobs.CatalogVariantBulkDeleteJobsRequestBuilder CatalogVariantBulkDeleteJobs
        {
            get => new global::Klaviyo.Api.CatalogVariantBulkDeleteJobs.CatalogVariantBulkDeleteJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The catalogVariantBulkUpdateJobs property</summary>
        public global::Klaviyo.Api.CatalogVariantBulkUpdateJobs.CatalogVariantBulkUpdateJobsRequestBuilder CatalogVariantBulkUpdateJobs
        {
            get => new global::Klaviyo.Api.CatalogVariantBulkUpdateJobs.CatalogVariantBulkUpdateJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The catalogVariants property</summary>
        public global::Klaviyo.Api.CatalogVariants.CatalogVariantsRequestBuilder CatalogVariants
        {
            get => new global::Klaviyo.Api.CatalogVariants.CatalogVariantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The couponCodeBulkCreateJobs property</summary>
        public global::Klaviyo.Api.CouponCodeBulkCreateJobs.CouponCodeBulkCreateJobsRequestBuilder CouponCodeBulkCreateJobs
        {
            get => new global::Klaviyo.Api.CouponCodeBulkCreateJobs.CouponCodeBulkCreateJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The couponCodes property</summary>
        public global::Klaviyo.Api.CouponCodes.CouponCodesRequestBuilder CouponCodes
        {
            get => new global::Klaviyo.Api.CouponCodes.CouponCodesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The coupons property</summary>
        public global::Klaviyo.Api.Coupons.CouponsRequestBuilder Coupons
        {
            get => new global::Klaviyo.Api.Coupons.CouponsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The dataPrivacyDeletionJobs property</summary>
        public global::Klaviyo.Api.DataPrivacyDeletionJobs.DataPrivacyDeletionJobsRequestBuilder DataPrivacyDeletionJobs
        {
            get => new global::Klaviyo.Api.DataPrivacyDeletionJobs.DataPrivacyDeletionJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The eventBulkCreateJobs property</summary>
        public global::Klaviyo.Api.EventBulkCreateJobs.EventBulkCreateJobsRequestBuilder EventBulkCreateJobs
        {
            get => new global::Klaviyo.Api.EventBulkCreateJobs.EventBulkCreateJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The events property</summary>
        public global::Klaviyo.Api.Events.EventsRequestBuilder Events
        {
            get => new global::Klaviyo.Api.Events.EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The flowActions property</summary>
        public global::Klaviyo.Api.FlowActions.FlowActionsRequestBuilder FlowActions
        {
            get => new global::Klaviyo.Api.FlowActions.FlowActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The flowMessages property</summary>
        public global::Klaviyo.Api.FlowMessages.FlowMessagesRequestBuilder FlowMessages
        {
            get => new global::Klaviyo.Api.FlowMessages.FlowMessagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The flows property</summary>
        public global::Klaviyo.Api.Flows.FlowsRequestBuilder Flows
        {
            get => new global::Klaviyo.Api.Flows.FlowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The flowSeriesReports property</summary>
        public global::Klaviyo.Api.FlowSeriesReports.FlowSeriesReportsRequestBuilder FlowSeriesReports
        {
            get => new global::Klaviyo.Api.FlowSeriesReports.FlowSeriesReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The flowValuesReports property</summary>
        public global::Klaviyo.Api.FlowValuesReports.FlowValuesReportsRequestBuilder FlowValuesReports
        {
            get => new global::Klaviyo.Api.FlowValuesReports.FlowValuesReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The forms property</summary>
        public global::Klaviyo.Api.Forms.FormsRequestBuilder Forms
        {
            get => new global::Klaviyo.Api.Forms.FormsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The formSeriesReports property</summary>
        public global::Klaviyo.Api.FormSeriesReports.FormSeriesReportsRequestBuilder FormSeriesReports
        {
            get => new global::Klaviyo.Api.FormSeriesReports.FormSeriesReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The formValuesReports property</summary>
        public global::Klaviyo.Api.FormValuesReports.FormValuesReportsRequestBuilder FormValuesReports
        {
            get => new global::Klaviyo.Api.FormValuesReports.FormValuesReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The formVersions property</summary>
        public global::Klaviyo.Api.FormVersions.FormVersionsRequestBuilder FormVersions
        {
            get => new global::Klaviyo.Api.FormVersions.FormVersionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The images property</summary>
        public global::Klaviyo.Api.Images.ImagesRequestBuilder Images
        {
            get => new global::Klaviyo.Api.Images.ImagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The imageUpload property</summary>
        public global::Klaviyo.Api.ImageUpload.ImageUploadRequestBuilder ImageUpload
        {
            get => new global::Klaviyo.Api.ImageUpload.ImageUploadRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The lists property</summary>
        public global::Klaviyo.Api.Lists.ListsRequestBuilder Lists
        {
            get => new global::Klaviyo.Api.Lists.ListsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The metricAggregates property</summary>
        public global::Klaviyo.Api.MetricAggregates.MetricAggregatesRequestBuilder MetricAggregates
        {
            get => new global::Klaviyo.Api.MetricAggregates.MetricAggregatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The metricProperties property</summary>
        public global::Klaviyo.Api.MetricProperties.MetricPropertiesRequestBuilder MetricProperties
        {
            get => new global::Klaviyo.Api.MetricProperties.MetricPropertiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The metrics property</summary>
        public global::Klaviyo.Api.Metrics.MetricsRequestBuilder Metrics
        {
            get => new global::Klaviyo.Api.Metrics.MetricsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The profileBulkImportJobs property</summary>
        public global::Klaviyo.Api.ProfileBulkImportJobs.ProfileBulkImportJobsRequestBuilder ProfileBulkImportJobs
        {
            get => new global::Klaviyo.Api.ProfileBulkImportJobs.ProfileBulkImportJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The profileImport property</summary>
        public global::Klaviyo.Api.ProfileImport.ProfileImportRequestBuilder ProfileImport
        {
            get => new global::Klaviyo.Api.ProfileImport.ProfileImportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The profileMerge property</summary>
        public global::Klaviyo.Api.ProfileMerge.ProfileMergeRequestBuilder ProfileMerge
        {
            get => new global::Klaviyo.Api.ProfileMerge.ProfileMergeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The profiles property</summary>
        public global::Klaviyo.Api.Profiles.ProfilesRequestBuilder Profiles
        {
            get => new global::Klaviyo.Api.Profiles.ProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The profileSubscriptionBulkCreateJobs property</summary>
        public global::Klaviyo.Api.ProfileSubscriptionBulkCreateJobs.ProfileSubscriptionBulkCreateJobsRequestBuilder ProfileSubscriptionBulkCreateJobs
        {
            get => new global::Klaviyo.Api.ProfileSubscriptionBulkCreateJobs.ProfileSubscriptionBulkCreateJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The profileSubscriptionBulkDeleteJobs property</summary>
        public global::Klaviyo.Api.ProfileSubscriptionBulkDeleteJobs.ProfileSubscriptionBulkDeleteJobsRequestBuilder ProfileSubscriptionBulkDeleteJobs
        {
            get => new global::Klaviyo.Api.ProfileSubscriptionBulkDeleteJobs.ProfileSubscriptionBulkDeleteJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The profileSuppressionBulkCreateJobs property</summary>
        public global::Klaviyo.Api.ProfileSuppressionBulkCreateJobs.ProfileSuppressionBulkCreateJobsRequestBuilder ProfileSuppressionBulkCreateJobs
        {
            get => new global::Klaviyo.Api.ProfileSuppressionBulkCreateJobs.ProfileSuppressionBulkCreateJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The profileSuppressionBulkDeleteJobs property</summary>
        public global::Klaviyo.Api.ProfileSuppressionBulkDeleteJobs.ProfileSuppressionBulkDeleteJobsRequestBuilder ProfileSuppressionBulkDeleteJobs
        {
            get => new global::Klaviyo.Api.ProfileSuppressionBulkDeleteJobs.ProfileSuppressionBulkDeleteJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pushTokens property</summary>
        public global::Klaviyo.Api.PushTokens.PushTokensRequestBuilder PushTokens
        {
            get => new global::Klaviyo.Api.PushTokens.PushTokensRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The reviews property</summary>
        public global::Klaviyo.Api.Reviews.ReviewsRequestBuilder Reviews
        {
            get => new global::Klaviyo.Api.Reviews.ReviewsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The segments property</summary>
        public global::Klaviyo.Api.Segments.SegmentsRequestBuilder Segments
        {
            get => new global::Klaviyo.Api.Segments.SegmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The segmentSeriesReports property</summary>
        public global::Klaviyo.Api.SegmentSeriesReports.SegmentSeriesReportsRequestBuilder SegmentSeriesReports
        {
            get => new global::Klaviyo.Api.SegmentSeriesReports.SegmentSeriesReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The segmentValuesReports property</summary>
        public global::Klaviyo.Api.SegmentValuesReports.SegmentValuesReportsRequestBuilder SegmentValuesReports
        {
            get => new global::Klaviyo.Api.SegmentValuesReports.SegmentValuesReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tagGroups property</summary>
        public global::Klaviyo.Api.TagGroups.TagGroupsRequestBuilder TagGroups
        {
            get => new global::Klaviyo.Api.TagGroups.TagGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tags property</summary>
        public global::Klaviyo.Api.Tags.TagsRequestBuilder Tags
        {
            get => new global::Klaviyo.Api.Tags.TagsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The templateClone property</summary>
        public global::Klaviyo.Api.TemplateClone.TemplateCloneRequestBuilder TemplateClone
        {
            get => new global::Klaviyo.Api.TemplateClone.TemplateCloneRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The templateRender property</summary>
        public global::Klaviyo.Api.TemplateRender.TemplateRenderRequestBuilder TemplateRender
        {
            get => new global::Klaviyo.Api.TemplateRender.TemplateRenderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The templates property</summary>
        public global::Klaviyo.Api.Templates.TemplatesRequestBuilder Templates
        {
            get => new global::Klaviyo.Api.Templates.TemplatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The templateUniversalContent property</summary>
        public global::Klaviyo.Api.TemplateUniversalContent.TemplateUniversalContentRequestBuilder TemplateUniversalContent
        {
            get => new global::Klaviyo.Api.TemplateUniversalContent.TemplateUniversalContentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The trackingSettings property</summary>
        public global::Klaviyo.Api.TrackingSettings.TrackingSettingsRequestBuilder TrackingSettings
        {
            get => new global::Klaviyo.Api.TrackingSettings.TrackingSettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The webhooks property</summary>
        public global::Klaviyo.Api.Webhooks.WebhooksRequestBuilder Webhooks
        {
            get => new global::Klaviyo.Api.Webhooks.WebhooksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The webhookTopics property</summary>
        public global::Klaviyo.Api.WebhookTopics.WebhookTopicsRequestBuilder WebhookTopics
        {
            get => new global::Klaviyo.Api.WebhookTopics.WebhookTopicsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.ApiRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApiRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Api.ApiRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApiRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
