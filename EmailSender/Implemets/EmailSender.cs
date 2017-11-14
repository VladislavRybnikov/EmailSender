using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using EmailSender.Abstractions;
using Logger.Implements;


namespace EmailSender 
{
    public class EmailSender : IEmailSender
    {
        private IMessage _message;
        

        public EmailSender(IMessage message)
        {
            _message = message;

        }
        public void SendMail()
        {
            using (MailMessage mail = new MailMessage(_message.FromClient.Email, _message.ToClient.Email))
            {
                mail.Subject = _message.Content.Subject;
                mail.Body = _message.Content.Body;
                if (_message.Content.AttachmentData.Count > 0)
                {
                    foreach (var attachment in _message.Content.AttachmentData)
                        mail.Attachments.Add(attachment);
                }
                if (_message.Content.IsHtml == true)
                {
                    mail.IsBodyHtml = true;
                }
                using (SmtpClient smtp = new SmtpClient(_message.Server.Address, _message.Server.Port))
                {
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                    smtp.Credentials = new NetworkCredential(_message.FromClient.Email, _message.FromClient.Password);
                    try
                    {
                        smtp.Send(mail);
                    }
                    catch (Exception ex)
                    {
                        new LogWriter(ex);
                    }

                }
            }
        }
    }
        
    
}
