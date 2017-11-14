using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender.Abstractions
{
    public interface IMessage
    {
        IServerClient FromClient { get; set; }
        IClient ToClient { get; set; }
        IMessageContent Content { get; set; }
        IMailServer Server { get; set; }
    }
}
