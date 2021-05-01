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
        /// Returns t.me URLs recently visited by a newly registered user
        /// </summary>
        public class GetRecentlyVisitedTMeUrls : Function<TMeUrls>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getRecentlyVisitedTMeUrls";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Google Play referrer to identify the user
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("referrer")]
            public string Referrer { get; set; }
        }

        /// <summary>
        /// Returns t.me URLs recently visited by a newly registered user
        /// </summary>
        public static Task<TMeUrls> GetRecentlyVisitedTMeUrlsAsync(
            this Client client, string referrer = default)
        {
            return client.ExecuteAsync(new GetRecentlyVisitedTMeUrls
            {
                Referrer = referrer
            });
        }
    }
}