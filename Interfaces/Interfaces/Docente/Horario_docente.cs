using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using AccesoDatos;
using Dominio;

namespace Interfaces
{
    public partial class Horario_docente : Form
    {
        List<string> listIds = new List<string>();
        public Horario_docente()
        {
            InitializeComponent();
            dataGridView2.Visible = false;
        }

        private void Horario_docente_Load(object sender, EventArgs e)
        {
            DataTable tablaDatos;
            DocenModel docenModel = new DocenModel();
            List<List<string>> dtG = docenModel.horarioDocente(Common.Cache.UserLoginCache.IdUser);
            List<Label> data = new List<Label>();
            int cont = 0;
            if (dtG.Count() > 0)
            {
                tablaDatos = new DataTable();
                tablaDatos.Columns.Add("ID");
                tablaDatos.Columns.Add("Materia");
                tablaDatos.Columns.Add("Aula");
                tablaDatos.Columns.Add("Hora entrada");
                tablaDatos.Columns.Add("Hora salida");
                tablaDatos.Columns.Add("Dias");
                dataGridView1.DataSource = tablaDatos;
                foreach (List<string> grupo in dtG)
                {
                    DataRow fila = tablaDatos.NewRow();
                    fila["ID"] = grupo[5];
                    fila["Materia"] = grupo[2];
                    fila["Aula"] = grupo[4];
                    fila["Hora entrada"] = grupo[0];
                    fila["Hora salida"] = grupo[1];
                    fila["Dias"] = grupo[3];
                    listIds.Add(grupo[5]);
                    cont += 1;
                    tablaDatos.Rows.Add(fila);
                }
                dtG.Clear();
            }
        }

        private void buttonListaAlumnos_Click(object sender, EventArgs e)
        {
            //Coordenadas 46, 76
            //Tamaño original 772, 384
            //Tamaño reducido 772, 118

            if (listIds.Contains(textBoxIDGrupoLista.Text)) {

                DocenModel docenModel = new DocenModel();
                DataTable tablaDatos;

                List<List<string>> dtG = docenModel.listaGrupos(textBoxIDGrupoLista.Text);
                if (dtG.Count() > 0)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    tablaDatos = new DataTable();
                    tablaDatos.Columns.Add("Codigo");
                    tablaDatos.Columns.Add("Nombre");
                    dataGridView2.DataSource = tablaDatos;
                    foreach (List<string> grupo in dtG)
                    {
                        DataRow fila = tablaDatos.NewRow();
                        fila["Codigo"] = grupo[0];
                        fila["Nombre"] = grupo[1];
                        tablaDatos.Rows.Add(fila);
                    }
                    dtG.Clear();
                    dataGridView2.Visible = true;
                    dataGridView1.Size = new Size(772, 118);
                }
                else
                {
                    return;
                }
            }
        }

        private void textBoxIDGrupoLista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonListaAlumnos_Click(sender, e);

        }
    }
}
