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
        /// Accepts an incoming call
        /// </summary>
        public class AcceptCall : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "acceptCall";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Call identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("call_id")]
            public int CallId { get; set; }

            /// <summary>
            /// Description of the call protocols supported by the application
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("protocol")]
            public CallProtocol Protocol { get; set; }
        }

        /// <summary>
        /// Accepts an incoming call
        /// </summary>
        public static Task<Ok> AcceptCallAsync(
            this Client client, int callId = default, CallProtocol protocol = default)
        {
            return client.ExecuteAsync(new AcceptCall
            {
                CallId = callId, Protocol = protocol
            });
        }
    }
}