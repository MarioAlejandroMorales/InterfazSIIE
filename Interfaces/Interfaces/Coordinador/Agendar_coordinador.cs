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

namespace Interfaces.Coordinador
{
    public partial class Agendar_coordinador : Form
    {
        DataTable tablaDatos;
        public Agendar_coordinador()
        {
            InitializeComponent();
            panel3.Visible = false;
            panel4.Visible = false;
        }
        private void grupos(string idMateria)
        {

            AlumnModel alumnModel = new AlumnModel();
            List<List<string>> dtG = alumnModel.getGrupos(idMateria);
            List<Label> data = new List<Label>();
            int cont = 0;

            if (dtG.Count() > 0)
            {
                tablaDatos = new DataTable();
                tablaDatos.Columns.Add("Codigo");
                tablaDatos.Columns.Add("Docente");
                tablaDatos.Columns.Add("Materia");
                tablaDatos.Columns.Add("Aula");
                tablaDatos.Columns.Add("Hora entrada");
                tablaDatos.Columns.Add("Hora salida");
                tablaDatos.Columns.Add("Dias");
                tablaDatos.Columns.Add("Cupos disponibles");
                dataGridView1.DataSource = tablaDatos;
                foreach (List<string> grupo in dtG)
                {
                    DataRow fila = tablaDatos.NewRow();
                    fila["Codigo"] = grupo[0];
                    fila["Docente"] = grupo[1];
                    fila["Hora entrada"] = grupo[2];
                    fila["Hora salida"] = grupo[3];
                    fila["Materia"] = grupo[4];
                    fila["Dias"] = grupo[5];
                    fila["Aula"] = grupo[6];
                    fila["Cupos disponibles"] = (int.Parse(grupo[8]) - int.Parse(grupo[7])).ToString();
                    cont += 1;
                    tablaDatos.Rows.Add(fila);
                }
            }
            dtG.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CoordiModel coordiModel = new CoordiModel();
            string msg = "";
            if(coordiModel.addMateria(textBoxGrupo.Text, textBoxAlumn.Text))msg=
                msg = "Se ha agendado satisfactoriamente.";
            else
                msg = "Ha ocurrido un fallo al agendar.";
            MessageBox.Show(msg, "Alumnos");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grupos(textBoxMateria.Text);
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CoordiModel coordiModel = new CoordiModel();
            string msg = "";
            if (coordiModel.removeMateria(textBoxGrupoBaja.Text, textBoxAlumno.Text))
                msg = "La materia ha sido dadad de baja satisfactoriamente.";
            else
                msg = "Ha ocurrido un fallo al dar de baja.";
            MessageBox.Show(msg, "Alumnos");
        }
    }
}
