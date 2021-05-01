namespace BotServer.Bll.UpdateResolver
{
    public interface IUpdateResolver<out TOut, in TUpdate>
    {
        TOut Resolve(TUpdate updateObject);
    }
}
