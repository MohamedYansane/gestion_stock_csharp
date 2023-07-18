
namespace ProjetGestionStock
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelUser = new System.Windows.Forms.Panel();
            this.lblNbreUsers = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitreUser = new System.Windows.Forms.Panel();
            this.lblUtilisateur = new System.Windows.Forms.Label();
            this.panelVente = new System.Windows.Forms.Panel();
            this.lblNbreVente = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTitreVente = new System.Windows.Forms.Panel();
            this.lblVente = new System.Windows.Forms.Label();
            this.panelStock = new System.Windows.Forms.Panel();
            this.lblNbreStocks = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelTitreStock = new System.Windows.Forms.Panel();
            this.lblStock = new System.Windows.Forms.Label();
            this.panelProduit = new System.Windows.Forms.Panel();
            this.lblNbreProduits = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelTitreProduits = new System.Windows.Forms.Panel();
            this.lblProduit = new System.Windows.Forms.Label();
            this.dgProductAndStock = new System.Windows.Forms.DataGridView();
            this.cNumProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.AffichageHeure = new System.Windows.Forms.Timer(this.components);
            this.lblProductAndStock = new System.Windows.Forms.Label();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitreUser.SuspendLayout();
            this.panelVente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTitreVente.SuspendLayout();
            this.panelStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelTitreStock.SuspendLayout();
            this.panelProduit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelTitreProduits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductAndStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.lblNbreUsers);
            this.panelUser.Controls.Add(this.pictureBox1);
            this.panelUser.Controls.Add(this.panelTitreUser);
            this.panelUser.Location = new System.Drawing.Point(22, 12);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(162, 196);
            this.panelUser.TabIndex = 0;
            // 
            // lblNbreUsers
            // 
            this.lblNbreUsers.AutoSize = true;
            this.lblNbreUsers.Location = new System.Drawing.Point(70, 157);
            this.lblNbreUsers.Name = "lblNbreUsers";
            this.lblNbreUsers.Size = new System.Drawing.Size(19, 13);
            this.lblNbreUsers.TabIndex = 1;
            this.lblNbreUsers.Text = "15";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitreUser
            // 
            this.panelTitreUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelTitreUser.Controls.Add(this.lblUtilisateur);
            this.panelTitreUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitreUser.Location = new System.Drawing.Point(0, 0);
            this.panelTitreUser.Name = "panelTitreUser";
            this.panelTitreUser.Size = new System.Drawing.Size(162, 53);
            this.panelTitreUser.TabIndex = 0;
            // 
            // lblUtilisateur
            // 
            this.lblUtilisateur.AutoSize = true;
            this.lblUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilisateur.ForeColor = System.Drawing.Color.White;
            this.lblUtilisateur.Location = new System.Drawing.Point(44, 17);
            this.lblUtilisateur.Name = "lblUtilisateur";
            this.lblUtilisateur.Size = new System.Drawing.Size(74, 16);
            this.lblUtilisateur.TabIndex = 0;
            this.lblUtilisateur.Text = "Utilisateurs";
            // 
            // panelVente
            // 
            this.panelVente.Controls.Add(this.lblNbreVente);
            this.panelVente.Controls.Add(this.pictureBox2);
            this.panelVente.Controls.Add(this.panelTitreVente);
            this.panelVente.Location = new System.Drawing.Point(284, 12);
            this.panelVente.Name = "panelVente";
            this.panelVente.Size = new System.Drawing.Size(162, 196);
            this.panelVente.TabIndex = 2;
            // 
            // lblNbreVente
            // 
            this.lblNbreVente.AutoSize = true;
            this.lblNbreVente.Location = new System.Drawing.Point(61, 157);
            this.lblNbreVente.Name = "lblNbreVente";
            this.lblNbreVente.Size = new System.Drawing.Size(55, 13);
            this.lblNbreVente.TabIndex = 1;
            this.lblNbreVente.Text = "15000000";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panelTitreVente
            // 
            this.panelTitreVente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelTitreVente.Controls.Add(this.lblVente);
            this.panelTitreVente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitreVente.Location = new System.Drawing.Point(0, 0);
            this.panelTitreVente.Name = "panelTitreVente";
            this.panelTitreVente.Size = new System.Drawing.Size(162, 53);
            this.panelTitreVente.TabIndex = 0;
            // 
            // lblVente
            // 
            this.lblVente.AutoSize = true;
            this.lblVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVente.ForeColor = System.Drawing.Color.White;
            this.lblVente.Location = new System.Drawing.Point(61, 17);
            this.lblVente.Name = "lblVente";
            this.lblVente.Size = new System.Drawing.Size(43, 16);
            this.lblVente.TabIndex = 0;
            this.lblVente.Text = "Vente";
            // 
            // panelStock
            // 
            this.panelStock.Controls.Add(this.lblNbreStocks);
            this.panelStock.Controls.Add(this.pictureBox3);
            this.panelStock.Controls.Add(this.panelTitreStock);
            this.panelStock.Location = new System.Drawing.Point(546, 12);
            this.panelStock.Name = "panelStock";
            this.panelStock.Size = new System.Drawing.Size(162, 196);
            this.panelStock.TabIndex = 3;
            // 
            // lblNbreStocks
            // 
            this.lblNbreStocks.AutoSize = true;
            this.lblNbreStocks.Location = new System.Drawing.Point(70, 157);
            this.lblNbreStocks.Name = "lblNbreStocks";
            this.lblNbreStocks.Size = new System.Drawing.Size(19, 13);
            this.lblNbreStocks.TabIndex = 1;
            this.lblNbreStocks.Text = "15";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(33, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panelTitreStock
            // 
            this.panelTitreStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelTitreStock.Controls.Add(this.lblStock);
            this.panelTitreStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitreStock.Location = new System.Drawing.Point(0, 0);
            this.panelTitreStock.Name = "panelTitreStock";
            this.panelTitreStock.Size = new System.Drawing.Size(162, 53);
            this.panelTitreStock.TabIndex = 0;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.White;
            this.lblStock.Location = new System.Drawing.Point(70, 17);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(42, 16);
            this.lblStock.TabIndex = 0;
            this.lblStock.Text = "Stock";
            // 
            // panelProduit
            // 
            this.panelProduit.Controls.Add(this.lblNbreProduits);
            this.panelProduit.Controls.Add(this.pictureBox4);
            this.panelProduit.Controls.Add(this.panelTitreProduits);
            this.panelProduit.Location = new System.Drawing.Point(808, 12);
            this.panelProduit.Name = "panelProduit";
            this.panelProduit.Size = new System.Drawing.Size(162, 196);
            this.panelProduit.TabIndex = 4;
            // 
            // lblNbreProduits
            // 
            this.lblNbreProduits.AutoSize = true;
            this.lblNbreProduits.Location = new System.Drawing.Point(70, 157);
            this.lblNbreProduits.Name = "lblNbreProduits";
            this.lblNbreProduits.Size = new System.Drawing.Size(19, 13);
            this.lblNbreProduits.TabIndex = 1;
            this.lblNbreProduits.Text = "15";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(33, 71);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(95, 69);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // panelTitreProduits
            // 
            this.panelTitreProduits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelTitreProduits.Controls.Add(this.lblProduit);
            this.panelTitreProduits.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitreProduits.Location = new System.Drawing.Point(0, 0);
            this.panelTitreProduits.Name = "panelTitreProduits";
            this.panelTitreProduits.Size = new System.Drawing.Size(162, 53);
            this.panelTitreProduits.TabIndex = 0;
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduit.ForeColor = System.Drawing.Color.White;
            this.lblProduit.Location = new System.Drawing.Point(44, 17);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(57, 16);
            this.lblProduit.TabIndex = 0;
            this.lblProduit.Text = "Produits";
            // 
            // dgProductAndStock
            // 
            this.dgProductAndStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProductAndStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgProductAndStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductAndStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProductAndStock.ColumnHeadersHeight = 30;
            this.dgProductAndStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNumProd,
            this.colProd,
            this.colQte,
            this.colCategorie});
            this.dgProductAndStock.EnableHeadersVisualStyles = false;
            this.dgProductAndStock.Location = new System.Drawing.Point(22, 255);
            this.dgProductAndStock.Name = "dgProductAndStock";
            this.dgProductAndStock.ReadOnly = true;
            this.dgProductAndStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgProductAndStock.Size = new System.Drawing.Size(505, 258);
            this.dgProductAndStock.TabIndex = 5;
            // 
            // cNumProd
            // 
            this.cNumProd.HeaderText = "N° Produit";
            this.cNumProd.Name = "cNumProd";
            this.cNumProd.ReadOnly = true;
            // 
            // colProd
            // 
            this.colProd.HeaderText = "Produit";
            this.colProd.Name = "colProd";
            this.colProd.ReadOnly = true;
            this.colProd.Width = 150;
            // 
            // colQte
            // 
            this.colQte.HeaderText = "Quantite";
            this.colQte.Name = "colQte";
            this.colQte.ReadOnly = true;
            // 
            // colCategorie
            // 
            this.colCategorie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCategorie.HeaderText = "Categorie";
            this.colCategorie.Name = "colCategorie";
            this.colCategorie.ReadOnly = true;
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeure.Location = new System.Drawing.Point(543, 231);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(417, 108);
            this.lblHeure.TabIndex = 6;
            this.lblHeure.Text = "23:53:45";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(568, 471);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(316, 39);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Samedi 09/01/2021";
            // 
            // AffichageHeure
            // 
            this.AffichageHeure.Enabled = true;
            this.AffichageHeure.Tick += new System.EventHandler(this.AffichageHeure_Tick);
            // 
            // lblProductAndStock
            // 
            this.lblProductAndStock.AutoSize = true;
            this.lblProductAndStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductAndStock.Location = new System.Drawing.Point(19, 222);
            this.lblProductAndStock.Name = "lblProductAndStock";
            this.lblProductAndStock.Size = new System.Drawing.Size(160, 15);
            this.lblProductAndStock.TabIndex = 8;
            this.lblProductAndStock.Text = "Produit Et Quantité En Stock";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(972, 563);
            this.Controls.Add(this.lblProductAndStock);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblHeure);
            this.Controls.Add(this.dgProductAndStock);
            this.Controls.Add(this.panelProduit);
            this.Controls.Add(this.panelStock);
            this.Controls.Add(this.panelVente);
            this.Controls.Add(this.panelUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitreUser.ResumeLayout(false);
            this.panelTitreUser.PerformLayout();
            this.panelVente.ResumeLayout(false);
            this.panelVente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTitreVente.ResumeLayout(false);
            this.panelTitreVente.PerformLayout();
            this.panelStock.ResumeLayout(false);
            this.panelStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelTitreStock.ResumeLayout(false);
            this.panelTitreStock.PerformLayout();
            this.panelProduit.ResumeLayout(false);
            this.panelProduit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelTitreProduits.ResumeLayout(false);
            this.panelTitreProduits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductAndStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label lblNbreUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitreUser;
        private System.Windows.Forms.Label lblUtilisateur;
        private System.Windows.Forms.Panel panelVente;
        private System.Windows.Forms.Label lblNbreVente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelTitreVente;
        private System.Windows.Forms.Label lblVente;
        private System.Windows.Forms.Panel panelStock;
        private System.Windows.Forms.Label lblNbreStocks;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelTitreStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Panel panelProduit;
        private System.Windows.Forms.Label lblNbreProduits;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelTitreProduits;
        private System.Windows.Forms.Label lblProduit;
        private System.Windows.Forms.DataGridView dgProductAndStock;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer AffichageHeure;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategorie;
        private System.Windows.Forms.Label lblProductAndStock;
    }
}