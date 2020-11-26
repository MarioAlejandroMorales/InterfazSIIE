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
    public partial class Registro_coordinador : Form
    {
        DataTable tablaDatos;
        public Registro_coordinador()
        {
            InitializeComponent();
        }
        private void Registro_Load(object sender, EventArgs e)
        {
            AdminModel adminModel = new AdminModel();
            List<List<string>> dtReg = adminModel.getReg();
            List<Label> data = new List<Label>();
            int cont = 0;

            if (dtReg.Count() > 0)
            {
                tablaDatos = new DataTable();
                tablaDatos.Columns.Add("Id usuario");
                tablaDatos.Columns.Add("Acción");
                tablaDatos.Columns.Add("Valor previo");
                tablaDatos.Columns.Add("Fecha - Hora");
                dataGridView1.DataSource = tablaDatos;

                foreach (List<string> reg in dtReg)
                {
                    DataRow fila = tablaDatos.NewRow();

                    fila["Id usuario"] = reg[0];
                    fila["Acción"] = reg[1];
                    fila["Valor previo"] = reg[2];
                    fila["Fecha - Hora"] = reg[3];
                    cont += 1;
                    tablaDatos.Rows.Add(fila);
                }
            }
            dtReg.Clear();
        }
    }
}
