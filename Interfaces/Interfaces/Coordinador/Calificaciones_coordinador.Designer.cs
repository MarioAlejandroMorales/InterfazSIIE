namespace Interfaces.Coordinador
{
    partial class Calificaciones_coordinador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCalificacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIDMateria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIDAlumno = new System.Windows.Forms.TextBox();
            this.buttonAceptarCal = new System.Windows.Forms.Button();
            this.dataGridViewListaAlumnos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxIDGrupoLista = new System.Windows.Forms.TextBox();
            this.buttonConsultarLista = new System.Windows.Forms.Button();
            this.dataGridViewListaGrupos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CALIFICACIONES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxCalificacion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxIDMateria);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxIDAlumno);
            this.panel1.Controls.Add(this.buttonAceptarCal);
            this.panel1.Location = new System.Drawing.Point(17, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 217);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Asignar califiación";
            // 
            // textBoxCalificacion
            // 
            this.textBoxCalificacion.Location = new System.Drawing.Point(82, 118);
            this.textBoxCalificacion.Name = "textBoxCalificacion";
            this.textBoxCalificacion.Size = new System.Drawing.Size(52, 20);
            this.textBoxCalificacion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Calificación:";
            // 
            // textBoxIDMateria
            // 
            this.textBoxIDMateria.Location = new System.Drawing.Point(82, 92);
            this.textBoxIDMateria.Name = "textBoxIDMateria";
            this.textBoxIDMateria.Size = new System.Drawing.Size(52, 20);
            this.textBoxIDMateria.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Materia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Alumno:";
            // 
            // textBoxIDAlumno
            // 
            this.textBoxIDAlumno.Location = new System.Drawing.Point(82, 66);
            this.textBoxIDAlumno.Name = "textBoxIDAlumno";
            this.textBoxIDAlumno.Size = new System.Drawing.Size(52, 20);
            this.textBoxIDAlumno.TabIndex = 1;
            // 
            // buttonAceptarCal
            // 
            this.buttonAceptarCal.Location = new System.Drawing.Point(45, 166);
            this.buttonAceptarCal.Name = "buttonAceptarCal";
            this.buttonAceptarCal.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptarCal.TabIndex = 0;
            this.buttonAceptarCal.Text = "Aceptar";
            this.buttonAceptarCal.UseVisualStyleBackColor = true;
            // 
            // dataGridViewListaAlumnos
            // 
            this.dataGridViewListaAlumnos.AllowUserToAddRows = false;
            this.dataGridViewListaAlumnos.AllowUserToDeleteRows = false;
            this.dataGridViewListaAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaAlumnos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewListaAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListaAlumnos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewListaAlumnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewListaAlumnos.Enabled = false;
            this.dataGridViewListaAlumnos.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewListaAlumnos.Location = new System.Drawing.Point(46, 301);
            this.dataGridViewListaAlumnos.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewListaAlumnos.Name = "dataGridViewListaAlumnos";
            this.dataGridViewListaAlumnos.RowHeadersWidth = 51;
            this.dataGridViewListaAlumnos.RowTemplate.Height = 24;
            this.dataGridViewListaAlumnos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewListaAlumnos.Size = new System.Drawing.Size(772, 208);
            this.dataGridViewListaAlumnos.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(534, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ingrese el ID del grupo:";
            // 
            // textBoxIDGrupoLista
            // 
            this.textBoxIDGrupoLista.Location = new System.Drawing.Point(653, 32);
            this.textBoxIDGrupoLista.Name = "textBoxIDGrupoLista";
            this.textBoxIDGrupoLista.Size = new System.Drawing.Size(56, 20);
            this.textBoxIDGrupoLista.TabIndex = 12;
            // 
            // buttonConsultarLista
            // 
            this.buttonConsultarLista.Location = new System.Drawing.Point(715, 30);
            this.buttonConsultarLista.Name = "buttonConsultarLista";
            this.buttonConsultarLista.Size = new System.Drawing.Size(103, 23);
            this.buttonConsultarLista.TabIndex = 11;
            this.buttonConsultarLista.Text = "Consultar lista alummos";
            this.buttonConsultarLista.UseVisualStyleBackColor = true;
            this.buttonConsultarLista.Click += new System.EventHandler(this.buttonConsultarLista_Click);
            // 
            // dataGridViewListaGrupos
            // 
            this.dataGridViewListaGrupos.AllowUserToAddRows = false;
            this.dataGridViewListaGrupos.AllowUserToDeleteRows = false;
            this.dataGridViewListaGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaGrupos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewListaGrupos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListaGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListaGrupos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewListaGrupos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewListaGrupos.Enabled = false;
            this.dataGridViewListaGrupos.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewListaGrupos.Location = new System.Drawing.Point(298, 77);
            this.dataGridViewListaGrupos.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewListaGrupos.Name = "dataGridViewListaGrupos";
            this.dataGridViewListaGrupos.RowHeadersWidth = 51;
            this.dataGridViewListaGrupos.RowTemplate.Height = 24;
            this.dataGridViewListaGrupos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewListaGrupos.Size = new System.Drawing.Size(503, 200);
            this.dataGridViewListaGrupos.TabIndex = 14;
            // 
            // Calificaciones_coordinador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 535);
            this.Controls.Add(this.dataGridViewListaGrupos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewListaAlumnos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxIDGrupoLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConsultarLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calificaciones_coordinador";
            this.Text = "Calificaciones::Docente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCalificacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIDMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIDAlumno;
        private System.Windows.Forms.Button buttonAceptarCal;
        private System.Windows.Forms.DataGridView dataGridViewListaAlumnos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxIDGrupoLista;
        private System.Windows.Forms.Button buttonConsultarLista;
        private System.Windows.Forms.DataGridView dataGridViewListaGrupos;
    }
}