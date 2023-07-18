
namespace ProjetGestionStock
{
    partial class frmResetUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResetUser));
            this.panelPrincipal = new Guna.UI.WinForms.GunaShadowPanel();
            this.lblConfirmPassword = new Guna.UI.WinForms.GunaLabel();
            this.lblNewPassword = new Guna.UI.WinForms.GunaLabel();
            this.lblLogin = new Guna.UI.WinForms.GunaLabel();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.checkBoxAf = new System.Windows.Forms.CheckBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.panelTop = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.panelPrincipal.BaseColor = System.Drawing.Color.White;
            this.panelPrincipal.Controls.Add(this.lblConfirmPassword);
            this.panelPrincipal.Controls.Add(this.lblNewPassword);
            this.panelPrincipal.Controls.Add(this.lblLogin);
            this.panelPrincipal.Controls.Add(this.txtNewPassword);
            this.panelPrincipal.Controls.Add(this.checkBoxAf);
            this.panelPrincipal.Controls.Add(this.txtLogin);
            this.panelPrincipal.Controls.Add(this.pictureBox1);
            this.panelPrincipal.Controls.Add(this.btnAnnuler);
            this.panelPrincipal.Controls.Add(this.btnEnregistrer);
            this.panelPrincipal.Controls.Add(this.txtConfirmPassword);
            this.panelPrincipal.Controls.Add(this.panelTop);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.ShadowColor = System.Drawing.Color.Gainsboro;
            this.panelPrincipal.Size = new System.Drawing.Size(323, 342);
            this.panelPrincipal.TabIndex = 9;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(6, 160);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(149, 17);
            this.lblConfirmPassword.TabIndex = 30;
            this.lblConfirmPassword.Text = "Confirmez Mot de Passe";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(12, 125);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(145, 17);
            this.lblNewPassword.TabIndex = 29;
            this.lblNewPassword.Text = "Nouveau Mot de Passe";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(14, 89);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(40, 17);
            this.lblLogin.TabIndex = 28;
            this.lblLogin.Text = "Login";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(158, 122);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(154, 20);
            this.txtNewPassword.TabIndex = 27;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // checkBoxAf
            // 
            this.checkBoxAf.AutoSize = true;
            this.checkBoxAf.Location = new System.Drawing.Point(158, 188);
            this.checkBoxAf.Name = "checkBoxAf";
            this.checkBoxAf.Size = new System.Drawing.Size(130, 17);
            this.checkBoxAf.TabIndex = 25;
            this.checkBoxAf.Text = "Affichez mot de passe";
            this.checkBoxAf.UseVisualStyleBackColor = true;
            this.checkBoxAf.CheckedChanged += new System.EventHandler(this.checkBoxAf_CheckedChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(158, 86);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(154, 20);
            this.txtLogin.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(239, 218);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 37);
            this.btnAnnuler.TabIndex = 21;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(158, 218);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 37);
            this.btnEnregistrer.TabIndex = 20;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(158, 158);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(154, 20);
            this.txtConfirmPassword.TabIndex = 19;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.panelTop.Controls.Add(this.gunaLabel1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.ShadowColor = System.Drawing.Color.Gainsboro;
            this.panelTop.Size = new System.Drawing.Size(323, 65);
            this.panelTop.TabIndex = 8;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(87, 25);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(175, 17);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Formulaire de Renitialisation";
            // 
            // frmResetUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 342);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResetUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmResetUser";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel panelPrincipal;
        private Guna.UI.WinForms.GunaLabel lblConfirmPassword;
        private Guna.UI.WinForms.GunaLabel lblNewPassword;
        private Guna.UI.WinForms.GunaLabel lblLogin;
        public System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.CheckBox checkBoxAf;
        public System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        public System.Windows.Forms.TextBox txtConfirmPassword;
        private Guna.UI.WinForms.GunaShadowPanel panelTop;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}