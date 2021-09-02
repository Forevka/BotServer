using BotServer.Dal.Models.ViewModels.MessageContent;

namespace BotServer.Dal.Models.ViewModels
{
    public class NewMessage : BaseUpdate
    {
        /// <summary>
        /// Message identifier; unique for the chat to which the message belongs
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Chat identifier
        /// </summary>
        public long ChatId { get; set; }

        /// <summary>
        /// True, if the message is outgoing
        /// </summary>
        public bool IsOutgoing { get; set; }

        /// <summary>
        /// True, if the message is pinned
        /// </summary>
        public bool IsPinned { get; set; }

        /// <summary>
        /// True, if the message can be edited. For live location and poll messages this fields shows whether editMessageLiveLocation or stopPoll can be used with this message by the application
        /// </summary>
        public bool CanBeEdited { get; set; }

        /// <summary>
        /// True, if the message can be forwarded
        /// </summary>
        public bool CanBeForwarded { get; set; }

        /// <summary>
        /// True, if the message can be deleted only for the current user while other users will continue to see it
        /// </summary>
        public bool CanBeDeletedOnlyForSelf { get; set; }

        /// <summary>
        /// True, if the message can be deleted for all users
        /// </summary>
        public bool CanBeDeletedForAllUsers { get; set; }

        /// <summary>
        /// True, if the message statistics are available
        /// </summary>
        public bool CanGetStatistics { get; set; }

        /// <summary>
        /// True, if the message thread info is available
        /// </summary>
        public bool CanGetMessageThread { get; set; }

        /// <summary>
        /// True, if the message is a channel post. All messages to channels are channel posts, all other messages are not channel posts
        /// </summary>
        public bool IsChannelPost { get; set; }

        /// <summary>
        /// True, if the message contains an unread mention for the current user
        /// </summary>
        public bool ContainsUnreadMention { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) when the message was sent
        /// </summary>
        public long Date { get; set; }

        /// <summary>
        /// Point in time (Unix timestamp) when the message was last edited
        /// </summary>
        public long EditDate { get; set; }


        /// <summary>
        /// If non-zero, the identifier of the chat to which the replied message belongs; Currently, only messages in the Replies chat can have different reply_in_chat_id and chat_id
        /// </summary>
        public long ReplyInChatId { get; set; }

        /// <summary>
        /// If non-zero, the identifier of the message this message is replying to; can be the identifier of a deleted message
        /// </summary>
        public long ReplyToMessageId { get; set; }

        /// <summary>
        /// If non-zero, the identifier of the message thread the message belongs to; unique within the chat to which the message belongs
        /// </summary>
        public long MessageThreadId { get; set; }

        /// <summary>
        /// For self-destructing messages, the message's TTL (Time To Live), in seconds; 0 if none. TDLib will send updateDeleteMessages or updateMessageContent once the TTL expires
        /// </summary>
        public int Ttl { get; set; }

        /// <summary>
        /// Time left before the message expires, in seconds
        /// </summary>
        public double? TtlExpiresIn { get; set; }

        /// <summary>
        /// If non-zero, the user identifier of the bot through which this message was sent
        /// </summary>
        public int ViaBotUserId { get; set; }

        /// <summary>
        /// For channel posts and anonymous group messages, optional author signature
        /// </summary>
        public string AuthorSignature { get; set; }

        /// <summary>
        /// Unique identifier of an album this message belongs to. Only audios, documents, photos and videos can be grouped together in albums
        /// </summary>
        public long MediaAlbumId { get; set; }

        /// <summary>
        /// If non-empty, contains a human-readable description of the reason why access to this message must be restricted
        /// </summary>
        public string RestrictionReason { get; set; }

        /// <summary>
        /// Content of the message
        /// </summary>
        public BaseContent Content { get; set; }

        public UserFullInfoViewModel From { get; set; }
    }
}
