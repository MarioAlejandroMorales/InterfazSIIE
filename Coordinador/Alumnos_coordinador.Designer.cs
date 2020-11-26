namespace Interfaces
{
    partial class Alumnos_coordinador
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
            this.dtUser = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonBusca = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelMensajeError = new System.Windows.Forms.Label();
            this.pictureBoxFotoPerfil = new System.Windows.Forms.PictureBox();
            this.buttonAgregarCordinador = new System.Windows.Forms.Button();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.textBoxCorreoEliminar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxNombreEliminar = new System.Windows.Forms.TextBox();
            this.textBoxCodigoEliminar = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonBuscarEliminar = new System.Windows.Forms.Button();
            this.buttonConsultaBuscar = new System.Windows.Forms.Button();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.textBoxCiclo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbBRol = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApellido1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxApellido2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCarrera = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfil)).BeginInit();
            this.panelBuscar.SuspendLayout();
            this.panelRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "ALUMNOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtUser
            // 
            this.dtUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUser.Location = new System.Drawing.Point(19, 286);
            this.dtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtUser.Name = "dtUser";
            this.dtUser.RowHeadersWidth = 51;
            this.dtUser.RowTemplate.Height = 24;
            this.dtUser.Size = new System.Drawing.Size(825, 206);
            this.dtUser.TabIndex = 41;
            this.dtUser.Visible = false;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.Location = new System.Drawing.Point(963, 521);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(171, 58);
            this.buttonEliminar.TabIndex = 38;
            this.buttonEliminar.Text = "Eliminar usuario";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonBusca
            // 
            this.buttonBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBusca.Location = new System.Drawing.Point(963, 586);
            this.buttonBusca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBusca.Name = "buttonBusca";
            this.buttonBusca.Size = new System.Drawing.Size(171, 58);
            this.buttonBusca.TabIndex = 37;
            this.buttonBusca.Text = "Buscar usuario";
            this.buttonBusca.UseVisualStyleBackColor = true;
            this.buttonBusca.Click += new System.EventHandler(this.buttonBusca_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(963, 455);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 58);
            this.button1.TabIndex = 36;
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
            this.labelMensajeError.TabIndex = 35;
            this.labelMensajeError.Text = "Mensaje";
            this.labelMensajeError.Visible = false;
            // 
            // pictureBoxFotoPerfil
            // 
            this.pictureBoxFotoPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFotoPerfil.Image = global::Interfaces.Properties.Resources._16363;
            this.pictureBoxFotoPerfil.Location = new System.Drawing.Point(887, 15);
            this.pictureBoxFotoPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxFotoPerfil.Name = "pictureBoxFotoPerfil";
            this.pictureBoxFotoPerfil.Size = new System.Drawing.Size(247, 219);
            this.pictureBoxFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFotoPerfil.TabIndex = 34;
            this.pictureBoxFotoPerfil.TabStop = false;
            // 
            // buttonAgregarCordinador
            // 
            this.buttonAgregarCordinador.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAgregarCordinador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregarCordinador.Location = new System.Drawing.Point(501, 586);
            this.buttonAgregarCordinador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAgregarCordinador.Name = "buttonAgregarCordinador";
            this.buttonAgregarCordinador.Size = new System.Drawing.Size(171, 58);
            this.buttonAgregarCordinador.TabIndex = 33;
            this.buttonAgregarCordinador.Text = "Agregar";
            this.buttonAgregarCordinador.UseVisualStyleBackColor = true;
            this.buttonAgregarCordinador.Visible = false;
            this.buttonAgregarCordinador.Click += new System.EventHandler(this.buttonAgregarCordinador_Click);
            // 
            // panelBuscar
            // 
            this.panelBuscar.Controls.Add(this.textBoxCorreoEliminar);
            this.panelBuscar.Controls.Add(this.label14);
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
            this.panelBuscar.TabIndex = 40;
            this.panelBuscar.Visible = false;
            // 
            // textBoxCorreoEliminar
            // 
            this.textBoxCorreoEliminar.Location = new System.Drawing.Point(132, 134);
            this.textBoxCorreoEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCorreoEliminar.Name = "textBoxCorreoEliminar";
            this.textBoxCorreoEliminar.ReadOnly = true;
            this.textBoxCorreoEliminar.Size = new System.Drawing.Size(269, 22);
            this.textBoxCorreoEliminar.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 135);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Correo:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(64, 23);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 25);
            this.label16.TabIndex = 21;
            this.label16.Text = "Datos del usuario";
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
            this.textBoxNombreEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNombreEliminar.Name = "textBoxNombreEliminar";
            this.textBoxNombreEliminar.ReadOnly = true;
            this.textBoxNombreEliminar.Size = new System.Drawing.Size(140, 22);
            this.textBoxNombreEliminar.TabIndex = 17;
            // 
            // textBoxCodigoEliminar
            // 
            this.textBoxCodigoEliminar.Location = new System.Drawing.Point(132, 66);
            this.textBoxCodigoEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCodigoEliminar.Name = "textBoxCodigoEliminar";
            this.textBoxCodigoEliminar.Size = new System.Drawing.Size(140, 22);
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
            this.buttonBuscarEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBuscarEliminar.Name = "buttonBuscarEliminar";
            this.buttonBuscarEliminar.Size = new System.Drawing.Size(171, 58);
            this.buttonBuscarEliminar.TabIndex = 30;
            this.buttonBuscarEliminar.Text = "Dar de baja";
            this.buttonBuscarEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonConsultaBuscar
            // 
            this.buttonConsultaBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonConsultaBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConsultaBuscar.Location = new System.Drawing.Point(524, 44);
            this.buttonConsultaBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConsultaBuscar.Name = "buttonConsultaBuscar";
            this.buttonConsultaBuscar.Size = new System.Drawing.Size(171, 58);
            this.buttonConsultaBuscar.TabIndex = 30;
            this.buttonConsultaBuscar.Text = "Buscar";
            this.buttonConsultaBuscar.UseVisualStyleBackColor = true;
            this.buttonConsultaBuscar.Click += new System.EventHandler(this.buttonConsultaBuscar_Click);
            // 
            // panelRegistro
            // 
            this.panelRegistro.Controls.Add(this.textBoxCiclo);
            this.panelRegistro.Controls.Add(this.label13);
            this.panelRegistro.Controls.Add(this.cmbBRol);
            this.panelRegistro.Controls.Add(this.label11);
            this.panelRegistro.Controls.Add(this.label9);
            this.panelRegistro.Controls.Add(this.label2);
            this.panelRegistro.Controls.Add(this.textBoxNombre);
            this.panelRegistro.Controls.Add(this.label3);
            this.panelRegistro.Controls.Add(this.textBoxApellido1);
            this.panelRegistro.Controls.Add(this.label4);
            this.panelRegistro.Controls.Add(this.textBoxApellido2);
            this.panelRegistro.Controls.Add(this.label5);
            this.panelRegistro.Controls.Add(this.textBoxCarrera);
            this.panelRegistro.Controls.Add(this.textBoxCorreo);
            this.panelRegistro.Controls.Add(this.label6);
            this.panelRegistro.Location = new System.Drawing.Point(23, 53);
            this.panelRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(463, 528);
            this.panelRegistro.TabIndex = 39;
            this.panelRegistro.Visible = false;
            // 
            // textBoxCiclo
            // 
            this.textBoxCiclo.Location = new System.Drawing.Point(139, 271);
            this.textBoxCiclo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCiclo.Name = "textBoxCiclo";
            this.textBoxCiclo.Size = new System.Drawing.Size(283, 22);
            this.textBoxCiclo.TabIndex = 26;
            this.textBoxCiclo.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 271);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Ciclo:";
            this.label13.Visible = false;
            // 
            // cmbBRol
            // 
            this.cmbBRol.FormattingEnabled = true;
            this.cmbBRol.Location = new System.Drawing.Point(139, 209);
            this.cmbBRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBRol.Name = "cmbBRol";
            this.cmbBRol.Size = new System.Drawing.Size(159, 24);
            this.cmbBRol.TabIndex = 24;
            this.cmbBRol.SelectedIndexChanged += new System.EventHandler(this.cmbBRol_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 210);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Rol:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Información personal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(139, 81);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(283, 22);
            this.textBoxNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido P:";
            // 
            // textBoxApellido1
            // 
            this.textBoxApellido1.Location = new System.Drawing.Point(139, 113);
            this.textBoxApellido1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxApellido1.Name = "textBoxApellido1";
            this.textBoxApellido1.Size = new System.Drawing.Size(283, 22);
            this.textBoxApellido1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido M:";
            // 
            // textBoxApellido2
            // 
            this.textBoxApellido2.Location = new System.Drawing.Point(139, 145);
            this.textBoxApellido2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxApellido2.Name = "textBoxApellido2";
            this.textBoxApellido2.Size = new System.Drawing.Size(283, 22);
            this.textBoxApellido2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Correo:";
            // 
            // textBoxCarrera
            // 
            this.textBoxCarrera.Location = new System.Drawing.Point(139, 240);
            this.textBoxCarrera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCarrera.Name = "textBoxCarrera";
            this.textBoxCarrera.Size = new System.Drawing.Size(140, 22);
            this.textBoxCarrera.TabIndex = 19;
            this.textBoxCarrera.Visible = false;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(139, 177);
            this.textBoxCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(283, 22);
            this.textBoxCorreo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 241);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Carrera:";
            this.label6.Visible = false;
            // 
            // Alumnos_coordinador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 658);
            this.Controls.Add(this.buttonAgregarCordinador);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonBusca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelMensajeError);
            this.Controls.Add(this.pictureBoxFotoPerfil);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtUser);
            this.Controls.Add(this.panelRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Alumnos_coordinador";
            this.Text = "Alumnos::Coordinador";
            ((System.ComponentModel.ISupportInitialize)(this.dtUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfil)).EndInit();
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtUser;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonBusca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMensajeError;
        private System.Windows.Forms.PictureBox pictureBoxFotoPerfil;
        private System.Windows.Forms.Button buttonAgregarCordinador;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.TextBox textBoxCorreoEliminar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxNombreEliminar;
        private System.Windows.Forms.TextBox textBoxCodigoEliminar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonBuscarEliminar;
        private System.Windows.Forms.Button buttonConsultaBuscar;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.TextBox textBoxCiclo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbBRol;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxApellido1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxApellido2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCarrera;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Label label6;
    }
}