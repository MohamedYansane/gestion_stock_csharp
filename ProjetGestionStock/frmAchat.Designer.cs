
namespace ProjetGestionStock
{
    partial class frmAchat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAchat));
            this.dgAchat = new Guna.UI.WinForms.GunaDataGridView();
            this.colProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaDateAchat = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lblTotal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDateFacturation = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAjouter = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnImprimer = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgAchat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAchat
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgAchat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAchat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAchat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAchat.BackgroundColor = System.Drawing.Color.White;
            this.dgAchat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAchat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgAchat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAchat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgAchat.ColumnHeadersHeight = 21;
            this.dgAchat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProd,
            this.colQ,
            this.colPrix,
            this.colM});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAchat.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgAchat.EnableHeadersVisualStyles = false;
            this.dgAchat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgAchat.Location = new System.Drawing.Point(96, 99);
            this.dgAchat.Name = "dgAchat";
            this.dgAchat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgAchat.RowHeadersVisible = false;
            this.dgAchat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAchat.Size = new System.Drawing.Size(436, 178);
            this.dgAchat.TabIndex = 0;
            this.dgAchat.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgAchat.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgAchat.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgAchat.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgAchat.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgAchat.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgAchat.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgAchat.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgAchat.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgAchat.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgAchat.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgAchat.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgAchat.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgAchat.ThemeStyle.HeaderStyle.Height = 21;
            this.dgAchat.ThemeStyle.ReadOnly = false;
            this.dgAchat.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgAchat.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgAchat.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgAchat.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgAchat.ThemeStyle.RowsStyle.Height = 22;
            this.dgAchat.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgAchat.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colProd
            // 
            this.colProd.HeaderText = "Produit";
            this.colProd.Name = "colProd";
            // 
            // colQ
            // 
            this.colQ.HeaderText = "Quantite";
            this.colQ.Name = "colQ";
            // 
            // colPrix
            // 
            this.colPrix.HeaderText = "Prix Par Unite";
            this.colPrix.Name = "colPrix";
            // 
            // colM
            // 
            this.colM.HeaderText = "Montant";
            this.colM.Name = "colM";
            // 
            // gunaDateAchat
            // 
            this.gunaDateAchat.BaseColor = System.Drawing.Color.White;
            this.gunaDateAchat.BorderColor = System.Drawing.Color.Silver;
            this.gunaDateAchat.CustomFormat = null;
            this.gunaDateAchat.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateAchat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateAchat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateAchat.ForeColor = System.Drawing.Color.Black;
            this.gunaDateAchat.Location = new System.Drawing.Point(96, 63);
            this.gunaDateAchat.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateAchat.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateAchat.Name = "gunaDateAchat";
            this.gunaDateAchat.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateAchat.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateAchat.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateAchat.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateAchat.Size = new System.Drawing.Size(194, 30);
            this.gunaDateAchat.TabIndex = 1;
            this.gunaDateAchat.Text = "mardi 12 janvier 2021";
            this.gunaDateAchat.Value = new System.DateTime(2021, 1, 12, 22, 34, 16, 818);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(470, 283);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 20);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total 00";
            // 
            // lblDateFacturation
            // 
            this.lblDateFacturation.AutoSize = true;
            this.lblDateFacturation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFacturation.Location = new System.Drawing.Point(93, 33);
            this.lblDateFacturation.Name = "lblDateFacturation";
            this.lblDateFacturation.Size = new System.Drawing.Size(118, 17);
            this.lblDateFacturation.TabIndex = 4;
            this.lblDateFacturation.Text = "Date Facturation";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.AnimationHoverSpeed = 0.07F;
            this.btnAjouter.AnimationSpeed = 0.03F;
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.btnAjouter.BorderColor = System.Drawing.Color.White;
            this.btnAjouter.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAjouter.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAjouter.CheckedForeColor = System.Drawing.Color.White;
            this.btnAjouter.CheckedImage = null;
            this.btnAjouter.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAjouter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAjouter.FocusedColor = System.Drawing.Color.Empty;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouter.Image")));
            this.btnAjouter.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAjouter.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAjouter.Location = new System.Drawing.Point(427, 51);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAjouter.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAjouter.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAjouter.OnHoverImage = null;
            this.btnAjouter.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAjouter.OnPressedColor = System.Drawing.Color.Black;
            this.btnAjouter.Size = new System.Drawing.Size(105, 42);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImprimer.AnimationHoverSpeed = 0.07F;
            this.btnImprimer.AnimationSpeed = 0.03F;
            this.btnImprimer.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.btnImprimer.BorderColor = System.Drawing.Color.Black;
            this.btnImprimer.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnImprimer.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnImprimer.CheckedForeColor = System.Drawing.Color.White;
            this.btnImprimer.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnImprimer.CheckedImage")));
            this.btnImprimer.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnImprimer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnImprimer.FocusedColor = System.Drawing.Color.Empty;
            this.btnImprimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImprimer.ForeColor = System.Drawing.Color.White;
            this.btnImprimer.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimer.Image")));
            this.btnImprimer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnImprimer.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnImprimer.Location = new System.Drawing.Point(96, 283);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnImprimer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnImprimer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnImprimer.OnHoverImage = null;
            this.btnImprimer.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnImprimer.OnPressedColor = System.Drawing.Color.Black;
            this.btnImprimer.Size = new System.Drawing.Size(102, 42);
            this.btnImprimer.TabIndex = 6;
            this.btnImprimer.Text = "Imprimer";
            // 
            // frmAchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblDateFacturation);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gunaDateAchat);
            this.Controls.Add(this.dgAchat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAchat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Achat";
            this.Load += new System.EventHandler(this.frmAchat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAchat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn colM;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateAchat;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTotal;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDateFacturation;
        private Guna.UI.WinForms.GunaAdvenceButton btnAjouter;
        private Guna.UI.WinForms.GunaAdvenceButton btnImprimer;
    }
}