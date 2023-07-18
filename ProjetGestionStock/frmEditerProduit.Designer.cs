
namespace ProjetGestionStock
{
    partial class frmEditerProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditerProduit));
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.lblIDcat = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.txtQuantiteMin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblQuantiteMin = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblPrix = new System.Windows.Forms.Label();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEdition = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCategorie
            // 
            this.cbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(133, 206);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(187, 21);
            this.cbCategorie.TabIndex = 43;
            // 
            // lblIDcat
            // 
            this.lblIDcat.AutoSize = true;
            this.lblIDcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblIDcat.Location = new System.Drawing.Point(12, 206);
            this.lblIDcat.Name = "lblIDcat";
            this.lblIDcat.Size = new System.Drawing.Size(67, 16);
            this.lblIDcat.TabIndex = 42;
            this.lblIDcat.Text = "Categorie";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(130, 48);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(192, 20);
            this.txtLibelle.TabIndex = 34;
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibelle.Location = new System.Drawing.Point(12, 48);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(48, 16);
            this.lblLibelle.TabIndex = 29;
            this.lblLibelle.Text = "Libelle";
            // 
            // txtQuantiteMin
            // 
            this.txtQuantiteMin.Location = new System.Drawing.Point(130, 143);
            this.txtQuantiteMin.Name = "txtQuantiteMin";
            this.txtQuantiteMin.Size = new System.Drawing.Size(190, 20);
            this.txtQuantiteMin.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // lblQuantiteMin
            // 
            this.lblQuantiteMin.AutoSize = true;
            this.lblQuantiteMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblQuantiteMin.Location = new System.Drawing.Point(12, 147);
            this.lblQuantiteMin.Name = "lblQuantiteMin";
            this.lblQuantiteMin.Size = new System.Drawing.Size(114, 16);
            this.lblQuantiteMin.TabIndex = 32;
            this.lblQuantiteMin.Text = "Quantite Minimale";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDescription.Location = new System.Drawing.Point(12, 81);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(76, 16);
            this.lblDescription.TabIndex = 30;
            this.lblDescription.Text = "Description";
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.btnModifier.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(123, 266);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(91, 39);
            this.btnModifier.TabIndex = 39;
            this.btnModifier.Text = "Editer";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblPrix.Location = new System.Drawing.Point(12, 180);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(30, 16);
            this.lblPrix.TabIndex = 33;
            this.lblPrix.Text = "Prix";
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(130, 112);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(192, 20);
            this.txtQuantite.TabIndex = 36;
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblQuantite.Location = new System.Drawing.Point(12, 114);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(57, 16);
            this.lblQuantite.TabIndex = 31;
            this.lblQuantite.Text = "Quantite";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(130, 80);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(192, 20);
            this.txtDescription.TabIndex = 35;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(231, 266);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(91, 39);
            this.btnAnnuler.TabIndex = 40;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(130, 176);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(192, 20);
            this.txtPrix.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.lblEdition);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 44);
            this.panel1.TabIndex = 44;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdition.ForeColor = System.Drawing.Color.White;
            this.lblEdition.Location = new System.Drawing.Point(107, 19);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(127, 16);
            this.lblEdition.TabIndex = 0;
            this.lblEdition.Text = "Formulaire d\'Edition";
            // 
            // frmEditerProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(350, 373);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.lblIDcat);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.txtQuantiteMin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQuantiteMin);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtPrix);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditerProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditerProduit";
            this.Load += new System.EventHandler(this.frmEditerProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.Label lblIDcat;
        public System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label lblLibelle;
        public System.Windows.Forms.TextBox txtQuantiteMin;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblQuantiteMin;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblPrix;
        public System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.Label lblQuantite;
        public System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAnnuler;
        public System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Label lblEdition;
        public System.Windows.Forms.Panel panel1;
    }
}