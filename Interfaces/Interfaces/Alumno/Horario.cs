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
    public partial class Horario : Form
    {
        DataTable tablaDatos;
        public Horario()
        {
            InitializeComponent();
        }

        private void Horario_Load(object sender, EventArgs e)
        {
            AlumnModel alumnModel = new AlumnModel();
            List<List<string>> dtG = alumnModel.horarioAlumno(Common.Cache.UserLoginCache.IdUser);
            List<Label> data = new List<Label>();
            int cont = 0;

            if (dtG.Count() > 0)
            {
                tablaDatos = new DataTable();
                tablaDatos.Columns.Add("Materia");
                tablaDatos.Columns.Add("Aula");
                tablaDatos.Columns.Add("Hora entrada");
                tablaDatos.Columns.Add("Hora salida");
                tablaDatos.Columns.Add("Dias");
                dataGridView1.DataSource = tablaDatos;
                foreach (List<string> grupo in dtG)
                {
                    DataRow fila = tablaDatos.NewRow();
                    fila["Materia"] = grupo[2];
                    fila["Aula"] = grupo[4];
                    fila["Hora entrada"] = grupo[0];
                    fila["Hora salida"] = grupo[1];
                    fila["Dias"] = grupo[3];
                    cont += 1;
                    tablaDatos.Rows.Add(fila);
                }
            }
            dtG.Clear();
        }
    }
}
