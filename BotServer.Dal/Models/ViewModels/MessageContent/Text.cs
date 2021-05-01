using System.Collections.Generic;

namespace BotServer.Dal.Models.ViewModels.MessageContent
{
    public class Text : BaseContent
    {
        public List<Entity> Entities { get; set; }
    }
}
