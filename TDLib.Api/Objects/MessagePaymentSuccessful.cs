using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class MessageContent : Object
        {
            /// <summary>
            /// A payment has been completed
            /// </summary>
            public class MessagePaymentSuccessful : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messagePaymentSuccessful";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of the message with the corresponding invoice; can be an identifier of a deleted message
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("invoice_message_id")]
                public long InvoiceMessageId { get; set; }

                /// <summary>
                /// Currency for the price of the product
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
            }
        }
    }
}