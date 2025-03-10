// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Klaviyo.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class PredictiveAnalytics : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Average number of days between orders (None if only one order has been placed)</summary>
        public double? AverageDaysBetweenOrders { get; set; }
        /// <summary>Average value of placed orders</summary>
        public double? AverageOrderValue { get; set; }
        /// <summary>Probability the customer has churned</summary>
        public double? ChurnProbability { get; set; }
        /// <summary>Expected date of next order, as calculated at the time of their most recent order</summary>
        public DateTimeOffset? ExpectedDateOfNextOrder { get; set; }
        /// <summary>Total value of all historically placed orders</summary>
        public double? HistoricClv { get; set; }
        /// <summary>Number of already placed orders</summary>
        public double? HistoricNumberOfOrders { get; set; }
        /// <summary>Predicted value of all placed orders in the next 365 days</summary>
        public double? PredictedClv { get; set; }
        /// <summary>Predicted number of placed orders in the next 365 days</summary>
        public double? PredictedNumberOfOrders { get; set; }
        /// <summary>Sum of historic and predicted CLV</summary>
        public double? TotalClv { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Klaviyo.Models.PredictiveAnalytics"/> and sets the default values.
        /// </summary>
        public PredictiveAnalytics()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Klaviyo.Models.PredictiveAnalytics"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Klaviyo.Models.PredictiveAnalytics CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Klaviyo.Models.PredictiveAnalytics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "average_days_between_orders", n => { AverageDaysBetweenOrders = n.GetDoubleValue(); } },
                { "average_order_value", n => { AverageOrderValue = n.GetDoubleValue(); } },
                { "churn_probability", n => { ChurnProbability = n.GetDoubleValue(); } },
                { "expected_date_of_next_order", n => { ExpectedDateOfNextOrder = n.GetDateTimeOffsetValue(); } },
                { "historic_clv", n => { HistoricClv = n.GetDoubleValue(); } },
                { "historic_number_of_orders", n => { HistoricNumberOfOrders = n.GetDoubleValue(); } },
                { "predicted_clv", n => { PredictedClv = n.GetDoubleValue(); } },
                { "predicted_number_of_orders", n => { PredictedNumberOfOrders = n.GetDoubleValue(); } },
                { "total_clv", n => { TotalClv = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("average_days_between_orders", AverageDaysBetweenOrders);
            writer.WriteDoubleValue("average_order_value", AverageOrderValue);
            writer.WriteDoubleValue("churn_probability", ChurnProbability);
            writer.WriteDateTimeOffsetValue("expected_date_of_next_order", ExpectedDateOfNextOrder);
            writer.WriteDoubleValue("historic_clv", HistoricClv);
            writer.WriteDoubleValue("historic_number_of_orders", HistoricNumberOfOrders);
            writer.WriteDoubleValue("predicted_clv", PredictedClv);
            writer.WriteDoubleValue("predicted_number_of_orders", PredictedNumberOfOrders);
            writer.WriteDoubleValue("total_clv", TotalClv);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
