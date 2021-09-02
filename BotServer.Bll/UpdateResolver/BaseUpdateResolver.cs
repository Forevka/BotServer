using AutoMapper;

namespace BotServer.Bll.UpdateResolver
{
    public class BaseUpdateResolver
    {
        protected readonly BotClient Bot;// Create a field to store the mapper object
        protected readonly IMapper Mapper;

        public BaseUpdateResolver(BotClient bot, IMapper mapper)
        {
            Bot = bot;
            Mapper = mapper;
        }
    }
}
