using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.MailServices
{
    public class SystemSupportMail:MasterMailService
    {
        public SystemSupportMail()
        {
            senderMail = "escolarsiie@gmail.com";
            password = "123qweA.";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;

            initSmtpClient();
        }

    }
}
