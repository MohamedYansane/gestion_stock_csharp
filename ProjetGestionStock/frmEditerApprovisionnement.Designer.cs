
namespace ProjetGestionStock
{
    partial class frmEditerApprovisionnement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditerApprovisionnement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEdition = new System.Windows.Forms.Label();
            this.lblIdentifiantProduit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblQuantiteMin = new System.Windows.Forms.Label();
            this.lblQteProd = new System.Windows.Forms.Label();
            this.btnEditer = new System.Windows.Forms.Button();
            this.lblDatePeremption = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cbbIdproduct = new System.Windows.Forms.ComboBox();
            this.cbbQteProduct = new System.Windows.Forms.ComboBox();
            this.datePeremp = new System.Windows.Forms.DateTimePicker();
            this.dateAp = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.lblEdition);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 44);
            this.panel1.TabIndex = 60;
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
            // lblIdentifiantProduit
            // 
            this.lblIdentifiantProduit.AutoSize = true;
            this.lblIdentifiantProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifiantProduit.Location = new System.Drawing.Point(12, 63);
            this.lblIdentifiantProduit.Name = "lblIdentifiantProduit";
            this.lblIdentifiantProduit.Size = new System.Drawing.Size(66, 16);
            this.lblIdentifiantProduit.TabIndex = 45;
            this.lblIdentifiantProduit.Text = "ID Produit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // lblQuantiteMin
            // 
            this.lblQuantiteMin.AutoSize = true;
            this.lblQuantiteMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblQuantiteMin.Location = new System.Drawing.Point(12, 162);
            this.lblQuantiteMin.Name = "lblQuantiteMin";
            this.lblQuantiteMin.Size = new System.Drawing.Size(156, 16);
            this.lblQuantiteMin.TabIndex = 48;
            this.lblQuantiteMin.Text = "Date Approvisionnement";
            // 
            // lblQteProd
            // 
            this.lblQteProd.AutoSize = true;
            this.lblQteProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblQteProd.Location = new System.Drawing.Point(12, 96);
            this.lblQteProd.Name = "lblQteProd";
            this.lblQteProd.Size = new System.Drawing.Size(102, 16);
            this.lblQteProd.TabIndex = 46;
            this.lblQteProd.Text = "Quantite Produit";
            // 
            // btnEditer
            // 
            this.btnEditer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(254)))));
            this.btnEditer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEditer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnEditer.ForeColor = System.Drawing.Color.White;
            this.btnEditer.Location = new System.Drawing.Point(174, 200);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(91, 39);
            this.btnEditer.TabIndex = 55;
            this.btnEditer.Text = "Editer";
            this.btnEditer.UseVisualStyleBackColor = false;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // lblDatePeremption
            // 
            this.lblDatePeremption.AutoSize = true;
            this.lblDatePeremption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDatePeremption.Location = new System.Drawing.Point(12, 129);
            this.lblDatePeremption.Name = "lblDatePeremption";
            this.lblDatePeremption.Size = new System.Drawing.Size(109, 16);
            this.lblDatePeremption.TabIndex = 47;
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
            this.btnAnnuler.Location = new System.Drawing.Point(284, 200);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(91, 39);
            this.btnAnnuler.TabIndex = 56;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // cbbIdproduct
            // 
            this.cbbIdproduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbIdproduct.FormattingEnabled = true;
            this.cbbIdproduct.Location = new System.Drawing.Point(174, 63);
            this.cbbIdproduct.Name = "cbbIdproduct";
            this.cbbIdproduct.Size = new System.Drawing.Size(201, 21);
            this.cbbIdproduct.TabIndex = 61;
            // 
            // cbbQteProduct
            // 
            this.cbbQteProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbQteProduct.FormattingEnabled = true;
            this.cbbQteProduct.Location = new System.Drawing.Point(174, 96);
            this.cbbQteProduct.Name = "cbbQteProduct";
            this.cbbQteProduct.Size = new System.Drawing.Size(201, 21);
            this.cbbQteProduct.TabIndex = 62;
            this.cbbQteProduct.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // datePeremp
            // 
            this.datePeremp.CustomFormat = "dd-MM-yyyy";
            this.datePeremp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePeremp.Location = new System.Drawing.Point(174, 129);
            this.datePeremp.Name = "datePeremp";
            this.datePeremp.Size = new System.Drawing.Size(201, 20);
            this.datePeremp.TabIndex = 63;
            // 
            // dateAp
            // 
            this.dateAp.CustomFormat = "dd-MM-yyyy";
            this.dateAp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAp.Location = new System.Drawing.Point(174, 162);
            this.dateAp.Name = "dateAp";
            this.dateAp.RightToLeftLayout = true;
            this.dateAp.Size = new System.Drawing.Size(201, 20);
            this.dateAp.TabIndex = 64;
            // 
            // frmEditerApprovisionnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(387, 298);
            this.Controls.Add(this.dateAp);
            this.Controls.Add(this.datePeremp);
            this.Controls.Add(this.cbbQteProduct);
            this.Controls.Add(this.cbbIdproduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblIdentifiantProduit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQuantiteMin);
            this.Controls.Add(this.lblQteProd);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.lblDatePeremption);
            this.Controls.Add(this.btnAnnuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditerApprovisionnement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditerApprovisionnement";
            this.Load += new System.EventHandler(this.frmEditerApprovisionnement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.Label lblIdentifiantProduit;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblQuantiteMin;
        private System.Windows.Forms.Label lblQteProd;
        private System.Windows.Forms.Button btnEditer;
        private System.Windows.Forms.Label lblDatePeremption;
        private System.Windows.Forms.Button btnAnnuler;
        public System.Windows.Forms.ComboBox cbbIdproduct;
        public System.Windows.Forms.ComboBox cbbQteProduct;
        private System.Windows.Forms.DateTimePicker datePeremp;
        private System.Windows.Forms.DateTimePicker dateAp;
    }
}