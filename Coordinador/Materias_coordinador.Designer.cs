namespace Interfaces
{
    partial class Materias_coordinador
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAgregarCordinador = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonBusca = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelMensajeError = new System.Windows.Forms.Label();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxNombreEliminar = new System.Windows.Forms.TextBox();
            this.textBoxCodigoEliminar = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonBuscarEliminar = new System.Windows.Forms.Button();
            this.buttonConsultaBuscar = new System.Windows.Forms.Button();
            this.dtMat = new System.Windows.Forms.DataGridView();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombreMateria = new System.Windows.Forms.TextBox();
            this.pictureBoxFotoPerfil = new System.Windows.Forms.PictureBox();
            this.panelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMat)).BeginInit();
            this.panelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "MATERIAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAgregarCordinador
            // 
            this.buttonAgregarCordinador.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAgregarCordinador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregarCordinador.Location = new System.Drawing.Point(501, 586);
            this.buttonAgregarCordinador.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAgregarCordinador.Name = "buttonAgregarCordinador";
            this.buttonAgregarCordinador.Size = new System.Drawing.Size(171, 58);
            this.buttonAgregarCordinador.TabIndex = 42;
            this.buttonAgregarCordinador.Text = "Agregar";
            this.buttonAgregarCordinador.UseVisualStyleBackColor = true;
            this.buttonAgregarCordinador.Visible = false;
            this.buttonAgregarCordinador.Click += new System.EventHandler(this.buttonAgregarCordinador_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.Location = new System.Drawing.Point(963, 521);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(171, 58);
            this.buttonEliminar.TabIndex = 47;
            this.buttonEliminar.Text = "Eliminar materia";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonBusca
            // 
            this.buttonBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBusca.Location = new System.Drawing.Point(963, 586);
            this.buttonBusca.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBusca.Name = "buttonBusca";
            this.buttonBusca.Size = new System.Drawing.Size(171, 58);
            this.buttonBusca.TabIndex = 46;
            this.buttonBusca.Text = "Buscar materia";
            this.buttonBusca.UseVisualStyleBackColor = true;
            this.buttonBusca.Click += new System.EventHandler(this.buttonBusca_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(963, 455);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 58);
            this.button1.TabIndex = 45;
            this.button1.Text = "Nuevo registro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMensajeError
            // 
            this.labelMensajeError.AutoSize = true;
            this.labelMensajeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensajeError.ForeColor = System.Drawing.Color.Red;
            this.labelMensajeError.Location = new System.Drawing.Point(499, 496);
            this.labelMensajeError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMensajeError.Name = "labelMensajeError";
            this.labelMensajeError.Size = new System.Drawing.Size(79, 20);
            this.labelMensajeError.TabIndex = 44;
            this.labelMensajeError.Text = "Mensaje";
            this.labelMensajeError.Visible = false;
            // 
            // panelBuscar
            // 
            this.panelBuscar.Controls.Add(this.label16);
            this.panelBuscar.Controls.Add(this.label17);
            this.panelBuscar.Controls.Add(this.textBoxNombreEliminar);
            this.panelBuscar.Controls.Add(this.textBoxCodigoEliminar);
            this.panelBuscar.Controls.Add(this.label18);
            this.panelBuscar.Controls.Add(this.buttonBuscarEliminar);
            this.panelBuscar.Controls.Add(this.buttonConsultaBuscar);
            this.panelBuscar.Location = new System.Drawing.Point(23, 53);
            this.panelBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(821, 183);
            this.panelBuscar.TabIndex = 49;
            this.panelBuscar.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(64, 23);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(179, 25);
            this.label16.TabIndex = 21;
            this.label16.Text = "Datos de la materia";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 69);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 20);
            this.label17.TabIndex = 14;
            this.label17.Text = "Codigo:";
            // 
            // textBoxNombreEliminar
            // 
            this.textBoxNombreEliminar.Location = new System.Drawing.Point(132, 101);
            this.textBoxNombreEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombreEliminar.Name = "textBoxNombreEliminar";
            this.textBoxNombreEliminar.Size = new System.Drawing.Size(245, 22);
            this.textBoxNombreEliminar.TabIndex = 17;
            // 
            // textBoxCodigoEliminar
            // 
            this.textBoxCodigoEliminar.Location = new System.Drawing.Point(132, 66);
            this.textBoxCodigoEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCodigoEliminar.Name = "textBoxCodigoEliminar";
            this.textBoxCodigoEliminar.Size = new System.Drawing.Size(245, 22);
            this.textBoxCodigoEliminar.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(13, 101);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 20);
            this.label18.TabIndex = 16;
            this.label18.Text = "Nombre:";
            // 
            // buttonBuscarEliminar
            // 
            this.buttonBuscarEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBuscarEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuscarEliminar.Location = new System.Drawing.Point(524, 81);
            this.buttonBuscarEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscarEliminar.Name = "buttonBuscarEliminar";
            this.buttonBuscarEliminar.Size = new System.Drawing.Size(171, 58);
            this.buttonBuscarEliminar.TabIndex = 30;
            this.buttonBuscarEliminar.Text = "Eliminar";
            this.buttonBuscarEliminar.UseVisualStyleBackColor = true;
            this.buttonBuscarEliminar.Click += new System.EventHandler(this.buttonBuscarEliminar_Click);
            // 
            // buttonConsultaBuscar
            // 
            this.buttonConsultaBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonConsultaBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConsultaBuscar.Location = new System.Drawing.Point(524, 44);
            this.buttonConsultaBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConsultaBuscar.Name = "buttonConsultaBuscar";
            this.buttonConsultaBuscar.Size = new System.Drawing.Size(171, 58);
            this.buttonConsultaBuscar.TabIndex = 30;
            this.buttonConsultaBuscar.Text = "Buscar";
            this.buttonConsultaBuscar.UseVisualStyleBackColor = true;
            this.buttonConsultaBuscar.Click += new System.EventHandler(this.buttonConsultaBuscar_Click);
            // 
            // dtMat
            // 
            this.dtMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMat.Location = new System.Drawing.Point(19, 286);
            this.dtMat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtMat.Name = "dtMat";
            this.dtMat.RowHeadersWidth = 51;
            this.dtMat.RowTemplate.Height = 24;
            this.dtMat.Size = new System.Drawing.Size(825, 206);
            this.dtMat.TabIndex = 50;
            this.dtMat.Visible = false;
            // 
            // panelRegistro
            // 
            this.panelRegistro.Controls.Add(this.textBoxId);
            this.panelRegistro.Controls.Add(this.labelId);
            this.panelRegistro.Controls.Add(this.label9);
            this.panelRegistro.Controls.Add(this.label2);
            this.panelRegistro.Controls.Add(this.textBoxNombreMateria);
            this.panelRegistro.Location = new System.Drawing.Point(23, 53);
            this.panelRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(463, 207);
            this.panelRegistro.TabIndex = 48;
            this.panelRegistro.Visible = false;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(139, 121);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(283, 22);
            this.textBoxId.TabIndex = 22;
            this.textBoxId.Visible = false;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(21, 121);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(66, 20);
            this.labelId.TabIndex = 21;
            this.labelId.Text = "Codigo:";
            this.labelId.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Información de la materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // textBoxNombreMateria
            // 
            this.textBoxNombreMateria.Location = new System.Drawing.Point(139, 81);
            this.textBoxNombreMateria.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombreMateria.Name = "textBoxNombreMateria";
            this.textBoxNombreMateria.Size = new System.Drawing.Size(283, 22);
            this.textBoxNombreMateria.TabIndex = 4;
            // 
            // pictureBoxFotoPerfil
            // 
            this.pictureBoxFotoPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFotoPerfil.Image = global::Interfaces.Properties.Resources._29302;
            this.pictureBoxFotoPerfil.Location = new System.Drawing.Point(887, 15);
            this.pictureBoxFotoPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFotoPerfil.Name = "pictureBoxFotoPerfil";
            this.pictureBoxFotoPerfil.Size = new System.Drawing.Size(247, 219);
            this.pictureBoxFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFotoPerfil.TabIndex = 43;
            this.pictureBoxFotoPerfil.TabStop = false;
            // 
            // Materias_coordinador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 658);
            this.Controls.Add(this.panelRegistro);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.buttonAgregarCordinador);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonBusca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelMensajeError);
            this.Controls.Add(this.pictureBoxFotoPerfil);
            this.Controls.Add(this.dtMat);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Materias_coordinador";
            this.Text = "Materias::Coordinador";
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMat)).EndInit();
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAgregarCordinador;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonBusca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMensajeError;
        private System.Windows.Forms.PictureBox pictureBoxFotoPerfil;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxCodigoEliminar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonBuscarEliminar;
        private System.Windows.Forms.Button buttonConsultaBuscar;
        private System.Windows.Forms.DataGridView dtMat;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombreMateria;
        private System.Windows.Forms.TextBox textBoxNombreEliminar;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
    }
}