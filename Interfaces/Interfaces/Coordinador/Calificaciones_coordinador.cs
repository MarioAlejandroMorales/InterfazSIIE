using System;
using System.Collections.Generic;
using System.ComponentModel;
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
namespace Interfaces.Coordinador
{
    public partial class Calificaciones_coordinador : Form
    {
        List<string> listIds = new List<string>();
        public Calificaciones_coordinador()
        {
            InitializeComponent();
        }

        private void buttonConsultarLista_Click(object sender, EventArgs e)
        {
            DocenModel docenModel = new DocenModel();
            DataTable tablaDatos;
            string idG = textBoxIDGrupoLista.Text;
            List<List<string>> dtG = docenModel.listaGrupos(idG);
            if (dtG.Count() > 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                tablaDatos = new DataTable();
                tablaDatos.Columns.Add("Codigo");
                tablaDatos.Columns.Add("Nombre");
                dataGridViewListaAlumnos.DataSource = tablaDatos;
                foreach (List<string> grupo in dtG)
                {
                    DataRow fila = tablaDatos.NewRow();
                    fila["Codigo"] = grupo[0];
                    fila["Nombre"] = grupo[1];
                    tablaDatos.Rows.Add(fila);
                }
                dtG.Clear();
                dataGridViewListaAlumnos.Visible = true;
            }
            else
            {
                dataGridViewListaAlumnos.DataSource = null;
                dataGridViewListaAlumnos.Refresh();
                dataGridViewListaAlumnos.Visible=false;
                MessageBox.Show("No se ha encontrado ningún grupo con id: "+ idG+".", "Grupos");
            }
        }

        private void buttonAceptarCal_Click(object sender, EventArgs e)
        {

            if (listIds.Contains(textBoxIDGrupoLista.Text))
            {
                DocenModel docenModel = new DocenModel();
                docenModel.subirCalificacion(textBoxIDGrupo.Text, textBoxIDAlumno.Text, textBoxCalificacion.Text);
            }
        }
    }
}
