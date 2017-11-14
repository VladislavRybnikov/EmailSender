using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{
    public static class ServerConfigurations
    {
        public static MailServer mailServer = new MailServer
        {
            Address = ConfigurationManager.AppSettings["gmailServer"],
            Port = Convert.ToInt32(ConfigurationManager.AppSettings["gmailPort"])
        };
    }
}
