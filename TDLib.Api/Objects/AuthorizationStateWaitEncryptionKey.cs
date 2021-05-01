using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class AuthorizationState : Object
        {
            /// <summary>
            /// TDLib needs an encryption key to decrypt the local database
            /// </summary>
            public class AuthorizationStateWaitEncryptionKey : AuthorizationState
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "authorizationStateWaitEncryptionKey";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// True, if the database is currently encrypted
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_encrypted")]
                public bool IsEncrypted { get; set; }
            }
        }
    }
}