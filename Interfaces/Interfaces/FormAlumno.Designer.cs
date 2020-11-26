namespace Interfaces
{
    partial class FormAlumno
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlumno));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.botonLogOut = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.botonKardex = new System.Windows.Forms.Button();
            this.botonAgendar = new System.Windows.Forms.Button();
            this.buttonHorario = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panelUpMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.botonSlides = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelUpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSlides)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.DarkCyan;
            this.menuVertical.Controls.Add(this.botonLogOut);
            this.menuVertical.Controls.Add(this.pictureBoxLogo);
            this.menuVertical.Controls.Add(this.botonKardex);
            this.menuVertical.Controls.Add(this.botonAgendar);
            this.menuVertical.Controls.Add(this.buttonHorario);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(193, 547);
            this.menuVertical.TabIndex = 1;
            // 
            // botonLogOut
            // 
            this.botonLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonLogOut.Image = global::Interfaces.Properties.Resources._25706;
            this.botonLogOut.Location = new System.Drawing.Point(8, 502);
            this.botonLogOut.Name = "botonLogOut";
            this.botonLogOut.Size = new System.Drawing.Size(47, 40);
            this.botonLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonLogOut.TabIndex = 0;
            this.botonLogOut.TabStop = false;
            this.botonLogOut.Click += new System.EventHandler(this.botonLogOut_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Interfaces.Properties.Resources.pngwing_com;
            this.pictureBoxLogo.Location = new System.Drawing.Point(5, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(184, 88);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // botonKardex
            // 
            this.botonKardex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonKardex.FlatAppearance.BorderSize = 0;
            this.botonKardex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonKardex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonKardex.ForeColor = System.Drawing.Color.White;
            this.botonKardex.Image = global::Interfaces.Properties.Resources.calificacion;
            this.botonKardex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonKardex.Location = new System.Drawing.Point(0, 143);
            this.botonKardex.Name = "botonKardex";
            this.botonKardex.Size = new System.Drawing.Size(193, 40);
            this.botonKardex.TabIndex = 2;
            this.botonKardex.Text = "Kardex";
            this.botonKardex.UseVisualStyleBackColor = true;
            this.botonKardex.Click += new System.EventHandler(this.botonKardex_Click);
            // 
            // botonAgendar
            // 
            this.botonAgendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonAgendar.FlatAppearance.BorderSize = 0;
            this.botonAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgendar.ForeColor = System.Drawing.Color.White;
            this.botonAgendar.Image = global::Interfaces.Properties.Resources.materia_1_;
            this.botonAgendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonAgendar.Location = new System.Drawing.Point(0, 189);
            this.botonAgendar.Name = "botonAgendar";
            this.botonAgendar.Size = new System.Drawing.Size(193, 40);
            this.botonAgendar.TabIndex = 1;
            this.botonAgendar.Text = "Agendar";
            this.botonAgendar.UseVisualStyleBackColor = true;
            this.botonAgendar.Click += new System.EventHandler(this.botonAgendar_Click);
            // 
            // buttonHorario
            // 
            this.buttonHorario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHorario.FlatAppearance.BorderSize = 0;
            this.buttonHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHorario.ForeColor = System.Drawing.Color.White;
            this.buttonHorario.Image = global::Interfaces.Properties.Resources.horario;
            this.buttonHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHorario.Location = new System.Drawing.Point(0, 97);
            this.buttonHorario.Name = "buttonHorario";
            this.buttonHorario.Size = new System.Drawing.Size(193, 40);
            this.buttonHorario.TabIndex = 0;
            this.buttonHorario.Text = "Horario";
            this.buttonHorario.UseVisualStyleBackColor = true;
            this.buttonHorario.Click += new System.EventHandler(this.buttonHorario_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(458, 14);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(120, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "nombre de alumno";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelUpMenu
            // 
            this.panelUpMenu.Controls.Add(this.label1);
            this.panelUpMenu.Controls.Add(this.lblNombre);
            this.panelUpMenu.Controls.Add(this.btnCerrar);
            this.panelUpMenu.Controls.Add(this.btnMin);
            this.panelUpMenu.Controls.Add(this.botonSlides);
            this.panelUpMenu.Controls.Add(this.btnMax);
            this.panelUpMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpMenu.Location = new System.Drawing.Point(193, 0);
            this.panelUpMenu.Name = "panelUpMenu";
            this.panelUpMenu.Size = new System.Drawing.Size(834, 50);
            this.panelUpMenu.TabIndex = 2;
            this.panelUpMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUpMenu_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ALUMNO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Interfaces.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(806, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = global::Interfaces.Properties.Resources.minimizar;
            this.btnMin.Location = new System.Drawing.Point(744, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 25);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 1;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // botonSlides
            // 
            this.botonSlides.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSlides.Image = global::Interfaces.Properties.Resources.menu;
            this.botonSlides.Location = new System.Drawing.Point(6, 9);
            this.botonSlides.Name = "botonSlides";
            this.botonSlides.Size = new System.Drawing.Size(35, 35);
            this.botonSlides.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botonSlides.TabIndex = 0;
            this.botonSlides.TabStop = false;
            this.botonSlides.Click += new System.EventHandler(this.botonSlides_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = global::Interfaces.Properties.Resources.maximizar;
            this.btnMax.Location = new System.Drawing.Point(776, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(25, 25);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 0;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContenedor.Controls.Add(this.label2);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(193, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(834, 497);
            this.panelContenedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "BIENVENIDO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 547);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelUpMenu);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAlumno";
            this.Text = "Alumno";
            this.menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.botonLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelUpMenu.ResumeLayout(false);
            this.panelUpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSlides)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button botonKardex;
        private System.Windows.Forms.Button botonAgendar;
        private System.Windows.Forms.Button buttonHorario;
        private System.Windows.Forms.Panel panelUpMenu;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox botonSlides;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox botonLogOut;
        private System.Windows.Forms.Label label2;
    }
}

