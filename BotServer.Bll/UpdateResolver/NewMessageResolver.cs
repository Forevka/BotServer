using BotServer.Dal.Models.ViewModels;
using BotServer.Dal.Models.ViewModels.MessageContent;
using System.Linq;
using BotServer.Dal.Models;
using TdLib;

namespace BotServer.Bll.UpdateResolver
{
    public class NewMessageResolver : IUpdateResolver<NewMessage, TdApi.Update.UpdateNewMessage>, IUpdateResolver<BaseUpdate, TdApi.Update>
    {
        public NewMessage Resolve(TdApi.Update.UpdateNewMessage updateObject)
        {
            var entity = new NewMessage
            {
                AuthorSignature = updateObject.Message.AuthorSignature,
                CanBeDeletedForAllUsers = updateObject.Message.CanBeDeletedForAllUsers,
                CanBeDeletedOnlyForSelf = updateObject.Message.CanBeDeletedOnlyForSelf,
                CanBeEdited = updateObject.Message.CanBeEdited,
                CanBeForwarded = updateObject.Message.CanBeForwarded,
                CanGetMessageThread = updateObject.Message.CanGetMessageThread,
                CanGetStatistics = updateObject.Message.CanGetStatistics,
                ChatId = updateObject.Message.ChatId,
                ContainsUnreadMention = updateObject.Message.ContainsUnreadMention,
                Date = updateObject.Message.Date,
                EditDate = updateObject.Message.EditDate,
                Id = updateObject.Message.Id,
                IsChannelPost = updateObject.Message.IsChannelPost,
                IsOutgoing = updateObject.Message.IsOutgoing,
                IsPinned = updateObject.Message.IsPinned,
                MediaAlbumId = updateObject.Message.MediaAlbumId,
                MessageThreadId = updateObject.Message.MessageThreadId,
                ReplyInChatId = updateObject.Message.ReplyInChatId,
                ReplyToMessageId = updateObject.Message.ReplyToMessageId,
                RestrictionReason = updateObject.Message.RestrictionReason,
                ViaBotUserId = updateObject.Message.ViaBotUserId,
            };

            if (updateObject.Message.Content is TdApi.MessageContent.MessageText text)
            {
                var messageContent = new Text
                {
                    Data = text.Text.Text,
                    Entities = text.Text.Entities.ToList().Select(x => new Entity
                    {
                        Length = x.Length,
                        Offset = x.Offset,
                        Type = x.Type.DataType,
                    }).ToList(),
                };
                entity.Content = messageContent;
            }

            return entity;
        }

        public BaseUpdate Resolve(TdApi.Update updateObject)
        {
            return Resolve((TdApi.Update.UpdateNewMessage)updateObject);
        }
    }
}
