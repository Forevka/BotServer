using System.Threading.Tasks;

namespace BotServer.Bll.UpdateResolver
{
    public interface IUpdateResolver<TOut, in TUpdate>
    {
        Task<TOut> Resolve(TUpdate updateObject);
    }
}
