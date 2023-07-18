
namespace ProjetGestionStock
{
    partial class frmCategorie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCatName = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.dgCategorie = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCatNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.txtSearchCategorie = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatName.Location = new System.Drawing.Point(465, 50);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(40, 16);
            this.lblCatName.TabIndex = 0;
            this.lblCatName.Text = "Nom ";
            this.lblCatName.Click += new System.EventHandler(this.lblCatName_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(511, 49);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(120, 20);
            this.txtNom.TabIndex = 1;
            this.txtNom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // dgCategorie
            // 
            this.dgCategorie.AllowUserToAddRows = false;
            this.dgCategorie.AllowUserToDeleteRows = false;
            this.dgCategorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCategorie.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgCategorie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCategorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgCategorie.ColumnHeadersHeight = 30;
            this.dgCategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtID,
            this.txtCatNom});
            this.dgCategorie.EnableHeadersVisualStyles = false;
            this.dgCategorie.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgCategorie.Location = new System.Drawing.Point(12, 50);
            this.dgCategorie.MultiSelect = false;
            this.dgCategorie.Name = "dgCategorie";
            this.dgCategorie.ReadOnly = true;
            this.dgCategorie.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgCategorie.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgCategorie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCategorie.Size = new System.Drawing.Size(447, 150);
            this.dgCategorie.TabIndex = 2;
            this.dgCategorie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtID
            // 
            this.txtID.DataPropertyName = "cat_id";
            this.txtID.HeaderText = "N° Categorie";
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            // 
            // txtCatNom
            // 
            this.txtCatNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtCatNom.DataPropertyName = "cat_nom";
            this.txtCatNom.HeaderText = "Nom";
            this.txtCatNom.Name = "txtCatNom";
            this.txtCatNom.ReadOnly = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(511, 75);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(120, 23);
            this.btnEnregistrer.TabIndex = 3;
            this.btnEnregistrer.Text = "Ajouter";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(379, 206);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(80, 36);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.btnSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnSelectionner.Location = new System.Drawing.Point(12, 206);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(80, 36);
            this.btnSelectionner.TabIndex = 7;
            this.btnSelectionner.Text = "&Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = false;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(250)))));
            this.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEffacer.ForeColor = System.Drawing.Color.White;
            this.btnEffacer.Location = new System.Drawing.Point(201, 206);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(80, 36);
            this.btnEffacer.TabIndex = 8;
            this.btnEffacer.Text = "&Effacer";
            this.btnEffacer.UseVisualStyleBackColor = false;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // txtSearchCategorie
            // 
            this.txtSearchCategorie.BaseColor = System.Drawing.Color.White;
            this.txtSearchCategorie.BorderColor = System.Drawing.Color.Silver;
            this.txtSearchCategorie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCategorie.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearchCategorie.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearchCategorie.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearchCategorie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchCategorie.Location = new System.Drawing.Point(12, 13);
            this.txtSearchCategorie.Name = "txtSearchCategorie";
            this.txtSearchCategorie.PasswordChar = '\0';
            this.txtSearchCategorie.SelectedText = "";
            this.txtSearchCategorie.Size = new System.Drawing.Size(335, 30);
            this.txtSearchCategorie.TabIndex = 10;
            this.txtSearchCategorie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchCategorie_KeyPress);
            // 
            // frmCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(749, 262);
            this.Controls.Add(this.txtSearchCategorie);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dgCategorie);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblCatName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorie";
            this.Load += new System.EventHandler(this.frmCategorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DataGridView dgCategorie;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCatNom;
        private Guna.UI.WinForms.GunaTextBox txtSearchCategorie;
    }
}