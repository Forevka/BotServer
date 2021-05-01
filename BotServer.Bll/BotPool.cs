using System.Collections.Generic;

namespace BotServer.Bll
{
    public class BotPool
    {
        private readonly Dictionary<int, BaseBotClient> _cached = new Dictionary<int, BaseBotClient>();

        public void Cache(BaseBotClient botClient)
        {
            _cached.Add(botClient.Id, botClient);
        }

        public bool IsCached(BaseBotClient botClient)
        {
            return _cached.ContainsKey(botClient.Id);
        }

        public BaseBotClient GetCached(BaseBotClient botClient)
        {
            return _cached[botClient.Id];
        }
    }
}
