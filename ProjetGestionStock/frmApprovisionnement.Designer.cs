
namespace ProjetGestionStock
{
    partial class frmApprovisionnement
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
            this.dgApprovisionement = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgApprovisionement)).BeginInit();
            this.SuspendLayout();
            // 
            // dgApprovisionement
            // 
            this.dgApprovisionement.AllowUserToAddRows = false;
            this.dgApprovisionement.AllowUserToDeleteRows = false;
            this.dgApprovisionement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgApprovisionement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgApprovisionement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgApprovisionement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgApprovisionement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgApprovisionement.ColumnHeadersHeight = 40;
            this.dgApprovisionement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtP,
            this.txtQ,
            this.txtD,
            this.txtAp});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgApprovisionement.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgApprovisionement.EnableHeadersVisualStyles = false;
            this.dgApprovisionement.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgApprovisionement.Location = new System.Drawing.Point(12, 12);
            this.dgApprovisionement.Name = "dgApprovisionement";
            this.dgApprovisionement.ReadOnly = true;
            this.dgApprovisionement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgApprovisionement.Size = new System.Drawing.Size(633, 165);
            this.dgApprovisionement.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(10, 183);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(116, 40);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModifier.AutoSize = true;
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(294, 183);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(125, 40);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(523, 183);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(122, 40);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // txtId
            // 
            this.txtId.DataPropertyName = "idApp";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.txtId.DefaultCellStyle = dataGridViewCellStyle2;
            this.txtId.HeaderText = "N° Appro";
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            // 
            // txtP
            // 
            this.txtP.DataPropertyName = "idProduit";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.txtP.DefaultCellStyle = dataGridViewCellStyle3;
            this.txtP.HeaderText = "Produit";
            this.txtP.Name = "txtP";
            this.txtP.ReadOnly = true;
            // 
            // txtQ
            // 
            this.txtQ.DataPropertyName = "qteProduit";
            this.txtQ.HeaderText = "Quantite";
            this.txtQ.Name = "txtQ";
            this.txtQ.ReadOnly = true;
            // 
            // txtD
            // 
            this.txtD.DataPropertyName = "datePeremption";
            this.txtD.HeaderText = "Date Peremption";
            this.txtD.MinimumWidth = 10;
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtD.Width = 150;
            // 
            // txtAp
            // 
            this.txtAp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtAp.DataPropertyName = "dateApp";
            this.txtAp.HeaderText = "Date d\'Approvisionnement";
            this.txtAp.Name = "txtAp";
            this.txtAp.ReadOnly = true;
            // 
            // frmApprovisionnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(696, 600);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgApprovisionement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmApprovisionnement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmApprovisionnement";
            this.Load += new System.EventHandler(this.frmApprovisionnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgApprovisionement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgApprovisionement;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtP;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtD;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAp;
    }
}