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
    public partial class Kardex : Form
    {
        DataTable tablaDatos;
        public Kardex()
        {
            InitializeComponent();
        }

        private void Kardex_Load(object sender, EventArgs e)
        {
            AlumnModel alumnModel = new AlumnModel();
            List<List<string>> dtG = alumnModel.getKardex(Common.Cache.UserLoginCache.IdUser);
            List<Label> data = new List<Label>();
            int cont = 0;

            if (dtG.Count() > 0)
            {
                tablaDatos = new DataTable();
                tablaDatos.Columns.Add("Materia");
                tablaDatos.Columns.Add("Docente");
                tablaDatos.Columns.Add("Calificación");
                dataGridViewKardex.DataSource = tablaDatos;
                foreach (List<string> grupo in dtG)
                {
                    DataRow fila = tablaDatos.NewRow();
                    fila["Materia"] = grupo[0];
                    fila["Docente"] = grupo[1];
                    fila["Calificación"] = grupo[2];
                    cont += 1;
                    tablaDatos.Rows.Add(fila);
                }
            }
            dtG.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
