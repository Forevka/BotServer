using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        public partial class Update : Object
        {
            /// <summary>
            /// The list of suggested to the user actions has changed
            /// </summary>
            public class UpdateSuggestedActions : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateSuggestedActions";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Added suggested actions
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("added_actions")]
                public SuggestedAction[] AddedActions { get; set; }

                /// <summary>
                /// Removed suggested actions
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("removed_actions")]
                public SuggestedAction[] RemovedActions { get; set; }
            }
        }
    }
}