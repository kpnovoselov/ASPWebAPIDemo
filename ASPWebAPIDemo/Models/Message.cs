using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using ASPWebAPIDemo.Parser;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ASPWebAPIDemo.Models
{
    public enum MessageFormat
    {
        PlainText,
        XML
    }

    
    public class Message
    {
        public Message()
        {
            Data = null;
        }
        public int ID { get; set; }
        public string Body { get; set; }
        public MessageFormat Format { get; set; }

        
        [IgnoreDataMember]
        public Document Data { get; set; }
    }
}
