
namespace ProjetGestionStock
{
    partial class frmAjouterArticle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjouterArticle));
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblNomProduit = new System.Windows.Forms.Label();
            this.panelInformation = new System.Windows.Forms.Panel();
            this.lblInformation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.panelInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(185, 176);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(74, 39);
            this.btnAnnuler.TabIndex = 83;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblPrix.Location = new System.Drawing.Point(8, 108);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(63, 13);
            this.lblPrix.TabIndex = 81;
            this.lblPrix.Text = "Prix Unitaire";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(78, 53);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(185, 20);
            this.txtProductName.TabIndex = 80;
            // 
            // lblNomProduit
            // 
            this.lblNomProduit.AutoSize = true;
            this.lblNomProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNomProduit.Location = new System.Drawing.Point(8, 56);
            this.lblNomProduit.Name = "lblNomProduit";
            this.lblNomProduit.Size = new System.Drawing.Size(65, 13);
            this.lblNomProduit.TabIndex = 79;
            this.lblNomProduit.Text = "Nom Produit";
            // 
            // panelInformation
            // 
            this.panelInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.panelInformation.Controls.Add(this.lblInformation);
            this.panelInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInformation.Location = new System.Drawing.Point(0, 0);
            this.panelInformation.Name = "panelInformation";
            this.panelInformation.Size = new System.Drawing.Size(282, 41);
            this.panelInformation.TabIndex = 72;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.ForeColor = System.Drawing.Color.White;
            this.lblInformation.Location = new System.Drawing.Point(120, 9);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(88, 16);
            this.lblInformation.TabIndex = 3;
            this.lblInformation.Text = "Ajout d\'article";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.btnEnregistrer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEnregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(77, 176);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(85, 39);
            this.btnEnregistrer.TabIndex = 75;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(78, 79);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(185, 20);
            this.txtQuantite.TabIndex = 74;
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblQuantite.Location = new System.Drawing.Point(8, 82);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(47, 13);
            this.lblQuantite.TabIndex = 73;
            this.lblQuantite.Text = "Quantite";
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(77, 105);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(185, 20);
            this.txtPrix.TabIndex = 84;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(77, 131);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(185, 20);
            this.txtMontant.TabIndex = 86;
            this.txtMontant.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblMontant.Location = new System.Drawing.Point(8, 134);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(46, 13);
            this.lblMontant.TabIndex = 85;
            this.lblMontant.Text = "Montant";
            this.lblMontant.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmAjouterArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 261);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblNomProduit);
            this.Controls.Add(this.panelInformation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.lblQuantite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAjouterArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAjouterArticle";
            this.panelInformation.ResumeLayout(false);
            this.panelInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblPrix;
        public System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblNomProduit;
        private System.Windows.Forms.Panel panelInformation;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEnregistrer;
        public System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.Label lblQuantite;
        public System.Windows.Forms.TextBox txtPrix;
        public System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label lblMontant;
    }
}