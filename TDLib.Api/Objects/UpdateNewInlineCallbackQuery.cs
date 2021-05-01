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
            /// A new incoming callback query from a message sent via a bot; for bots only
            /// </summary>
            public class UpdateNewInlineCallbackQuery : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateNewInlineCallbackQuery";

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
                /// Identifier of the inline message, from which the query originated
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("inline_message_id")]
                public string InlineMessageId { get; set; }

                /// <summary>
                /// An identifier uniquely corresponding to the chat a message was sent to
                /// </summary>
                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("chat_instance")]
                public long ChatInstance { get; set; }

                /// <summary>
                /// Query payload
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("payload")]
                public CallbackQueryPayload Payload { get; set; }
            }
        }
    }
}