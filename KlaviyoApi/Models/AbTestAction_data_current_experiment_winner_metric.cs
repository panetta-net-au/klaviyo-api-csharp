// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Klaviyo.Models
{
    /// <summary>The metric to use to determine the winner of the A/B test action.Note that this is different from the metrics used as a flow trigger.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum AbTestAction_data_current_experiment_winner_metric
    {
        [EnumMember(Value = "submission")]
        #pragma warning disable CS1591
        Submission,
        #pragma warning restore CS1591
        [EnumMember(Value = "unique-clicks")]
        #pragma warning disable CS1591
        UniqueClicks,
        #pragma warning restore CS1591
        [EnumMember(Value = "unique-opens")]
        #pragma warning disable CS1591
        UniqueOpens,
        #pragma warning restore CS1591
        [EnumMember(Value = "unique-placed-orders")]
        #pragma warning disable CS1591
        UniquePlacedOrders,
        #pragma warning restore CS1591
    }
}
