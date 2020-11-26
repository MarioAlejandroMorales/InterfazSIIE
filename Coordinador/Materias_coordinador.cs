using System;
using Dominio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class Materias_coordinador : Form
    {
        DataTable tablaDatos;
        public Materias_coordinador()
        {
            InitializeComponent();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            labelMensajeError.Visible = false;
            buttonAgregarCordinador.Visible = false;
            textBoxNombreEliminar.BackColor = (Color)System.Drawing.SystemColors.Control;
            panelRegistro.Visible = false;
            textBoxNombreEliminar.Visible = true;
            textBoxNombreEliminar.Enabled = false;
            panelBuscar.Visible = true;
            dtMat.Visible = false;
            label1.Text = "ELIMINAR MATERIA";
            buttonConsultaBuscar.Visible = false;
            buttonBuscarEliminar.Visible = true;
            label16.Visible = true;
            label18.Visible = true;
        }

        private void buttonAgregarCordinador_Click(object sender, EventArgs e)
        {
            CoordiModel coordiModel = new CoordiModel();
            string flag = coordiModel.agregarMateria(textBoxNombreMateria.Text);

            if (flag != "-1")
            {
                labelId.Visible = true;
                textBoxId.Text = flag;
                textBoxId.Visible = true;
            }
            else
            {
                labelMensajeError.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelId.Visible = false;
            textBoxId.Visible = false;
            labelMensajeError.Visible = false;
            panelRegistro.Visible = true;
            buttonAgregarCordinador.Visible = true;
            panelBuscar.Visible = false;
            panelBuscar.Visible = false;
            dtMat.Visible = false;

            textBoxNombreMateria.Text = null;

            label1.Text = "AGREGAR MATERIA";
        }

        private void buttonBusca_Click(object sender, EventArgs e)
        {
            labelMensajeError.Visible = false;
            buttonAgregarCordinador.Visible = false;
            panelRegistro.Visible = false;
            textBoxNombreEliminar.Visible = false;
            label18.Visible = false;
            panelBuscar.Visible = true;
            buttonConsultaBuscar.Visible = true;
            buttonBuscarEliminar.Visible = false;
            textBoxNombreEliminar.Visible = true;
            textBoxNombreEliminar.BackColor = (Color)System.Drawing.SystemColors.Window;
            textBoxNombreEliminar.Enabled = true;
            label1.Text = "BUSCAR MATERIA";
            label16.Visible = true;
            label18.Visible = true;
            dtMat.Visible = false;
        }

        private void buttonConsultaBuscar_Click(object sender, EventArgs e)
        {
            List<string> dtM;
            CoordiModel coordiModel = new CoordiModel();
            if(textBoxCodigoEliminar.Text!="")
                dtM =coordiModel.buscarMateria(textBoxCodigoEliminar.Text, 2);
            else
                dtM = coordiModel.buscarMateria(textBoxNombreEliminar.Text, 1);

            if (dtM.Count() > 0)
            {
                textBoxCodigoEliminar.Text = dtM[0];
                textBoxNombreEliminar.Text = dtM[1];
            }
            tablaDatos = new DataTable();
            tablaDatos.Columns.Add("id");
            tablaDatos.Columns.Add("Nombre");
            DataRow fila = tablaDatos.NewRow();
            fila["id"] = dtM[0];
            fila["Nombre"] = dtM[1];
            dtMat.Visible = true;
            dtMat.DataSource = tablaDatos;
            tablaDatos.Rows.Add(fila);
        }

        private void buttonBuscarEliminar_Click(object sender, EventArgs e)
        {
            CoordiModel coordiModel = new CoordiModel();

            if (textBoxCodigoEliminar.Text != "")
                if (!coordiModel.eliminarMateria(textBoxCodigoEliminar.Text))
                {
                    labelMensajeError.Text = "Ha ocurrido un fallo al eliminar la materia.";
                    labelMensajeError.Visible = true;
                }
                else
                    MessageBox.Show("Eliminado satisfactoriamente","Materia");
        }
    }
}
