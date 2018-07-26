using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPWebAPIDemo.Interfaces;
using ASPWebAPIDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPWebAPIDemo.Controllers
{

    [Route("api/[controller]")]
    public class MessagesController : Controller
    {
        private readonly IMessageRepository _messageRepository;

        public MessagesController(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Message> Get()
        {
            return _messageRepository.Messages;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Message Get(int id)
        {
            return _messageRepository.Find(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Message value)
        {
            _messageRepository.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Message value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
