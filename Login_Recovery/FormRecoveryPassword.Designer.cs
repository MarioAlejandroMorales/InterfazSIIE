namespace Presentacion
{
    partial class FormRecoveryPassword
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
            this.components = new System.ComponentModel.Container();
            this.textBoxRecoverUserPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSendRequestRecover = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelUpMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelResultRecovery = new System.Windows.Forms.Label();
            this.panelUpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRecoverUserPassword
            // 
            this.textBoxRecoverUserPassword.Location = new System.Drawing.Point(116, 136);
            this.textBoxRecoverUserPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRecoverUserPassword.Name = "textBoxRecoverUserPassword";
            this.textBoxRecoverUserPassword.Size = new System.Drawing.Size(316, 22);
            this.textBoxRecoverUserPassword.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa tu primer nombre o correo electronico";
            // 
            // buttonSendRequestRecover
            // 
            this.buttonSendRequestRecover.BackColor = System.Drawing.Color.Teal;
            this.buttonSendRequestRecover.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendRequestRecover.ForeColor = System.Drawing.Color.White;
            this.buttonSendRequestRecover.Location = new System.Drawing.Point(115, 166);
            this.buttonSendRequestRecover.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSendRequestRecover.Name = "buttonSendRequestRecover";
            this.buttonSendRequestRecover.Size = new System.Drawing.Size(200, 49);
            this.buttonSendRequestRecover.TabIndex = 2;
            this.buttonSendRequestRecover.Text = "Enviar";
            this.buttonSendRequestRecover.UseVisualStyleBackColor = false;
            this.buttonSendRequestRecover.Click += new System.EventHandler(this.buttonSendRequestRecover_Click);
            // 
            // panelUpMenu
            // 
            this.panelUpMenu.BackColor = System.Drawing.Color.Teal;
            this.panelUpMenu.Controls.Add(this.pictureBoxLogo);
            this.panelUpMenu.Controls.Add(this.label2);
            this.panelUpMenu.Controls.Add(this.btnCerrar);
            this.panelUpMenu.Controls.Add(this.btnMin);
            this.panelUpMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpMenu.Location = new System.Drawing.Point(0, 0);
            this.panelUpMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelUpMenu.Name = "panelUpMenu";
            this.panelUpMenu.Size = new System.Drawing.Size(519, 62);
            this.panelUpMenu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recuperar contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Login_Recovery.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(473, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 31);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = global::Login_Recovery.Properties.Resources.minimizar;
            this.btnMin.Location = new System.Drawing.Point(432, 4);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(33, 31);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 1;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Login_Recovery.Properties.Resources.pngwing_com;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(77, 62);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelResultRecovery
            // 
            this.labelResultRecovery.AutoSize = true;
            this.labelResultRecovery.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultRecovery.Location = new System.Drawing.Point(112, 230);
            this.labelResultRecovery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultRecovery.Name = "labelResultRecovery";
            this.labelResultRecovery.Size = new System.Drawing.Size(83, 18);
            this.labelResultRecovery.TabIndex = 3;
            this.labelResultRecovery.Text = "Resultado";
            this.labelResultRecovery.Visible = false;
            // 
            // FormRecoveryPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 302);
            this.Controls.Add(this.panelUpMenu);
            this.Controls.Add(this.labelResultRecovery);
            this.Controls.Add(this.buttonSendRequestRecover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRecoverUserPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRecoveryPassword";
            this.Text = "Recuperar contraseña";
            this.panelUpMenu.ResumeLayout(false);
            this.panelUpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRecoverUserPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSendRequestRecover;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelUpMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelResultRecovery;
    }
}