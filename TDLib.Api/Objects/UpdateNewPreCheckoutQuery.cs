using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class Update : Object
        {
            /// <summary>
            /// A new incoming pre-checkout query; for bots only. Contains full information about a checkout
            /// </summary>
            public class UpdateNewPreCheckoutQuery : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateNewPreCheckoutQuery";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Unique query identifier
                /// </summary>
                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("id")]
                public long Id { get; set; }

                /// <summary>
                /// Identifier of the user who sent the query
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("sender_user_id")]
                public int SenderUserId { get; set; }

                /// <summary>
                /// Currency for the product price
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("currency")]
                public string Currency { get; set; }

                /// <summary>
                /// Total price for the product, in the minimal quantity of the currency
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("total_amount")]
                public long TotalAmount { get; set; }

                /// <summary>
                /// Invoice payload
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("invoice_payload")]
                public byte[] InvoicePayload { get; set; }

                /// <summary>
                /// Identifier of a shipping option chosen by the user; may be empty if not applicable
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("shipping_option_id")]
                public string ShippingOptionId { get; set; }

                /// <summary>
                /// Information about the order; may be null
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("order_info")]
                public OrderInfo OrderInfo { get; set; }
            }
        }
    }
}