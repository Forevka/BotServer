using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class PushMessageContent : Object
        {
            /// <summary>
            /// A message with an invoice from a bot
            /// </summary>
            public class PushMessageContentInvoice : PushMessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pushMessageContentInvoice";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Product price
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("price")]
                public string Price { get; set; }

                /// <summary>
                /// True, if the message is a pinned message with the specified content
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_pinned")]
                public bool IsPinned { get; set; }
            }
        }
    }
}