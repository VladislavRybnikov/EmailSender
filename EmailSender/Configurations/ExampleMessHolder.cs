using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{
    public static class ExampleMessHolder
    {
        public static string GetSubject()
        {
            string subject = "Регистрация";
            return subject;
        }

        public static bool html = true;

        public static string GetMess()
        {
            string html = "<html>" +
                "<body>" +
                "<img src = \"https://www.seodiesel.com/img/login/register.png\" align = \"center\" alt = \"РЕГИСТРАЦИЯ\"" +
                "<br>Дорогой клиент, Поздравляем!" +
                "<br>Вы успешно зарегистрированы!!!" +
                "<br>Ваш номер регистрации указан ниже" +
                "<br>" +
                "</body>" +
                "</html>";
            return html;
        }
        public static Attachment GetAttachment()
        {
            Attachment attachment = new Attachment(Directory.GetCurrentDirectory() + "\\uniqueNumber.txt");
            return attachment;
        }
    }
}
