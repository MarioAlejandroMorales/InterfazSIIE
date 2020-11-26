using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Common.Cache;

namespace Interfaces
{
    public partial class FormAlumno : System.Windows.Forms.Form
    {
        Form FormLogin;
        bool flag1 = true;
        public FormAlumno(Form _formLogin)
        {
            InitializeComponent();
            FormLogin = _formLogin;
            lblNombre.Text = UserLoginCache.FirstName+" " + UserLoginCache.LastName;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void botonSlides_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 193 && pictureBoxLogo.Location.X == 5)
            {
                pictureBoxLogo.Size = new Size(113, 77);
                pictureBoxLogo.Location = new Point(-27, 0);
                menuVertical.Width = 60;

            }
            else
            {
                menuVertical.Width = 193;
                pictureBoxLogo.Location = new Point(5, 0);
                pictureBoxLogo.Size = new Size(182, 91);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (flag1 == true)
            {
                this.WindowState = FormWindowState.Maximized;
                flag1 = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                flag1 = true;
            }

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelUpMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormInPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void botonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin.Show();
            UserLoginCache.resetCache();
            Dispose(true);
            this.Dispose();
            System.GC.Collect();
            Close();
        }

        private void buttonHorario_Click(object sender, EventArgs e)
        {
            //buttonHorario.Font = new Font("Microsoft Sans Serif",10,FontStyle.Bold);
            Cursor.Current = Cursors.WaitCursor;
            AbrirFormInPanel(new Horario());

        }

        private void botonKardex_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Kardex());
        }

        private void botonAgendar_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Agendar());
        }
    }
}
