namespace Interfaces
{
    partial class FormCoordinador
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCoordinador));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.panelUpMenu = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.botonSlides = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.botonLogOut = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAlumnos = new System.Windows.Forms.Button();
            this.menuVertical.SuspendLayout();
            this.panelUpMenu.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSlides)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.DarkCyan;
            this.menuVertical.Controls.Add(this.button5);
            this.menuVertical.Controls.Add(this.button4);
            this.menuVertical.Controls.Add(this.botonLogOut);
            this.menuVertical.Controls.Add(this.button3);
            this.menuVertical.Controls.Add(this.pictureBoxLogo);
            this.menuVertical.Controls.Add(this.button2);
            this.menuVertical.Controls.Add(this.button1);
            this.menuVertical.Controls.Add(this.buttonAlumnos);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(193, 547);
            this.menuVertical.TabIndex = 1;
            // 
            // panelUpMenu
            // 
            this.panelUpMenu.Controls.Add(this.lblNombre);
            this.panelUpMenu.Controls.Add(this.label1);
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
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(518, 14);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(149, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "nombre de coordinador";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNombre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUpMenu_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "COORDINADOR:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUpMenu_MouseDown);
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
            this.label2.TabIndex = 5;
            this.label2.Text = "BIENVENIDO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::Interfaces.Properties.Resources.horario;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 327);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(193, 40);
            this.button5.TabIndex = 7;
            this.button5.Text = "Agendar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Interfaces.Properties.Resources.calificacion;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "Calificaciones";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.botonLogOut.TabIndex = 5;
            this.botonLogOut.TabStop = false;
            this.botonLogOut.Click += new System.EventHandler(this.botonLogOut_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Interfaces.Properties.Resources.registro;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Registro";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Interfaces.Properties.Resources.grupo;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Grupos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Interfaces.Properties.Resources.materia_1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Materias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonAlumnos
            // 
            this.buttonAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAlumnos.FlatAppearance.BorderSize = 0;
            this.buttonAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlumnos.ForeColor = System.Drawing.Color.White;
            this.buttonAlumnos.Image = global::Interfaces.Properties.Resources.alumno_1_;
            this.buttonAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlumnos.Location = new System.Drawing.Point(0, 97);
            this.buttonAlumnos.Name = "buttonAlumnos";
            this.buttonAlumnos.Size = new System.Drawing.Size(193, 40);
            this.buttonAlumnos.TabIndex = 0;
            this.buttonAlumnos.Text = "Usuarios";
            this.buttonAlumnos.UseVisualStyleBackColor = true;
            this.buttonAlumnos.Click += new System.EventHandler(this.buttonAlumnos_Click);
            // 
            // FormCoordinador
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
            this.Name = "FormCoordinador";
            this.Text = "Coordinador";
            this.menuVertical.ResumeLayout(false);
            this.panelUpMenu.ResumeLayout(false);
            this.panelUpMenu.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonSlides)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botonLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAlumnos;
        private System.Windows.Forms.Panel panelUpMenu;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox botonSlides;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox botonLogOut;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}