using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{
    public static class ServerDataHolder
    {
        public static Message message = new Message
        {
            FromClient = new ServerClient
            {
                Name = "ExampleName",
                Email = "example@gmail.com",
                Password = "123456"
            },
            Content = new MessageContent
            {
                Subject = ExampleMessHolder.GetSubject(),
                Body = ExampleMessHolder.GetMess(),
                AttachmentData = new List<Attachment>() { ExampleMessHolder.GetAttachment() },
                IsHtml = ExampleMessHolder.html
            },
            Server = ServerConfigurations.mailServer
        };

    }
}
