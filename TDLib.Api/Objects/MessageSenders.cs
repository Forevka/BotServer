using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Represents a list of message senders
        /// </summary>
        public partial class MessageSenders : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "messageSenders";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Approximate total count of messages senders found
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("total_count")]
            public int TotalCount { get; set; }

            /// <summary>
            /// List of message senders
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("senders")]
            public MessageSender[] Senders { get; set; }
        }
    }
}