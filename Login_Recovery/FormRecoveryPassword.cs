using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using AccesoDatos.MailServices;
using AccesoDatos;

namespace Presentacion
{
    public partial class FormRecoveryPassword : Form
    {
        public FormRecoveryPassword()
        {
            InitializeComponent();
        }

        private void buttonSendRequestRecover_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            UserDao userDao = new UserDao();
            var user = new UserModel();
            var result = user.recoverPassword(textBoxRecoverUserPassword.Text);
            SystemSupportMail email = new SystemSupportMail();
            List<String> em = new List<String>();
            List<string> dt = userDao.recoveryUserPass(textBoxRecoverUserPassword.Text);
            if (dt.Count > 0)
            {
                em.Add(textBoxRecoverUserPassword.Text);

                string bodyText = "Tu usuario es: " + dt[0] + "\nTu contraseña es: " + dt[1];
                email.sendMail("Recuperar", bodyText, em);
                labelResultRecovery.Visible = true;
                if (result == "0")
                    labelResultRecovery.Text = "Se han enviado tus datos de inicio de sesión\na tu contraseña.";
                else
                    labelResultRecovery.Text = "Ha ocurrido un error.";
            }
            else
                labelResultRecovery.Text = "Porfavor ingrese un correo valido.";
            labelResultRecovery.Visible = true;
            Cursor.Current = Cursors.Default;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose(true);
            this.Dispose();
            System.GC.Collect();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
