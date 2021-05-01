using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Sends the result of an inline query as a message. Returns the sent message. Always clears a chat draft message
        /// </summary>
        public class SendInlineQueryResultMessage : Function<Message>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "sendInlineQueryResultMessage";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Target chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// If not 0, a message thread identifier in which the message will be sent
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_thread_id")]
            public long MessageThreadId { get; set; }

            /// <summary>
            /// Identifier of a message to reply to or 0
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("reply_to_message_id")]
            public long ReplyToMessageId { get; set; }

            /// <summary>
            /// Options to be used to send the message
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("options")]
            public MessageSendOptions Options { get; set; }

            /// <summary>
            /// Identifier of the inline query
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("query_id")]
            public long QueryId { get; set; }

            /// <summary>
            /// Identifier of the inline result
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("result_id")]
            public string ResultId { get; set; }

            /// <summary>
            /// If true, there will be no mention of a bot, via which the message is sent. Can be used only for bots GetOption("animation_search_bot_username"), GetOption("photo_search_bot_username") and GetOption("venue_search_bot_username")
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("hide_via_bot")]
            public bool HideViaBot { get; set; }
        }

        /// <summary>
        /// Sends the result of an inline query as a message. Returns the sent message. Always clears a chat draft message
        /// </summary>
        public static Task<Message> SendInlineQueryResultMessageAsync(
            this Client client, long chatId = default, long messageThreadId = default, long replyToMessageId = default,
            MessageSendOptions options = default, long queryId = default, string resultId = default,
            bool hideViaBot = default)
        {
            return client.ExecuteAsync(new SendInlineQueryResultMessage
            {
                ChatId = chatId, MessageThreadId = messageThreadId, ReplyToMessageId = replyToMessageId,
                Options = options, QueryId = queryId, ResultId = resultId, HideViaBot = hideViaBot
            });
        }
    }
}