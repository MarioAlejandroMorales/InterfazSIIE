using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace AccesoDatos.MailServices
{
    public abstract class MasterMailService
    {
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void initSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;

        }

        public void sendMail(string subjet, string body, List<string> recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(senderMail);
                foreach (string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subjet;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;

                smtpClient.Send(mailMessage);
            }
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
            catch (Exception ex) { }
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
            finally
            {
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
        }

    }
}
