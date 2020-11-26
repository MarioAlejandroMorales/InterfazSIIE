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

namespace Interfaces
{
    public partial class Alumnos_coordinador : Form
    {
        DataTable tablaDatos;
        private int rol = 0;
        private string id;
        public Alumnos_coordinador()
        {
            InitializeComponent();
            cmbBRol.Items.AddRange(new object[] { "Alumno", "Docente" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelMensajeError.Visible = false;
            panelRegistro.Visible = true;
            buttonAgregarCordinador.Visible = true;
            panelBuscar.Visible = false;
            panelBuscar.Visible = false;
            dtUser.Visible = false;

            textBoxNombre.Text = null;
            textBoxApellido1.Text = null;
            textBoxApellido2.Text = null;
            textBoxCorreo.Text = null;
            cmbBRol = null;

            label1.Text = "AGREGAR USUARIO";
        }

        private void buttonBusca_Click(object sender, EventArgs e)
        {
            labelMensajeError.Visible = false;
            buttonAgregarCordinador.Visible = false;
            panelRegistro.Visible = false;
            textBoxNombreEliminar.Visible = false;
            textBoxCorreoEliminar.Visible = false;
            label18.Visible = false;
            label14.Visible = false;
            panelBuscar.Visible = true;
            buttonConsultaBuscar.Visible = true;
            buttonBuscarEliminar.Enabled = false;
            buttonBuscarEliminar.Visible = true;
            label1.Text = "BUSCAR USUARIO";
            label16.Visible = true;
            dtUser.Visible = false;
        }

        private void buttonAgregarCordinador_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            labelMensajeError.Visible = false;

            if (textBoxNombre.Text!=null && textBoxApellido1.Text!=null && textBoxApellido2.Text != null && textBoxCorreo.Text != null && textBoxApellido1.Text != null && cmbBRol != null)
            {
                List<string> dtU = new List<string>();
                dtU.Add(textBoxNombre.Text);
                dtU.Add(textBoxApellido1.Text);
                dtU.Add(textBoxApellido2.Text);
                dtU.Add(textBoxCarrera.Text);
                dtU.Add(textBoxCorreo.Text);
                if (rol == 1)
                {
                    dtU.Add(textBoxCiclo.Text);
                    rol = 3;

                    MessageBox.Show("Usuario agregado corretamente", "Usuario");
                }
                AdminModel admModel = new AdminModel();
                admModel.addU(rol, dtU);

                textBoxNombre.Text = null;
                textBoxApellido1.Text = null;
                textBoxApellido2.Text = null;
                textBoxCorreo.Text = null;
                cmbBRol = null;
            }
            else
            {
                labelMensajeError.Visible = true;
                labelMensajeError.Text = "Por favor ingrese todos los datos";
                //MessageBox.Show("Por favor ingrese todos los datos", "Error");
                textBoxNombre.Text = null;
                textBoxApellido1.Text = null;
                textBoxApellido2.Text = null;
                textBoxCorreo.Text = null;
                cmbBRol = null;
            }

        }

        private void cmbBRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            rol = cmbBRol.SelectedIndex + 1;
            if (rol == 1)
            {
                label6.Text = "Carrera";
                label6.Visible = true;
                textBoxCarrera.Visible = true;
                label13.Visible = true;
                textBoxCiclo.Visible = true;

            }
            else if(rol == 2)
            {
                label6.Text = "Academia";
                label6.Visible = true;
                textBoxCarrera.Visible = true;
                label13.Visible = false;
                textBoxCiclo.Visible = false;
            }
        }

        private void buttonConsultaBuscar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            List<string> dtU = new List<string>();
            tablaDatos = new DataTable();
            tablaDatos.Columns.Add("Nombre");
            tablaDatos.Columns.Add("Apellido Paterno");
            tablaDatos.Columns.Add("Apellido Materno");
            tablaDatos.Columns.Add("Situación");
            tablaDatos.Columns.Add("Correo");
            dtUser.Visible = true;
            string cod = textBoxCodigoEliminar.Text;
            string nm, em;
            if (cod != "")
            {
                AdminModel admModel = new AdminModel();
                dtU = admModel.searchUser(cod, 1);
            }
            else
            {
                nm = textBoxNombreEliminar.Text;
                em = textBoxCorreoEliminar.Text;
            }
            if (dtU.Count() > 0)
                if (dtU[0] != "")
                {
                    DataRow fila = tablaDatos.NewRow();
                    fila["Nombre"] = dtU[1];
                    fila["Apellido Paterno"] = dtU[2];
                    fila["Apellido Materno"] = dtU[3];
                    fila["Correo"] = dtU[4];
                    fila["Situación"] = dtU[8]; 


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
                    buttonBuscarEliminar.Enabled = true;
                    id = cod;
                }
        }

        private void buttonBuscarEliminar_Click(object sender, EventArgs e)
        {
            CoordiModel coordiModel = new CoordiModel();
            if (coordiModel.bajaAlumno(id))
            {

            }
        }
    }
}
