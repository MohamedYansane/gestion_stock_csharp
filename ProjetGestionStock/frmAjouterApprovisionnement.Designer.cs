
namespace ProjetGestionStock
{
    partial class frmAjouterApprovisionnement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjouterApprovisionnement));
            this.dateP = new System.Windows.Forms.DateTimePicker();
            this.cbbID = new System.Windows.Forms.ComboBox();
            this.lblIdentifiantProduit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblDatePeremption = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPanelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateP
            // 
            this.dateP.CustomFormat = "dd-MM-yyyy";
            this.dateP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateP.Location = new System.Drawing.Point(175, 82);
            this.dateP.Name = "dateP";
            this.dateP.Size = new System.Drawing.Size(201, 20);
            this.dateP.TabIndex = 75;
            // 
            // cbbID
            // 
            this.cbbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbID.FormattingEnabled = true;
            this.cbbID.Location = new System.Drawing.Point(174, 51);
            this.cbbID.Name = "cbbID";
            this.cbbID.Size = new System.Drawing.Size(201, 21);
            this.cbbID.TabIndex = 73;
            // 
            // lblIdentifiantProduit
            // 
            this.lblIdentifiantProduit.AutoSize = true;
            this.lblIdentifiantProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifiantProduit.Location = new System.Drawing.Point(12, 51);
            this.lblIdentifiantProduit.Name = "lblIdentifiantProduit";
            this.lblIdentifiantProduit.Size = new System.Drawing.Size(77, 16);
            this.lblIdentifiantProduit.TabIndex = 65;
            this.lblIdentifiantProduit.Text = "ID_Produit_";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.btnAjouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(174, 108);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(91, 39);
            this.btnAjouter.TabIndex = 69;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblDatePeremption
            // 
            this.lblDatePeremption.AutoSize = true;
            this.lblDatePeremption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDatePeremption.Location = new System.Drawing.Point(13, 82);
            this.lblDatePeremption.Name = "lblDatePeremption";
            this.lblDatePeremption.Size = new System.Drawing.Size(109, 16);
            this.lblDatePeremption.TabIndex = 67;
            this.lblDatePeremption.Text = "Date Peremption";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(285, 108);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(91, 39);
            this.btnAnnuler.TabIndex = 70;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.lblPanelName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 44);
            this.panel1.TabIndex = 77;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblPanelName
            // 
            this.lblPanelName.AutoSize = true;
            this.lblPanelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelName.ForeColor = System.Drawing.Color.White;
            this.lblPanelName.Location = new System.Drawing.Point(138, 15);
            this.lblPanelName.Name = "lblPanelName";
            this.lblPanelName.Size = new System.Drawing.Size(126, 18);
            this.lblPanelName.TabIndex = 0;
            this.lblPanelName.Text = "Formulaire d\'ajout";
            // 
            // frmAjouterApprovisionnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(406, 202);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateP);
            this.Controls.Add(this.cbbID);
            this.Controls.Add(this.lblIdentifiantProduit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblDatePeremption);
            this.Controls.Add(this.btnAnnuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAjouterApprovisionnement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAjouterApprovisionnement";
            this.Load += new System.EventHandler(this.frmAjouterApprovisionnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateP;
        public System.Windows.Forms.ComboBox cbbID;
        private System.Windows.Forms.Label lblIdentifiantProduit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblDatePeremption;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPanelName;
    }
}