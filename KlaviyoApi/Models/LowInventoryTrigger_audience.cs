// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Klaviyo.Models
{
    /// <summary>The profiles which the low inventory trigger applies to.We check profiles to see if they have these kinds of events. If theydo have them, then they are considered for the audience.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum LowInventoryTrigger_audience
    {
        [EnumMember(Value = "added-to-cart")]
        #pragma warning disable CS1591
        AddedToCart,
        #pragma warning restore CS1591
        [EnumMember(Value = "checkout-started")]
        #pragma warning disable CS1591
        CheckoutStarted,
        #pragma warning restore CS1591
        [EnumMember(Value = "viewed")]
        #pragma warning disable CS1591
        Viewed,
        #pragma warning restore CS1591
    }
}
