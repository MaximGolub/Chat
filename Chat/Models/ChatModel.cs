using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat.Models
{
    public class ChatModel
    {
        public List<ChatUser> Users;  // все пользователи чата

        public List<ChatMessage> chatMessages; // все сообщения

        public ChatModel()
        {
            Users = new List<ChatUser>();
            chatMessages = new List<ChatMessage>();

            chatMessages.Add(new ChatMessage()
            {
                Text = "Чат запущен: " + DateTime.Now
            });
        }
    }

    public class ChatUser
    {
        public string Name;
        public DateTime LoginTime;
        public DateTime LastPing;
    }

    public class ChatMessage
    {
        // автор сообщения, если null - автор сервер
        public ChatUser User;
        // время сообщения
        public DateTime Date = DateTime.Now;
        // текст сообщения
        public string Text = "";
    }
}