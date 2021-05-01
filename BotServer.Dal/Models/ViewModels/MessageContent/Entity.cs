namespace BotServer.Dal.Models.ViewModels.MessageContent
{
    public class Entity
    {
        /// <summary>
        /// Offset of the entity, in UTF-16 code units
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// Length of the entity, in UTF-16 code units
        /// </summary>
        public int Length { get; set; }

        public string Type { get; set; }
    }
}
