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
        /// Changes the username of a supergroup or channel, requires owner privileges in the supergroup or channel
        /// </summary>
        public class SetSupergroupUsername : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setSupergroupUsername";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the supergroup or channel
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("supergroup_id")]
            public int SupergroupId { get; set; }

            /// <summary>
            /// New value of the username. Use an empty string to remove the username
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("username")]
            public string Username { get; set; }
        }

        /// <summary>
        /// Changes the username of a supergroup or channel, requires owner privileges in the supergroup or channel
        /// </summary>
        public static Task<Ok> SetSupergroupUsernameAsync(
            this Client client, int supergroupId = default, string username = default)
        {
            return client.ExecuteAsync(new SetSupergroupUsername
            {
                SupergroupId = supergroupId, Username = username
            });
        }
    }
}