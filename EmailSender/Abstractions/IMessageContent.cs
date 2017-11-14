using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender.Abstractions
{
    public interface IMessageContent
    {
        string Subject { get; set; }
        string Body { get; set; }
        bool IsHtml { get; set; }
        List<Attachment> AttachmentData { get; set; }
    }
}
