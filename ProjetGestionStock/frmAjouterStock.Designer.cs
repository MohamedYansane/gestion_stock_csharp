
namespace ProjetGestionStock
{
    partial class frmAjouterStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjouterStock));
            this.lblIDcat = new System.Windows.Forms.Label();
            this.panelInformation = new System.Windows.Forms.Panel();
            this.lblInformation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.txtNumProduit = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblNomProduit = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.AffichageErreur = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.panelInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AffichageErreur)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDcat
            // 
            this.lblIDcat.AutoSize = true;
            this.lblIDcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblIDcat.Location = new System.Drawing.Point(5, 60);
            this.lblIDcat.Name = "lblIDcat";
            this.lblIDcat.Size = new System.Drawing.Size(55, 13);
            this.lblIDcat.TabIndex = 43;
            this.lblIDcat.Text = "N° Produit";
            // 
            // panelInformation
            // 
            this.panelInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.panelInformation.Controls.Add(this.lblInformation);
            this.panelInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInformation.Location = new System.Drawing.Point(0, 0);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Size = new System.Drawing.Size(288, 41);
            this.panelInformation.TabIndex = 29;
            this.panelInformation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelInformation_MouseDown);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.Color.White;
            this.lblInformation.Location = new System.Drawing.Point(75, 9);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(136, 16);
            this.lblInformation.TabIndex = 3;
            this.lblInformation.Text = "Formulaire d\'insertion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.btnEnregistrer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEnregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(78, 167);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(85, 39);
            this.btnEnregistrer.TabIndex = 40;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(75, 109);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(185, 20);
            this.txtQuantite.TabIndex = 37;
            this.txtQuantite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantite_KeyDown);
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblQuantite.Location = new System.Drawing.Point(5, 112);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(47, 13);
            this.lblQuantite.TabIndex = 32;
            this.lblQuantite.Text = "Quantite";
            // 
            // txtNumProduit
            // 
            this.txtNumProduit.Location = new System.Drawing.Point(75, 57);
            this.txtNumProduit.Name = "txtNumProduit";
            this.txtNumProduit.Size = new System.Drawing.Size(185, 20);
            this.txtNumProduit.TabIndex = 44;
            this.txtNumProduit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumProduit_KeyDown);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(75, 83);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(185, 20);
            this.txtProductName.TabIndex = 46;
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // lblNomProduit
            // 
            this.lblNomProduit.AutoSize = true;
            this.lblNomProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNomProduit.Location = new System.Drawing.Point(5, 86);
            this.lblNomProduit.Name = "lblNomProduit";
            this.lblNomProduit.Size = new System.Drawing.Size(65, 13);
            this.lblNomProduit.TabIndex = 45;
            this.lblNomProduit.Text = "Nom Produit";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblStatus.Location = new System.Drawing.Point(5, 138);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 47;
            this.lblStatus.Text = "Status";
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Disponible",
            "Non-Disponible"});
            this.cbbStatus.Location = new System.Drawing.Point(76, 138);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(184, 21);
            this.cbbStatus.TabIndex = 48;
            // 
            // AffichageErreur
            // 
            this.AffichageErreur.ContainerControl = this;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(186, 167);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(74, 39);
            this.btnAnnuler.TabIndex = 71;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click_1);
            // 
            // frmAjouterStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 243);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblNomProduit);
            this.Controls.Add(this.txtNumProduit);
            this.Controls.Add(this.lblIDcat);
            this.Controls.Add(this.panelInformation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.lblQuantite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAjouterStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAjouterStock";
            this.Load += new System.EventHandler(this.frmAjouterStock_Load);
            this.panelInformation.ResumeLayout(false);
            this.panelInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AffichageErreur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIDcat;
        private System.Windows.Forms.Panel panelInformation;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEnregistrer;
        public System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.Label lblQuantite;
        public System.Windows.Forms.TextBox txtNumProduit;
        public System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblNomProduit;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.ErrorProvider AffichageErreur;
        private System.Windows.Forms.Button btnAnnuler;
    }
}