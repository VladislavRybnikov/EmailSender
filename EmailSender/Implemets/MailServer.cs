using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailSender.Abstractions;

namespace EmailSender
{
    public class MailServer : IMailServer
    {
        public string Address { get; set; }
        public int Port { get; set; }
    }
}
