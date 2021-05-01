using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using BotServer.Dal.Enums;
using TdLib;

namespace BotServer.Bll
{

    public class BaseBotClient
    {
        private const int MaxStoredUpdatesCount = 1000;

        public ConcurrentDictionary<UpdateTypeEnum, long> LastUpdateId;
        public Dictionary<UpdateTypeEnum, SortedList<long, TdLib.TdApi.Update>> Updates;
        public string Token { get; set; }
        public TdClient Client { get; set; }

        private readonly AutoResetEvent _initialized = new AutoResetEvent(false);

        public string RawId => string.IsNullOrEmpty(Token) ? "0" : Token.Split(":", 2).First();
        public int Id => int.Parse(RawId);

        public void Start()
        {
            PresignUpdates();
            Client.Start();
            _initialized.WaitOne();
        }

        public static BaseBotClient FromToken(string token)
        {
            var tdClient = new TdClient();
            var bot = new BaseBotClient
            {
                Token = token,
                Client = tdClient,
            };

            tdClient.Bindings.SetLogVerbosityLevel(0);

            tdClient.UpdateReceived += async (sender, update) =>
            {
                switch (update)
                {
                    case TdApi.Update.UpdateOption option:
                        /*await tdClient.ExecuteAsync(new TdApi.SetOption
                        {
                            DataType = option.DataType,
                            Extra = option.Extra,
                            Name = option.Name,
                            Value = option.Value,
                        });*/
                        break;
                    case TdApi.Update.UpdateAuthorizationState updateAuthorizationState when updateAuthorizationState.AuthorizationState.GetType() == typeof(TdApi.AuthorizationState.AuthorizationStateWaitTdlibParameters):
                        Directory.CreateDirectory($"bots/{bot.RawId}");
                        await tdClient.ExecuteAsync(new TdApi.SetTdlibParameters
                        {
                            Parameters = new TdApi.TdlibParameters
                            {
                                ApiId = 94575,
                                ApiHash = "a3406de8d171bb422bb6ddf3bbd800e2",
                                ApplicationVersion = "1.3.0",
                                DeviceModel = "PC",
                                SystemLanguageCode = "en",
                                SystemVersion = "Win 10.0",
                                DatabaseDirectory = $"bots/{bot.RawId}",
                            }
                        });
                        bot._initialized.Set();
                        break;
                    case TdApi.Update.UpdateAuthorizationState updateAuthorizationState when updateAuthorizationState.AuthorizationState.GetType() == typeof(TdApi.AuthorizationState.AuthorizationStateWaitEncryptionKey):
                        await tdClient.ExecuteAsync(new TdApi.CheckDatabaseEncryptionKey());
                        break;
                    case TdApi.Update.UpdateAuthorizationState updateAuthorizationState when updateAuthorizationState.AuthorizationState.GetType() == typeof(TdApi.AuthorizationState.AuthorizationStateWaitPhoneNumber):
                        await tdClient.ExecuteAsync(new TdApi.CheckAuthenticationBotToken {Token = token});
                        break;
                    case TdApi.Update.UpdateUser updateUser:
                        break;
                    case TdApi.Update.UpdateConnectionState updateConnectionState when updateConnectionState.State.GetType() == typeof(TdApi.ConnectionState.ConnectionStateReady):
                        break;
                    case TdApi.Update.UpdateNewMessage newMessage:
                        if (bot.LastUpdateId.TryGetValue(UpdateTypeEnum.NewMessage, out var updateId))
                        {
                            if (bot.Updates[UpdateTypeEnum.NewMessage].Count > MaxStoredUpdatesCount)
                                bot.Updates[UpdateTypeEnum.NewMessage].RemoveAt(0);

                            bot.Updates[UpdateTypeEnum.NewMessage].Add(updateId, newMessage);
                            bot.LastUpdateId.TryUpdate(UpdateTypeEnum.NewMessage, updateId + 1, updateId);
                        }
                        break;
                    default:
                        ; // add a breakpoint here to see other events
                        break;
                }
            };

            return bot;
        }

        private void PresignUpdates()
        {
            /*
             * This needs to be moved into
             * database or smth like stateless store
             */
            LastUpdateId = new ConcurrentDictionary<UpdateTypeEnum, long>();
            LastUpdateId.TryAdd(UpdateTypeEnum.NewMessage, 0);

            Updates = new Dictionary<UpdateTypeEnum, SortedList<long, TdLib.TdApi.Update>>
            {
                {UpdateTypeEnum.NewMessage, new SortedList<long, TdLib.TdApi.Update>()}
            };
        }
    }
}
