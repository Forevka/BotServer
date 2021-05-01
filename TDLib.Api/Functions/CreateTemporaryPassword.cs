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
        /// Creates a new temporary password for processing payments
        /// </summary>
        public class CreateTemporaryPassword : Function<TemporaryPasswordState>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "createTemporaryPassword";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Persistent user password
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("password")]
            public string Password { get; set; }

            /// <summary>
            /// Time during which the temporary password will be valid, in seconds; should be between 60 and 86400
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("valid_for")]
            public int ValidFor { get; set; }
        }

        /// <summary>
        /// Creates a new temporary password for processing payments
        /// </summary>
        public static Task<TemporaryPasswordState> CreateTemporaryPasswordAsync(
            this Client client, string password = default, int validFor = default)
        {
            return client.ExecuteAsync(new CreateTemporaryPassword
            {
                Password = password, ValidFor = validFor
            });
        }
    }
}