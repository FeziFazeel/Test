using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace ForgetPass
{
    public class Email
    {
        string smtpServer = "smtp.gmail.com";
        int port = 587;
        string FromEmail = "heartzkiller786@gmail.com";

        public void SendEmail(String ToEmail, String Subject, string Body)
        {
            try
            {
                MailMessage MM = new MailMessage();

                MM.To.Add(ToEmail);
                // MM.Attachments.Add(new Attachment(AppDomain.CurrentDomain.BaseDirectory + "Documents/PP/abc.jpg"));
                MM.From = new MailAddress(this.FromEmail);
                MM.Subject = Subject;
                MM.Body = Body;
                SmtpClient smpt = new SmtpClient(this.smtpServer, this.port);
                smpt.Credentials = new System.Net.NetworkCredential(this.FromEmail, "we may say");
                smpt.EnableSsl = true;
                smpt.Send(MM);
            }

            catch (Exception ex)
            { }
        }

    }
}
