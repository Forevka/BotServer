using BotServer.Bll.UpdateResolver;
using BotServer.Dal.Enums;
using BotServer.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TdLib;

namespace BotServer.Bll
{
    public class BotClient
    {
        private BaseBotClient _client;

        private readonly Dictionary<UpdateTypeEnum, IUpdateResolver<BaseUpdate, TdApi.Update>> _updateResolvers;

        public BotClient()
        {
            _updateResolvers = new Dictionary<UpdateTypeEnum, IUpdateResolver<BaseUpdate, TdApi.Update>>
            {
                {UpdateTypeEnum.NewMessage, new NewMessageResolver()}
            };
        }

        public bool IsAuthorized => _client == null || _client.Id == 0;

        public void SetBaseClient(BaseBotClient baseBotClient)
        {
            _client = baseBotClient;
        }

        public async Task<TdApi.User> GetMe()
        {
            return await _client.Client.ExecuteAsync(new TdApi.GetMe());
        }

        public IEnumerable<object> GetUpdates(UpdateTypeEnum updateTypeEnum, long updateOffset)
        {
            IEnumerable<KeyValuePair<long, TdApi.Update>> updateStream;
            if (updateOffset < 0)
                updateStream = _client.Updates[updateTypeEnum].TakeLast((int) Math.Abs(updateOffset));
            else
                updateStream = _client.Updates[updateTypeEnum].Where(x => x.Key >= updateOffset);

            foreach (var (id, update) in updateStream)   
            {
                var resolved = _updateResolvers[updateTypeEnum].Resolve(update);
                resolved.UpdateId = id;

                yield return resolved;
            }
        }
    }
}
