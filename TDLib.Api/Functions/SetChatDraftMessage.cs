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
        /// Changes the draft message in a chat
        /// </summary>
        public class SetChatDraftMessage : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setChatDraftMessage";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// If not 0, a message thread identifier in which the draft was changed
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_thread_id")]
            public long MessageThreadId { get; set; }

            /// <summary>
            /// New draft message; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("draft_message")]
            public DraftMessage DraftMessage { get; set; }
        }

        /// <summary>
        /// Changes the draft message in a chat
        /// </summary>
        public static Task<Ok> SetChatDraftMessageAsync(
            this Client client, long chatId = default, long messageThreadId = default,
            DraftMessage draftMessage = default)
        {
            return client.ExecuteAsync(new SetChatDraftMessage
            {
                ChatId = chatId, MessageThreadId = messageThreadId, DraftMessage = draftMessage
            });
        }
    }
}