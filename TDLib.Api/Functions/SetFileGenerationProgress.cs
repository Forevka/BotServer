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
        /// Informs TDLib on a file generation progress
        /// </summary>
        public class SetFileGenerationProgress : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setFileGenerationProgress";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The identifier of the generation process
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("generation_id")]
            public long GenerationId { get; set; }

            /// <summary>
            /// Expected size of the generated file, in bytes; 0 if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("expected_size")]
            public int ExpectedSize { get; set; }

            /// <summary>
            /// The number of bytes already generated
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("local_prefix_size")]
            public int LocalPrefixSize { get; set; }
        }

        /// <summary>
        /// Informs TDLib on a file generation progress
        /// </summary>
        public static Task<Ok> SetFileGenerationProgressAsync(
            this Client client, long generationId = default, int expectedSize = default, int localPrefixSize = default)
        {
            return client.ExecuteAsync(new SetFileGenerationProgress
            {
                GenerationId = generationId, ExpectedSize = expectedSize, LocalPrefixSize = localPrefixSize
            });
        }
    }
}