using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.IO;

namespace EmailSender
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailSender emailSender = new EmailSender(ServerDataHolder.message);
           // emailSender.SendMail();
        }
    }
}
