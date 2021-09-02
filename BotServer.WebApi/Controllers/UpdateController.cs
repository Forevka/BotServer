using BotServer.Bll;
using BotServer.Dal.Enums;
using BotServer.Dal.Models;
using BotServer.Dal.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BotServer.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UpdateController : ControllerBase
    {
        private readonly ILogger<UpdateController> _logger;
        private readonly BotClient _botClient;

        public UpdateController(ILogger<UpdateController> logger, BotClient botClient)
        {
            _logger = logger;
            _botClient = botClient;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<NewMessage>), 200)]
        public async Task<List<BaseUpdate>> Updates([Required][FromQuery(Name = "UpdateType")]UpdateTypeEnum updateTypeEnum, [Required]long updateOffset)
        {
            if (!Enum.IsDefined(typeof(UpdateTypeEnum), updateTypeEnum)) 
                return new List<BaseUpdate>();

            var updates = await _botClient.GetUpdates(updateTypeEnum, updateOffset);
            return updates.ToList();
        }
    }
}
