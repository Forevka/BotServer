using BotServer.Dal.Models.ViewModels;
using BotServer.Dal.Models.ViewModels.MessageContent;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;

namespace BotServer.Dal.ExampleProviders
{
    public class TextMessageExampleProvider : IExamplesProvider<NewMessage>
    {
        public NewMessage GetExamples()
        {
            return new NewMessage()
            {
                Content = new Text
                {
                    Data = "Example message text",
                    Entities = new List<Entity>
                    {
                        new Entity
                        {
                            Length = 5,
                            Offset = 0,
                            Type = "Bold",
                        },
                    },
                },
                AuthorSignature = "Example signature",
                CanBeDeletedForAllUsers = false,
                CanBeDeletedOnlyForSelf = false,
                CanBeEdited = true,
                CanBeForwarded = false,
                CanGetMessageThread = false,
                CanGetStatistics = false,
                ChatId = 123,
                ContainsUnreadMention = false,
                Date = DateTimeOffset.Now.ToUnixTimeSeconds(),
                EditDate = DateTimeOffset.Now.ToUnixTimeSeconds(),
                Id = 1,
                IsChannelPost = false,
                IsOutgoing = false,
                IsPinned = false,
                MediaAlbumId = 0,
                MessageThreadId = 0,
                ReplyInChatId = 0,
                ReplyToMessageId = 0,
                ViaBotUserId = 0,
                RestrictionReason = "",
                UpdateId = 1,
            };
        }
    }
}
