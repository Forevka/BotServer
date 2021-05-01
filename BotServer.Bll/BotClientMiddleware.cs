using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;

namespace BotServer.Bll
{
    public class BotClientMiddleware
    {
        private readonly RequestDelegate _next;

        public BotClientMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, BotPool pool, BaseBotClient baseBotClient, BotClient botClient)
        {
            var token = context.Request.Headers.FirstOrDefault(x => x.Key == "Token").Value.ToString();
            if (!string.IsNullOrEmpty(token))
            {
                baseBotClient = BaseBotClient.FromToken(token);

                if (pool.IsCached(baseBotClient))
                {
                    baseBotClient = pool.GetCached(baseBotClient);
                }
                else
                {
                    baseBotClient.Start();
                    pool.Cache(baseBotClient);
                }

                botClient.SetBaseClient(baseBotClient);
            }

            await _next(context);
        }
    }
}
