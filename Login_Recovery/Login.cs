using System;
using System.Drawing;
using System.Windows.Forms;
using Dominio;
using Common.Cache;
using Interfaces;

namespace Presentacion
{
    public partial class Form1 : Form
    {

        Form formNuevo;
        public Form1()
        {
            InitializeComponent();
        }


        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            /*
            labelBienvenido.Visible = false;
            labelUserName.Visible = false;
            labelUserLast.Visible = false;
            labelUserEmail.Visible = false;
            labelError.Visible = false;
            */

            textBoxUser.Clear();
            if (textBoxPass.Text != "CONTRASEÑA")
            {
                textBoxPass.UseSystemPasswordChar = false;
                textBoxPass.Text = "CONTRASEÑA";
            }


            if (textBoxUser.Text == "USUARIO")
            {
                textBoxUser.Text = "";
                textBoxUser.ForeColor = Color.White;
            }
        }

        private void textBoxUser_Leave(object sender, EventArgs e)
        {
            if(textBoxUser.Text=="")
            {
                textBoxUser.Text = "USUARIO";
                textBoxUser.ForeColor = Color.White;
            }
        }

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            /*
            labelBienvenido.Visible = false;
            labelUserName.Visible = false;
            labelUserLast.Visible = false;
            labelUserEmail.Visible = false;
            labelError.Visible = false;
            */

            if (textBoxPass.Text == "CONTRASEÑA")
            {
                textBoxPass.Text = "";
                textBoxPass.ForeColor = Color.White;
                textBoxPass.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "")
            {
                textBoxPass.Text = "CONTRASEÑA";
                textBoxPass.ForeColor = Color.White;
                textBoxPass.UseSystemPasswordChar = false;
            }
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (textBoxUser.Text != "USUARIO")
            {
                if (textBoxPass.Text != "CONTRASEÑA")
                {
                    UserModel user = new UserModel();
                    var validLog = user.LoginUser(textBoxUser.Text, textBoxPass.Text);
                    if (validLog == true)
                    {
                        if (user.onLoged() == true)
                        {
                            //user.onLoged();
                            if (UserLoginCache.Rol == "0")
                            {
                                formNuevo = new FormAdmin(this);
                            }
                            else if (UserLoginCache.Rol == "1")
                            {
                                formNuevo = new FormCoordinador(this);
                            }
                            else if (UserLoginCache.Rol == "2")
                            {
                                formNuevo = new FormDocente(this);
                            }
                            else
                            {
                                formNuevo = new FormAlumno(this);
                            }
                            textBoxUser.Text = "USUARIO";
                            textBoxPass.Text = "CONTRASEÑA";
                            checkBoxShowPass.Checked = false;
                            labelError.Visible = false;
                            textBoxPass.UseSystemPasswordChar = false;
                            Hide();
                            formNuevo.ShowDialog();
                            //MessageBox.Show(nombreMsg,"Bienvenido");
                        }
                        else
                        {
                            MessageBox.Show("ERROR AL INICIAR.\n\n\nPor favor vuelva intentelo más tarde", "ERROR");
                            this.Close();
                        }
                    }
                    else
                    {
                        msgError("Usuario y/o contraseña incorrectos.");
                        textBoxPass.Clear();
                        textBoxUser.Focus();
                    }
                }
                else
                    msgError("Por favor, ingresa contraseña.");
            }
            else
            {
                msgError("Por favor, ingresa nombre de usuario.");
                textBoxPass.UseSystemPasswordChar = true;
            }
        }
        private void msgError(string msg)
        {
            checkBoxShowPass.Checked = false;
            labelError.Text = "" + msg;
            labelError.Visible = true;

        }


        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(textBoxPass.UseSystemPasswordChar == true)
                textBoxPass.UseSystemPasswordChar = false;
            else
                textBoxPass.UseSystemPasswordChar = true;
        }

        private void linkLabelForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPassword = new FormRecoveryPassword();
            recoverPassword.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonLog_Click(sender, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void clearForm(Form f)
        {
            f.Dispose();
        }
    }
}
