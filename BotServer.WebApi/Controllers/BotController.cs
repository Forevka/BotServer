using System.Threading.Tasks;
using BotServer.Bll;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TdLib;
using Telegram.Td.Api;

namespace BotServer.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BotController : ControllerBase
    {
        private readonly ILogger<BotController> _logger;
        private readonly BotClient _botClient;

        public BotController(ILogger<BotController> logger, BotClient botClient)
        {
            _logger = logger;
            _botClient = botClient;
        }

        [HttpGet]
        public async Task<TdApi.User> Me()
        {
            var me = await _botClient.GetMe();
            return me;
        }
    }
}
