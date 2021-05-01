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
        /// Represents a list of chats located nearby
        /// </summary>
        public partial class ChatsNearby : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chatsNearby";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// List of users nearby
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("users_nearby")]
            public ChatNearby[] UsersNearby { get; set; }

            /// <summary>
            /// List of location-based supergroups nearby
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("supergroups_nearby")]
            public ChatNearby[] SupergroupsNearby { get; set; }
        }
    }
}