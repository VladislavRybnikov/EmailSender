using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using EmailSender.Abstractions;

namespace EmailSender
{
    public class MessageContent : IMessageContent
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsHtml { get; set; }
        public List<Attachment> AttachmentData { get; set; }
        
    }
}
