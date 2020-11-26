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
    public partial class Calificaciones_docente : Form
    {
        List<string> listIds = new List<string>();
        public Calificaciones_docente()
        {
            InitializeComponent();
        }

        private void buttonAceptarCal_Click(object sender, EventArgs e)
        {

            if (listIds.Contains(textBoxIDGrupoLista.Text))
            {
                DocenModel docenModel = new DocenModel();
                docenModel.subirCalificacion(textBoxIDGrupo.Text, textBoxIDAlumno.Text, textBoxCalificacion.Text);
            }
        }

        private void buttonConsultarLista_Click(object sender, EventArgs e)
        {
            if (listIds.Contains(textBoxIDGrupoLista.Text))
            {

                DocenModel docenModel = new DocenModel();
                DataTable tablaDatos;
                
                List<List<string>> dtG = docenModel.listaGrupos(textBoxIDGrupoLista.Text);
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
                    return;
                }
            }
        }

        private void Calificaciones_docente_Load(object sender, EventArgs e)
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
                dataGridViewListaGrupos.DataSource = tablaDatos;
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
    }
}
