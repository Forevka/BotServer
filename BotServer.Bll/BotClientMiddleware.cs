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

        // ReSharper disable once RedundantAssignment
        public async Task Invoke(HttpContext context, BotPool pool, BaseBotClient baseBotClient, BotClient botClient)
        {
            var token = context.Request.Headers.FirstOrDefault(x => x.Key == "Token").Value.ToString();
            if (!string.IsNullOrEmpty(token))
            {
                baseBotClient = BaseBotClient.FromToken(token);

                var isCached = pool.IsCached(baseBotClient);

                context.Response.Headers.Add("X-IS-FIRST-TIME", isCached.ToString());

                if (isCached)
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
            else
            {
                if (!context.Request.Path.Value.Contains("swagger"))
                {
                    context.Response.StatusCode = 401;
                    return;
                }
            }

            await _next(context);
        }
    }
}
