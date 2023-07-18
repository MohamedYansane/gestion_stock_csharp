
namespace ProjetGestionStock
{
    partial class frmStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            this.dgStock = new System.Windows.Forms.DataGridView();
            this.txtIDent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProdNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStatu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveModication = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgStock
            // 
            this.dgStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgStock.ColumnHeadersHeight = 30;
            this.dgStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIDent,
            this.txtProduit,
            this.txtProdNom,
            this.txtDate,
            this.txtQStock,
            this.txtStatu});
            this.dgStock.EnableHeadersVisualStyles = false;
            this.dgStock.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgStock.Location = new System.Drawing.Point(56, 21);
            this.dgStock.Name = "dgStock";
            this.dgStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgStock.Size = new System.Drawing.Size(813, 183);
            this.dgStock.TabIndex = 0;
            this.dgStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStock_CellContentClick);
            this.dgStock.SelectionChanged += new System.EventHandler(this.dgStock_SelectionChanged);
            // 
            // txtIDent
            // 
            this.txtIDent.DataPropertyName = "ID";
            this.txtIDent.HeaderText = "Stock N°";
            this.txtIDent.Name = "txtIDent";
            // 
            // txtProduit
            // 
            this.txtProduit.DataPropertyName = "CodeProduit";
            this.txtProduit.HeaderText = "N°Produit";
            this.txtProduit.Name = "txtProduit";
            // 
            // txtProdNom
            // 
            this.txtProdNom.DataPropertyName = "nomProduit";
            this.txtProdNom.HeaderText = "Produit";
            this.txtProdNom.Name = "txtProdNom";
            this.txtProdNom.Width = 150;
            // 
            // txtDate
            // 
            this.txtDate.DataPropertyName = "DateStockage";
            this.txtDate.HeaderText = "Date Stockage";
            this.txtDate.Name = "txtDate";
            this.txtDate.Width = 150;
            // 
            // txtQStock
            // 
            this.txtQStock.DataPropertyName = "Quantite";
            this.txtQStock.HeaderText = "Quantite";
            this.txtQStock.Name = "txtQStock";
            // 
            // txtStatu
            // 
            this.txtStatu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtStatu.DataPropertyName = "status";
            this.txtStatu.HeaderText = "Status";
            this.txtStatu.Name = "txtStatu";
            // 
            // btnSaveModication
            // 
            this.btnSaveModication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveModication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.btnSaveModication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSaveModication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSaveModication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveModication.ForeColor = System.Drawing.Color.White;
            this.btnSaveModication.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveModication.Image")));
            this.btnSaveModication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveModication.Location = new System.Drawing.Point(740, 210);
            this.btnSaveModication.Name = "btnSaveModication";
            this.btnSaveModication.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSaveModication.Size = new System.Drawing.Size(129, 41);
            this.btnSaveModication.TabIndex = 16;
            this.btnSaveModication.Text = "&Modifier";
            this.btnSaveModication.UseVisualStyleBackColor = false;
            this.btnSaveModication.Click += new System.EventHandler(this.btnSaveModication_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.btnAjouter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAjouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouter.Image")));
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Location = new System.Drawing.Point(56, 210);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAjouter.Size = new System.Drawing.Size(129, 41);
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 600);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSaveModication);
            this.Controls.Add(this.dgStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStock";
            this.Text = "frmStock";
            this.Load += new System.EventHandler(this.frmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgStock;
        private System.Windows.Forms.Button btnSaveModication;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIDent;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProdNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtStatu;
    }
}