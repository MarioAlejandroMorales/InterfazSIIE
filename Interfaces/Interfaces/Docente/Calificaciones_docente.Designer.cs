namespace Interfaces
{
    partial class Calificaciones_docente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCalificacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIDGrupo = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "CALIFICACIONES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxCalificacion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxIDGrupo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxIDAlumno);
            this.panel1.Controls.Add(this.buttonAceptarCal);
            this.panel1.Location = new System.Drawing.Point(23, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 267);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Asignar califiación";
            // 
            // textBoxCalificacion
            // 
            this.textBoxCalificacion.Location = new System.Drawing.Point(109, 145);
            this.textBoxCalificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCalificacion.Name = "textBoxCalificacion";
            this.textBoxCalificacion.Size = new System.Drawing.Size(68, 22);
            this.textBoxCalificacion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Calificación:";
            // 
            // textBoxIDGrupo
            // 
            this.textBoxIDGrupo.Location = new System.Drawing.Point(109, 113);
            this.textBoxIDGrupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIDGrupo.Name = "textBoxIDGrupo";
            this.textBoxIDGrupo.Size = new System.Drawing.Size(68, 22);
            this.textBoxIDGrupo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Grupo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Alumno:";
            // 
            // textBoxIDAlumno
            // 
            this.textBoxIDAlumno.Location = new System.Drawing.Point(109, 81);
            this.textBoxIDAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIDAlumno.Name = "textBoxIDAlumno";
            this.textBoxIDAlumno.Size = new System.Drawing.Size(68, 22);
            this.textBoxIDAlumno.TabIndex = 1;
            // 
            // buttonAceptarCal
            // 
            this.buttonAceptarCal.Location = new System.Drawing.Point(60, 204);
            this.buttonAceptarCal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAceptarCal.Name = "buttonAceptarCal";
            this.buttonAceptarCal.Size = new System.Drawing.Size(100, 28);
            this.buttonAceptarCal.TabIndex = 0;
            this.buttonAceptarCal.Text = "Aceptar";
            this.buttonAceptarCal.UseVisualStyleBackColor = true;
            this.buttonAceptarCal.Click += new System.EventHandler(this.buttonAceptarCal_Click);
            // 
            // dataGridViewListaAlumnos
            // 
            this.dataGridViewListaAlumnos.AllowUserToAddRows = false;
            this.dataGridViewListaAlumnos.AllowUserToDeleteRows = false;
            this.dataGridViewListaAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaAlumnos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewListaAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListaAlumnos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewListaAlumnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewListaAlumnos.Enabled = false;
            this.dataGridViewListaAlumnos.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewListaAlumnos.Location = new System.Drawing.Point(61, 370);
            this.dataGridViewListaAlumnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListaAlumnos.Name = "dataGridViewListaAlumnos";
            this.dataGridViewListaAlumnos.RowHeadersWidth = 51;
            this.dataGridViewListaAlumnos.RowTemplate.Height = 24;
            this.dataGridViewListaAlumnos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewListaAlumnos.Size = new System.Drawing.Size(1029, 256);
            this.dataGridViewListaAlumnos.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(712, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ingrese el ID del grupo:";
            // 
            // textBoxIDGrupoLista
            // 
            this.textBoxIDGrupoLista.Location = new System.Drawing.Point(871, 39);
            this.textBoxIDGrupoLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIDGrupoLista.Name = "textBoxIDGrupoLista";
            this.textBoxIDGrupoLista.Size = new System.Drawing.Size(73, 22);
            this.textBoxIDGrupoLista.TabIndex = 12;
            // 
            // buttonConsultarLista
            // 
            this.buttonConsultarLista.Location = new System.Drawing.Point(953, 37);
            this.buttonConsultarLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConsultarLista.Name = "buttonConsultarLista";
            this.buttonConsultarLista.Size = new System.Drawing.Size(137, 28);
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListaGrupos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewListaGrupos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewListaGrupos.Enabled = false;
            this.dataGridViewListaGrupos.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewListaGrupos.Location = new System.Drawing.Point(397, 95);
            this.dataGridViewListaGrupos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListaGrupos.Name = "dataGridViewListaGrupos";
            this.dataGridViewListaGrupos.RowHeadersWidth = 51;
            this.dataGridViewListaGrupos.RowTemplate.Height = 24;
            this.dataGridViewListaGrupos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewListaGrupos.Size = new System.Drawing.Size(671, 246);
            this.dataGridViewListaGrupos.TabIndex = 14;
            // 
            // Calificaciones_docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 658);
            this.Controls.Add(this.dataGridViewListaGrupos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewListaAlumnos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxIDGrupoLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConsultarLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Calificaciones_docente";
            this.Text = "Calificaciones::Docente";
            this.Load += new System.EventHandler(this.Calificaciones_docente_Load);
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
        private System.Windows.Forms.TextBox textBoxIDGrupo;
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