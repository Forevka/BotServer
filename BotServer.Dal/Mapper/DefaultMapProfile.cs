using AutoMapper;
using BotServer.Dal.Models.ViewModels;
using TdLib;

namespace BotServer.Dal.Mapper
{
    public class DefaultMapProfile : Profile
    {
        public DefaultMapProfile()
        {
            CreateMap<TdApi.UserFullInfo, UserFullInfoViewModel>();
        }
    }
}
