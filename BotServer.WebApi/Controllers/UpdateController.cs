using BotServer.Bll;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using BotServer.Dal.Enums;

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
        public List<object> Updates([Required][FromQuery(Name = "UpdateType")]UpdateTypeEnum updateTypeEnum, [Required]long updateOffset)
        {
            if (Enum.IsDefined(typeof(UpdateTypeEnum), updateTypeEnum))
                return _botClient.GetUpdates(updateTypeEnum, updateOffset).ToList();

            return new List<object>();
        }
    }
}
