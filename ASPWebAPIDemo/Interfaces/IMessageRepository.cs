using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPWebAPIDemo.Models;

namespace ASPWebAPIDemo.Interfaces
{
    public interface IMessageRepository
    {
        IEnumerable<Message> Messages { get; }
        Message Find(int id);
        void Add(Message m);
    }
}
