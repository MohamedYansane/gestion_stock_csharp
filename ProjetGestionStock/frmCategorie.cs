using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetierGestionStock.Model;
namespace ProjetGestionStock
{
    public partial class frmCategorie : Form
    {
        gestionstockEntities db = new gestionstockEntities();

        ServiceGestionStock.Service1Client serv = new ServiceGestionStock.Service1Client();
        
        public frmCategorie()
        {
            InitializeComponent();
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void lblCatName_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCategorie_Load(object sender, EventArgs e)
        {
            //dgCategorie.DataSource = db.categorieproduit.Select(cat => new {cat.cat_id, cat.cat_nom }).ToList();
            dgCategorie.DataSource = serv.getListCategorie();
        }
        private bool validationTextBox()
        {
           
            if (txtNom.Text.Trim() == String.Empty)
                return true;
            return false;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
           if(validationTextBox())
           {
                MessageBox.Show("champ de texteobligatoire", "", MessageBoxButtons.OK,MessageBoxIcon.Warning);
           }
           else
           {
                categorieproduit cat = new categorieproduit();
                cat.cat_nom = txtNom.Text;
                db.categorieproduit.Add(cat);
                db.SaveChanges();
                //serv.addCategorie(cat);
                effacer();
                MessageBox.Show("Insertion reussi avec success");

           }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if(dgCategorie.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgCategorie.CurrentRow.Cells[0].Value.ToString());
                categorieproduit cat = db.categorieproduit.Find(id);
                cat.cat_nom = txtNom.Text;
                db.SaveChanges();
                effacer();
                MessageBox.Show("Modification reussi avec success");
                
            }
            else
            {
                MessageBox.Show("Aucune ligne n'a été selectionné");
            }
        }
        private void effacer()
        {
            txtNom.Text = string.Empty;
            dgCategorie.DataSource = db.categorieproduit.ToList();
            txtNom.Focus();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            txtNom.Text = dgCategorie.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgCategorie.CurrentRow.Cells[0].Value.ToString());
            categorieproduit cat = db.categorieproduit.Find(id);
            db.categorieproduit.Remove(cat);
            db.SaveChanges();
            MessageBox.Show("Suppression effectuée avec success");
            effacer();
            
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtNom.Clear();
            txtSearchCategorie.Clear();
            dgCategorie.DataSource = serv.getListCategorie();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var cat = db.categorieproduit.ToList();
            if(!string.IsNullOrEmpty(txtNom.Text))
            {
                cat = cat.Where(c => c.cat_nom.ToUpper().Contains(txtNom.Text.ToUpper())).ToList();
            }
            dgCategorie.DataSource = cat;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgCategorie.DataSource = db.categorieproduit.Select(cat => new { cat.cat_id, cat.cat_nom }).ToList();
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtSearchCategorie_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgCategorie.DataSource = serv.searchCategorie(txtSearchCategorie.Text);
        }
    }
}
