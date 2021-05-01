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
        /// Contains full information about a basic group
        /// </summary>
        public partial class BasicGroupFullInfo : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "basicGroupFullInfo";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Chat photo; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("photo")]
            public ChatPhoto Photo { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("description")]
            public string Description { get; set; }

            /// <summary>
            /// User identifier of the creator of the group; 0 if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("creator_user_id")]
            public int CreatorUserId { get; set; }

            /// <summary>
            /// Group members
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("members")]
            public ChatMember[] Members { get; set; }

            /// <summary>
            /// Invite link for this group; available only after it has been generated at least once and only for the group creator
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("invite_link")]
            public string InviteLink { get; set; }
        }
    }
}