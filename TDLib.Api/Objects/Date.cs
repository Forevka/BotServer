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
        /// Represents a date according to the Gregorian calendar
        /// </summary>
        public partial class Date : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "date";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Day of the month, 1-31
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("day")]
            public int Day { get; set; }

            /// <summary>
            /// Month, 1-12
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("month")]
            public int Month { get; set; }

            /// <summary>
            /// Year, 1-9999
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("year")]
            public int Year { get; set; }
        }
    }
}