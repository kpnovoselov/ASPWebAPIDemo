using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPWebAPIDemo.Interfaces;
using ASPWebAPIDemo.Parser;
using Sprache;

namespace ASPWebAPIDemo.Models
{
    public class MessageRepository : IMessageRepository 
    {
        //private Dictionary<int, Message> _messageDictionary;
        private readonly List<Message> _messages;

        public MessageRepository()
        {
            _messages = new List<Message>
            {
                new Message
                {
                    ID = 1,
                    Body = "Body1",
                    Format = MessageFormat.PlainText
                },
                new Message
                {
                    ID = 2,
                    Body = "Body2",
                    Format = MessageFormat.PlainText
                },
                new Message
                {
                    ID = 3,
                    Body = "<node></node>",
                    Format = MessageFormat.XML,
                    Data =  XmlParser.Document.Parse("<node></node>")
                }
            };



        }   


      
        #region Implementation of IMessageRepository

        public IEnumerable<Message> Messages => _messages;
        public Message Find(int id)
        {
            foreach (var m in Messages)
            {
                if (m.ID == id)
                    return m;
            }

            return null;
        }

        public void Add(Message m)
        {
            m.ID = _messages.Count + 1;

            if (m.Format == MessageFormat.XML)
            {
                bool isOk = false;
                m.Data = XmlParser.TryParse(m.Body, out isOk);
            }

            _messages.Add(m);
        }

        #endregion
    }
}
