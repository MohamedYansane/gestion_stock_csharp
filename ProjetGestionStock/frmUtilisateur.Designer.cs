
namespace ProjetGestionStock
{
    partial class frmUtilisateur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUtilisateur));
            this.dgUtilisateur = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSaveModication = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.btnActiverDesactiver = new System.Windows.Forms.Button();
            this.lblSatus = new Guna.UI.WinForms.GunaLabel();
            this.lblProfil = new Guna.UI.WinForms.GunaLabel();
            this.lblIdentifiant = new Guna.UI.WinForms.GunaLabel();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIdentifiant = new Guna.UI.WinForms.GunaLineTextBox();
            this.UserSeparator = new Guna.UI.WinForms.GunaSeparator();
            this.cbbProfil = new Guna.UI.WinForms.GunaComboBox();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.cbbStatutUser = new Guna.UI.WinForms.GunaComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.btnAjouterUser = new System.Windows.Forms.Button();
            this.cbbProfilUser = new Guna.UI.WinForms.GunaComboBox();
            this.btnRenitialisation = new System.Windows.Forms.Button();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtIdentifiantUser = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUtilisateur
            // 
            this.dgUtilisateur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgUtilisateur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgUtilisateur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUtilisateur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUtilisateur.ColumnHeadersHeight = 30;
            this.dgUtilisateur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtProfil,
            this.txtLogin,
            this.txtStatus});
            this.dgUtilisateur.EnableHeadersVisualStyles = false;
            this.dgUtilisateur.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgUtilisateur.Location = new System.Drawing.Point(369, 44);
            this.dgUtilisateur.MultiSelect = false;
            this.dgUtilisateur.Name = "dgUtilisateur";
            this.dgUtilisateur.ReadOnly = true;
            this.dgUtilisateur.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgUtilisateur.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgUtilisateur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUtilisateur.Size = new System.Drawing.Size(387, 244);
            this.dgUtilisateur.TabIndex = 1;
            this.dgUtilisateur.CellBorderStyleChanged += new System.EventHandler(this.dgUtilisateur_CellBorderStyleChanged);
            this.dgUtilisateur.DefaultCellStyleChanged += new System.EventHandler(this.dgUtilisateur_DefaultCellStyleChanged);
            this.dgUtilisateur.SelectionChanged += new System.EventHandler(this.dgUtilisateur_SelectionChanged);
            // 
            // txtId
            // 
            this.txtId.DataPropertyName = "id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.txtId.DefaultCellStyle = dataGridViewCellStyle2;
            this.txtId.HeaderText = "N° Compte";
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            // 
            // txtProfil
            // 
            this.txtProfil.DataPropertyName = "profil";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.txtProfil.DefaultCellStyle = dataGridViewCellStyle3;
            this.txtProfil.HeaderText = "Profil";
            this.txtProfil.Name = "txtProfil";
            this.txtProfil.ReadOnly = true;
            // 
            // txtLogin
            // 
            this.txtLogin.DataPropertyName = "login";
            this.txtLogin.HeaderText = "Login";
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ReadOnly = true;
            this.txtLogin.Width = 75;
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtStatus.DataPropertyName = "isActive";
            this.txtStatus.HeaderText = "Status";
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnSaveModication
            // 
            this.btnSaveModication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.btnSaveModication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveModication.ForeColor = System.Drawing.Color.White;
            this.btnSaveModication.Location = new System.Drawing.Point(658, 308);
            this.btnSaveModication.Name = "btnSaveModication";
            this.btnSaveModication.Size = new System.Drawing.Size(102, 37);
            this.btnSaveModication.TabIndex = 15;
            this.btnSaveModication.Text = "&Modifier";
            this.btnSaveModication.UseVisualStyleBackColor = false;
            this.btnSaveModication.Click += new System.EventHandler(this.btnSaveModication_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.btnSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectionner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnSelectionner.Location = new System.Drawing.Point(373, 308);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(114, 41);
            this.btnSelectionner.TabIndex = 29;
            this.btnSelectionner.Text = "&Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = false;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // btnActiverDesactiver
            // 
            this.btnActiverDesactiver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.btnActiverDesactiver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActiverDesactiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnActiverDesactiver.ForeColor = System.Drawing.Color.White;
            this.btnActiverDesactiver.Location = new System.Drawing.Point(494, 306);
            this.btnActiverDesactiver.Name = "btnActiverDesactiver";
            this.btnActiverDesactiver.Size = new System.Drawing.Size(139, 41);
            this.btnActiverDesactiver.TabIndex = 30;
            this.btnActiverDesactiver.Text = "Activer/Desactiver";
            this.btnActiverDesactiver.UseVisualStyleBackColor = false;
            this.btnActiverDesactiver.Click += new System.EventHandler(this.btnActiverDesactiver_Click_1);
            // 
            // lblSatus
            // 
            this.lblSatus.AutoSize = true;
            this.lblSatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatus.Location = new System.Drawing.Point(19, 231);
            this.lblSatus.Name = "lblSatus";
            this.lblSatus.Size = new System.Drawing.Size(46, 17);
            this.lblSatus.TabIndex = 47;
            this.lblSatus.Text = "Status";
            // 
            // lblProfil
            // 
            this.lblProfil.AutoSize = true;
            this.lblProfil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfil.Location = new System.Drawing.Point(19, 186);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Size = new System.Drawing.Size(39, 17);
            this.lblProfil.TabIndex = 46;
            this.lblProfil.Text = "Profil";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifiant.Location = new System.Drawing.Point(15, 140);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(43, 17);
            this.lblIdentifiant.TabIndex = 45;
            this.lblIdentifiant.Text = "Login";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(14, 341);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(241, 41);
            this.btnResetPassword.TabIndex = 39;
            this.btnResetPassword.Text = "&Renitialiser Mot de passe";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(108, 291);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(160, 44);
            this.btnEnregistrer.TabIndex = 37;
            this.btnEnregistrer.Text = "&Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.BackColor = System.Drawing.Color.White;
            this.txtIdentifiant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentifiant.FocusedLineColor = System.Drawing.Color.Gainsboro;
            this.txtIdentifiant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdentifiant.LineColor = System.Drawing.Color.Gainsboro;
            this.txtIdentifiant.Location = new System.Drawing.Point(68, 140);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.PasswordChar = '\0';
            this.txtIdentifiant.SelectedText = "";
            this.txtIdentifiant.Size = new System.Drawing.Size(200, 26);
            this.txtIdentifiant.TabIndex = 48;
            // 
            // UserSeparator
            // 
            this.UserSeparator.LineColor = System.Drawing.Color.Gainsboro;
            this.UserSeparator.Location = new System.Drawing.Point(68, 207);
            this.UserSeparator.Name = "UserSeparator";
            this.UserSeparator.Size = new System.Drawing.Size(200, 10);
            this.UserSeparator.TabIndex = 49;
            // 
            // cbbProfil
            // 
            this.cbbProfil.BackColor = System.Drawing.Color.Transparent;
            this.cbbProfil.BaseColor = System.Drawing.Color.White;
            this.cbbProfil.BorderColor = System.Drawing.Color.Gainsboro;
            this.cbbProfil.BorderSize = 0;
            this.cbbProfil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbProfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProfil.FocusedColor = System.Drawing.Color.Empty;
            this.cbbProfil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbProfil.ForeColor = System.Drawing.Color.Black;
            this.cbbProfil.FormattingEnabled = true;
            this.cbbProfil.Items.AddRange(new object[] {
            "Vendeur",
            "Gestionnaire",
            "Admin",
            "SuperAdmin"});
            this.cbbProfil.Location = new System.Drawing.Point(68, 182);
            this.cbbProfil.Name = "cbbProfil";
            this.cbbProfil.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbProfil.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbProfil.Size = new System.Drawing.Size(200, 26);
            this.cbbProfil.TabIndex = 51;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel4);
            this.gunaShadowPanel1.Controls.Add(this.btnEffacer);
            this.gunaShadowPanel1.Controls.Add(this.cbbStatutUser);
            this.gunaShadowPanel1.Controls.Add(this.pictureBox2);
            this.gunaShadowPanel1.Controls.Add(this.gunaSeparator1);
            this.gunaShadowPanel1.Controls.Add(this.btnAjouterUser);
            this.gunaShadowPanel1.Controls.Add(this.cbbProfilUser);
            this.gunaShadowPanel1.Controls.Add(this.btnRenitialisation);
            this.gunaShadowPanel1.Controls.Add(this.gunaSeparator2);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel3);
            this.gunaShadowPanel1.Controls.Add(this.txtIdentifiantUser);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel2);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(24, 44);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Gainsboro;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(317, 401);
            this.gunaShadowPanel1.TabIndex = 31;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(92, 91);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(166, 20);
            this.gunaLabel4.TabIndex = 66;
            this.gunaLabel4.Text = "Utilisateur Du Systeme";
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEffacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnEffacer.ForeColor = System.Drawing.Color.White;
            this.btnEffacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEffacer.Location = new System.Drawing.Point(75, 274);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(102, 44);
            this.btnEffacer.TabIndex = 65;
            this.btnEffacer.Text = "&Effacer";
            this.btnEffacer.UseVisualStyleBackColor = false;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // cbbStatutUser
            // 
            this.cbbStatutUser.BackColor = System.Drawing.Color.Transparent;
            this.cbbStatutUser.BaseColor = System.Drawing.Color.White;
            this.cbbStatutUser.BorderColor = System.Drawing.Color.Gainsboro;
            this.cbbStatutUser.BorderSize = 0;
            this.cbbStatutUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbStatutUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatutUser.FocusedColor = System.Drawing.Color.Empty;
            this.cbbStatutUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbStatutUser.ForeColor = System.Drawing.Color.Black;
            this.cbbStatutUser.FormattingEnabled = true;
            this.cbbStatutUser.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbbStatutUser.Location = new System.Drawing.Point(75, 221);
            this.cbbStatutUser.Name = "cbbStatutUser";
            this.cbbStatutUser.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.cbbStatutUser.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbStatutUser.Size = new System.Drawing.Size(221, 26);
            this.cbbStatutUser.TabIndex = 64;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(129, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaSeparator1.Location = new System.Drawing.Point(75, 246);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(200, 10);
            this.gunaSeparator1.TabIndex = 63;
            // 
            // btnAjouterUser
            // 
            this.btnAjouterUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.btnAjouterUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAjouterUser.ForeColor = System.Drawing.Color.White;
            this.btnAjouterUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouterUser.Image")));
            this.btnAjouterUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterUser.Location = new System.Drawing.Point(194, 274);
            this.btnAjouterUser.Name = "btnAjouterUser";
            this.btnAjouterUser.Size = new System.Drawing.Size(102, 44);
            this.btnAjouterUser.TabIndex = 55;
            this.btnAjouterUser.Text = "&Enregistrer";
            this.btnAjouterUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjouterUser.UseVisualStyleBackColor = false;
            this.btnAjouterUser.Click += new System.EventHandler(this.btnAjouterUser_Click);
            // 
            // cbbProfilUser
            // 
            this.cbbProfilUser.BackColor = System.Drawing.Color.Transparent;
            this.cbbProfilUser.BaseColor = System.Drawing.Color.White;
            this.cbbProfilUser.BorderColor = System.Drawing.Color.Gainsboro;
            this.cbbProfilUser.BorderSize = 0;
            this.cbbProfilUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbProfilUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProfilUser.FocusedColor = System.Drawing.Color.Empty;
            this.cbbProfilUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbProfilUser.ForeColor = System.Drawing.Color.Black;
            this.cbbProfilUser.FormattingEnabled = true;
            this.cbbProfilUser.Items.AddRange(new object[] {
            "Vendeur",
            "Gestionnaire",
            "Admin",
            "SuperAdmin"});
            this.cbbProfilUser.Location = new System.Drawing.Point(75, 176);
            this.cbbProfilUser.Name = "cbbProfilUser";
            this.cbbProfilUser.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.cbbProfilUser.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbProfilUser.Size = new System.Drawing.Size(221, 26);
            this.cbbProfilUser.TabIndex = 62;
            // 
            // btnRenitialisation
            // 
            this.btnRenitialisation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.btnRenitialisation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenitialisation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnRenitialisation.ForeColor = System.Drawing.Color.White;
            this.btnRenitialisation.Location = new System.Drawing.Point(55, 339);
            this.btnRenitialisation.Name = "btnRenitialisation";
            this.btnRenitialisation.Size = new System.Drawing.Size(241, 46);
            this.btnRenitialisation.TabIndex = 56;
            this.btnRenitialisation.Text = "&Renitialiser Mot de passe";
            this.btnRenitialisation.UseVisualStyleBackColor = false;
            this.btnRenitialisation.Click += new System.EventHandler(this.btnRenitialisation_Click);
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaSeparator2.Location = new System.Drawing.Point(75, 201);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(200, 10);
            this.gunaSeparator2.TabIndex = 61;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(26, 134);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(43, 17);
            this.gunaLabel3.TabIndex = 57;
            this.gunaLabel3.Text = "Login";
            // 
            // txtIdentifiantUser
            // 
            this.txtIdentifiantUser.BackColor = System.Drawing.Color.White;
            this.txtIdentifiantUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentifiantUser.FocusedLineColor = System.Drawing.Color.Gainsboro;
            this.txtIdentifiantUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdentifiantUser.LineColor = System.Drawing.Color.Gainsboro;
            this.txtIdentifiantUser.Location = new System.Drawing.Point(75, 134);
            this.txtIdentifiantUser.Name = "txtIdentifiantUser";
            this.txtIdentifiantUser.PasswordChar = '\0';
            this.txtIdentifiantUser.SelectedText = "";
            this.txtIdentifiantUser.Size = new System.Drawing.Size(221, 26);
            this.txtIdentifiantUser.TabIndex = 60;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(30, 180);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(39, 17);
            this.gunaLabel2.TabIndex = 58;
            this.gunaLabel2.Text = "Profil";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(30, 225);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(46, 17);
            this.gunaLabel1.TabIndex = 59;
            this.gunaLabel1.Text = "Status";
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(787, 498);
            this.ControlBox = false;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.btnActiverDesactiver);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnSaveModication);
            this.Controls.Add(this.dgUtilisateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilisateur";
            this.Load += new System.EventHandler(this.frmUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgUtilisateur;
        private System.Windows.Forms.Button btnSaveModication;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button btnActiverDesactiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLogin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn txtStatus;
        private Guna.UI.WinForms.GunaComboBox cbbProfil;
        private Guna.UI.WinForms.GunaSeparator UserSeparator;
        private Guna.UI.WinForms.GunaLineTextBox txtIdentifiant;
        private Guna.UI.WinForms.GunaLabel lblSatus;
        private Guna.UI.WinForms.GunaLabel lblProfil;
        private Guna.UI.WinForms.GunaLabel lblIdentifiant;
      
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaComboBox cbbStatutUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Button btnAjouterUser;
        private Guna.UI.WinForms.GunaComboBox cbbProfilUser;
        private System.Windows.Forms.Button btnRenitialisation;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLineTextBox txtIdentifiantUser;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.Button btnEffacer;
    }
}