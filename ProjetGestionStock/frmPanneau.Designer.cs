
namespace ProjetGestionStock
{
    partial class frmPanneau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPanneau));
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtQuantiteMin = new System.Windows.Forms.TextBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblQuantiteMin = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.panelInformation = new System.Windows.Forms.Panel();
            this.lblIDcat = new System.Windows.Forms.Label();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.erreurEnregistrementProduit = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erreurEnregistrementProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.btnEnregistrer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEnregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(123, 279);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(91, 39);
            this.btnEnregistrer.TabIndex = 23;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(130, 189);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(192, 20);
            this.txtPrix.TabIndex = 22;
            this.txtPrix.TextChanged += new System.EventHandler(this.txtPrix_TextChanged);
            this.txtPrix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrix_KeyDown);
            // 
            // txtQuantiteMin
            // 
            this.txtQuantiteMin.Location = new System.Drawing.Point(130, 156);
            this.txtQuantiteMin.Name = "txtQuantiteMin";
            this.txtQuantiteMin.Size = new System.Drawing.Size(190, 20);
            this.txtQuantiteMin.TabIndex = 21;
            this.txtQuantiteMin.TextChanged += new System.EventHandler(this.txtQuantiteMin_TextChanged);
            this.txtQuantiteMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantiteMin_KeyDown);
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(130, 125);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(192, 20);
            this.txtQuantite.TabIndex = 20;
            this.txtQuantite.TextChanged += new System.EventHandler(this.txtQuantite_TextChanged);
            this.txtQuantite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantite_KeyDown);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(130, 93);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(192, 20);
            this.txtDescription.TabIndex = 19;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(130, 61);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(192, 20);
            this.txtLibelle.TabIndex = 18;
            this.txtLibelle.TextChanged += new System.EventHandler(this.txtLibelle_TextChanged);
            this.txtLibelle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLibelle_KeyDown);
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibelle.Location = new System.Drawing.Point(12, 61);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(48, 16);
            this.lblLibelle.TabIndex = 13;
            this.lblLibelle.Text = "Libelle";
            this.lblLibelle.Click += new System.EventHandler(this.lblLibelle_Click_1);
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPrix.Location = new System.Drawing.Point(12, 193);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(30, 16);
            this.lblPrix.TabIndex = 17;
            this.lblPrix.Text = "Prix";
            this.lblPrix.Click += new System.EventHandler(this.lblPrix_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDescription.Location = new System.Drawing.Point(12, 94);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 16);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // lblQuantiteMin
            // 
            this.lblQuantiteMin.AutoSize = true;
            this.lblQuantiteMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblQuantiteMin.Location = new System.Drawing.Point(12, 160);
            this.lblQuantiteMin.Name = "lblQuantiteMin";
            this.lblQuantiteMin.Size = new System.Drawing.Size(114, 16);
            this.lblQuantiteMin.TabIndex = 16;
            this.lblQuantiteMin.Text = "Quantite Minimale";
            this.lblQuantiteMin.Click += new System.EventHandler(this.lblQuantiteMin_Click);
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblQuantite.Location = new System.Drawing.Point(12, 127);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(57, 16);
            this.lblQuantite.TabIndex = 15;
            this.lblQuantite.Text = "Quantite";
            this.lblQuantite.Click += new System.EventHandler(this.lblQuantite_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(231, 279);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(91, 39);
            this.btnAnnuler.TabIndex = 24;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.Color.White;
            this.lblInformation.Location = new System.Drawing.Point(120, 9);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(136, 16);
            this.lblInformation.TabIndex = 3;
            this.lblInformation.Text = "Formulaire d\'insertion";
            // 
            // panelInformation
            // 
            this.panelInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.panelInformation.Controls.Add(this.lblInformation);
            this.panelInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInformation.Location = new System.Drawing.Point(0, 0);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Size = new System.Drawing.Size(343, 41);
            this.panelInformation.TabIndex = 2;
            this.panelInformation.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInformation_Paint);
            this.panelInformation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelInformation_MouseDown);
            // 
            // lblIDcat
            // 
            this.lblIDcat.AutoSize = true;
            this.lblIDcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblIDcat.Location = new System.Drawing.Point(12, 219);
            this.lblIDcat.Name = "lblIDcat";
            this.lblIDcat.Size = new System.Drawing.Size(67, 16);
            this.lblIDcat.TabIndex = 27;
            this.lblIDcat.Text = "Categorie";
            // 
            // cbCategorie
            // 
            this.cbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(133, 219);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(187, 21);
            this.cbCategorie.TabIndex = 28;
            this.cbCategorie.SelectedIndexChanged += new System.EventHandler(this.cbCategorie_SelectedIndexChanged);
            // 
            // erreurEnregistrementProduit
            // 
            this.erreurEnregistrementProduit.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPanneau
            // 
            this.AcceptButton = this.btnEnregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(343, 361);
            this.ControlBox = false;
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.lblIDcat);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.txtQuantiteMin);
            this.Controls.Add(this.panelInformation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQuantiteMin);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtPrix);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPanneau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.frmPanneau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInformation.ResumeLayout(false);
            this.panelInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erreurEnregistrementProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtPrix;
        public System.Windows.Forms.TextBox txtQuantiteMin;
        public System.Windows.Forms.TextBox txtQuantite;
        public System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.TextBox txtLibelle;
        public System.Windows.Forms.Label lblQuantiteMin;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Panel panelInformation;
        private System.Windows.Forms.Label lblIDcat;
        public System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.ErrorProvider erreurEnregistrementProduit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}