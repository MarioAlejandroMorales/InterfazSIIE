using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Dominio;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class Usuarios_admin : Form
    {
        DataTable tablaDatos;
        private int rol=0;
        public Usuarios_admin()
        {
            InitializeComponent();
            cmbBRol.Items.AddRange(new object[] {"Coordinador", "Docente", "Alumno"});
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = true;
            buttonAgregarCordinador.Visible = true;
            panelBuscar.Visible = false;
            panelBuscar.Visible = false;

            label1.Text = "AGREGAR USUARIO";
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            buttonAgregarCordinador.Visible = false;
            panelRegistro.Visible = false;
            panelBuscar.Visible = true;
            buttonConsultaBuscar.Visible = true;
            buttonBuscarEliminar.Visible = false;
            label1.Text = "BUSCAR USUARIO";
            label16.Visible = true;
            dtUser.Visible = false;

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            buttonAgregarCordinador.Visible = false;
            panelRegistro.Visible = false;
            panelBuscar.Visible = true;
            label1.Text = "ELIMINAR USUARIO";
            buttonConsultaBuscar.Visible = false;
            buttonBuscarEliminar.Visible = true;
            label16.Visible=true;
        }

        private void buttonAgregarCordinador_Click(object sender, EventArgs e)
        {
            //Cursor.Current = Cursors.WaitCursor;
            List<string> dtU = new List<string>();
            dtU.Add(textBoxNombre.Text);
            dtU.Add(textBoxApellido1.Text);
            dtU.Add(textBoxApellido2.Text);
            dtU.Add(textBoxCarrera.Text);
            dtU.Add(textBoxCorreo.Text);
            if (rol == 3)
            {
                dtU.Add(textBoxCiclo.Text);
            }
            AdminModel admModel = new AdminModel();
            admModel.addU(rol, dtU);
        }

        private void cmbBRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            rol = cmbBRol.SelectedIndex + 1;
            if (rol==1)
            {
                label6.Text = "Carrera";
                label6.Visible = true;
                textBoxCarrera.Visible = true;
                label13.Visible = false;
                textBoxCiclo.Visible = false;

            }
            else if (rol == 2)
            {
                label6.Text = "Academia";
                label6.Visible = true;
                textBoxCarrera.Visible = true;
                label13.Visible = false;
                textBoxCiclo.Visible = false;
            } 
            else
            {
                label6.Text = "Carrera";
                label6.Visible = true;
                textBoxCarrera.Visible = true;
                label13.Visible = true;
                textBoxCiclo.Visible = true;
            }
        }

        public string selectFill()
        {
            Cursor.Current = Cursors.WaitCursor;
            List<string> dtU = new List<string>();
            tablaDatos = new DataTable();
            tablaDatos.Columns.Add("id");
            tablaDatos.Columns.Add("Nombre");
            tablaDatos.Columns.Add("Apellido Paterno");
            tablaDatos.Columns.Add("Apellido Materno");
            tablaDatos.Columns.Add("Correo");
            dtUser.Visible = true;
            string cod = textBoxCodigoEliminar.Text;
            string nm, em;
            if (cod != "")
            {
                AdminModel admModel = new AdminModel();
                dtU = admModel.searchUser(cod, 1);
            }
            if (dtU.Count() > 0)
                if (dtU[0] != "")
                {
                    DataRow fila = tablaDatos.NewRow();
                    fila["Nombre"] = dtU[1];
                    fila["Apellido Paterno"] = dtU[2];
                    fila["Apellido Materno"] = dtU[3];
                    fila["Correo"] = dtU[4];


                    if (dtU[0] == "2")
                    {
                        tablaDatos.Columns.Add("Academia");
                        fila["Academia"] = dtU[5];
                    }
                    else
                    {
                        tablaDatos.Columns.Add("Carrera");

                        fila["Carrera"] = dtU[5];
                        if (dtU[0] == "3")
                        {
                            tablaDatos.Columns.Add("Admitido");
                            tablaDatos.Columns.Add("Ciclo");
                            fila["Admitido"] = dtU[6];
                            fila["Ciclo"] = dtU[7];
                        }
                    }

                    dtUser.DataSource = tablaDatos;
                    tablaDatos.Rows.Add(fila);
                    return dtU[0];
                }
            return "";
        }

        private void buttonConsultaBuscar_Click(object sender, EventArgs e)
        {
            selectFill();
        }

        private void buttonBuscarEliminar_Click(object sender, EventArgs e)
        {
            string rol = selectFill();
            string cod = textBoxCodigoEliminar.Text;
            string msg = "";
            if (rol != "")
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar a este usuario?", "Usuarios", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    AdminModel admModel = new AdminModel();
                    if (admModel.delU(cod, rol))
                        msg = "Usuario eliminado satisfactoriamente.";
                    else
                        msg = "Ha ocurrido un fallo al eliminar al usuario.";
                    dtUser.DataSource = null;
                    dtUser.Refresh();
                }
                else
                    return;
            }
            else
            {
                msg = "Usuario no encontrado";
                dtUser.Visible = false;
            }
            MessageBox.Show(msg, "Usuarios");
        }
    }
}
/*              DialogResult result = MessageBox.Show("Desea eliminar a este usuario?", "Usuarios", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    
                }
*/