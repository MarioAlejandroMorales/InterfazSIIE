using System;
using System.Collections.Generic;
using Dominio;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class Grupos_coordinador : Form
    {
        List<CheckBox> liC = new List<CheckBox>();
        string id = "";
        private void clearAll()
        {
            textBoxDocente.Text = "ID";
            textBoxMateria.Text = "ID";
            textBoxId.Text = "ID";
            dateTimePickerEntrada.Value = Convert.ToDateTime("00:00:00");
            dateTimePickerSalida.Value = Convert.ToDateTime("00:00:00");
            textBoxAula.Text = null;
            checkBoxL.Checked = false;
            checkBoxM.Checked = false;
            checkBoxI.Checked = false;
            checkBoxJ.Checked = false;
            checkBoxV.Checked = false;
            labelMensajeError.Visible = false;
        }
        private void changeEnable(bool active)
        {
            textBoxAula.Enabled = active;
            textBoxDocente.Enabled = active;
            textBoxMateria.Enabled = active;
            dateTimePickerEntrada.Enabled = active;
            dateTimePickerSalida.Enabled = active;
            foreach (CheckBox cb in liC)
            {
                cb.Enabled = active;
            }
            buttonAceptar.Visible = active;
            buttonCancelar.Visible = active;
            buttonBuscar.Visible = !active;
            buttonEliminar.Visible = !active;
            buttonEliminar.Enabled = active;

            if (active)
                panel1.Location = new System.Drawing.Point(0, 44);
            else
                panel1.Location = new System.Drawing.Point(0, 84);
            label14.Visible = !active;
            textBoxId.Visible = !active;
            clearAll();
        }
        public Grupos_coordinador()
        {
            InitializeComponent();
            liC.Add(checkBoxL);
            liC.Add(checkBoxM);
            liC.Add(checkBoxI);
            liC.Add(checkBoxJ);
            liC.Add(checkBoxV);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void textBoxDocente_Click(object sender, EventArgs e)
        {
            textBoxDocente.Text = null;
        }

        private void textBoxMateria_Click(object sender, EventArgs e)
        {
            textBoxMateria.Text = null;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            List<string> dtG = new List<string>();
            string dias="";
            CoordiModel coordiModel = new CoordiModel();
            foreach (CheckBox cb in liC)
            {
                if (cb.Checked)
                {
                    if (dias.Length > 0)
                        dias += "-";
                    if (cb == checkBoxL)
                        dias += "L";
                    else if (cb == checkBoxM)
                        dias += "M";
                    else if (cb == checkBoxI)
                        dias += "I";
                    else if (cb == checkBoxJ)
                        dias += "J";
                    else if (cb == checkBoxV)
                        dias += "V";
                }
            }
            dtG.Add(textBoxMateria.Text);
            dtG.Add(textBoxDocente.Text);
            dtG.Add(textBoxAula.Text);
            dtG.Add(dateTimePickerEntrada.Value.TimeOfDay.ToString().Substring(0,5));
            dtG.Add(dateTimePickerSalida.Value.TimeOfDay.ToString().Substring(0, 5));
            dtG.Add(dias);
            string idG=coordiModel.agregarGrupo(dtG);
            if (idG!="-1" && idG!="0")
                MessageBox.Show("Grupo agregado satisfactoriamente./nEl id del grupo es:"+idG+" ", "Grupos");
        }

        private void buttonBusca_Click(object sender, EventArgs e)
        {
            changeEnable(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeEnable(true);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            CoordiModel coordiModel = new CoordiModel();
            List<string> dtG;
            if (textBoxId.Text != "")
            {
                dtG = coordiModel.buscarGrupo(textBoxId.Text);
                if (dtG.Count()>1)
                {
                    textBoxDocente.Text = dtG[0];
                    dateTimePickerEntrada.Value = Convert.ToDateTime(dtG[1]);
                    dateTimePickerSalida.Value = Convert.ToDateTime(dtG[2]);
                    textBoxMateria.Text = dtG[3];
                    if (dtG[4].Contains("L"))
                        checkBoxL.Checked = true;
                    if (dtG[4].Contains("M"))
                        checkBoxM.Checked = true;
                    if (dtG[4].Contains("I"))
                        checkBoxI.Checked = true;
                    if (dtG[4].Contains("J"))
                        checkBoxJ.Checked = true;
                    if (dtG[4].Contains("V"))
                        checkBoxV.Checked = true;
                    textBoxAula.Text = dtG[5];
                    buttonEliminar.Enabled=true;
                    id = textBoxId.Text;
                }
                else
                {
                    labelMensajeError.Text = "No se ha podido encontrar el grupo.";
                    labelMensajeError.Visible = true;
                }
            }
            else
            {
                labelMensajeError.Text = "Porfavor ingrese un id.";
                labelMensajeError.Visible = true;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar a este grupo?", "Grupos", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CoordiModel coordiModel = new CoordiModel();
                coordiModel.delGrupo(id);
            }
        }
    }
}
