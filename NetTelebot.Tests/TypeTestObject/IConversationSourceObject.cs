﻿using Newtonsoft.Json.Linq;

namespace NetTelebot.Tests.TypeTestObject
{
    internal class IConversationSourceObject
    {
        protected IConversationSourceObject()
        {
        }

        /// <summary>
        /// This object represents objects with an implementation interface <see cref="IConversationSource" />.
        /// </summary>
        /// <param name="chatId">The chat identifier.</param>
        /// <param name="firstName">The first name.</param>
        /// <returns></returns>
        internal static JObject GetObject(int chatId, string firstName)
        {
            dynamic chat = new JObject();

            chat.id = chatId;
            chat.first_name = firstName;

            return chat;
        }
    }
}