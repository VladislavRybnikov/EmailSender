using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailSender.Abstractions;

namespace EmailSender
{
    public class Message : IMessage
    {
        public IServerClient FromClient { get; set; }
        public IClient ToClient { get; set; }
        public IMessageContent Content { get; set; }
        public IMailServer Server { get; set; }        
    }
}
