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
    public partial class frmProduit : Form
    {
        private produit produitSelectionne;
       
        gestionstockEntities db = new gestionstockEntities();

        ServiceGestionStock.Service1Client serv = new ServiceGestionStock.Service1Client();

       


        /// je declare mon objet de type form comme etant global afin de pouvoir l'instancier facilement
        frmPanneau form = new frmPanneau();

        
        
        public frmProduit()
        {
            InitializeComponent();
            
           
        }
      
        private void ProduitForm_Load(object sender, EventArgs e)
        {
            actualiser();
            //dgProduit.Columns["approvisionnement"].Visible = false;
            //dgProduit.Columns["cat_nom"].Visible = false;
            
            

        }
   

        private void actualiser()
        {
            /*var result = (from pr in db.produit
                          join catp in db.categorieproduit
                          on pr.cat_id equals catp.cat_id
                          select new
                          {
                              pr.ID,
                              pr.Libelle,
                              pr.Description,
                              pr.Quantite,
                              pr.QuantiteMin,
                              pr.Prix,
                              catp.cat_nom
                          }).ToList();*/
            //dgProduit.DataSource = db.produit.ToList();
            //dgProduit.DataSource = result;
            //dgProduit.DataSource = serv.getListProduit();
           dgProduit.DataSource = serv.getProdJoin();
        }
      

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            produitSelectionne = null;
            produitSelectionne = db.produit.SingleOrDefault(produit => produit.ID == id);
            DialogResult dr = MessageBox.Show("Vouliez vous supprimez le produit: " + produitSelectionne.Libelle,"Suppression", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                /* db.produit.Remove(produitSelectionne);
                 db.SaveChanges();*/
                serv.supprimerProduit(id);
                MessageBox.Show("Suppression effectue avec success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualiser();
            }
        }

       

  

        private void btnAjouter_Click_2(object sender, EventArgs e)
        {

            frmPanneau f = new frmPanneau();
            f.ShowDialog();
            actualiser();
            
        }

   

        private void btnModifier_Click(object sender, EventArgs e)
        {
            frmEditerProduit f = new frmEditerProduit(produitSelectionne, db);
            f.ShowDialog();
            actualiser();
            


           
        }

    
        // je cree l'evenement selection d'une cellule on peut dire
        private void dgProduit_SelectionChanged(object sender, EventArgs e)
        {
            produitSelectionne = null;
            int id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            produitSelectionne = db.produit.SingleOrDefault(p => p.ID == id);
        
        }


        private void dgProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*private void btnRechercher_Click(object sender, EventArgs e)
        {
            var result = (from pr in db.produit
                           join catp in db.categorieproduit
                           on pr.cat_id equals catp.cat_id
                           select new
                           {
                               pr.ID,
                               pr.Libelle,
                               pr.Description,
                               pr.Quantite,
                               pr.QuantiteMin,
                               pr.Prix,
                               catp.cat_nom
                           }).ToList();
             //dgProduit.DataSource = db.produit.ToList();


             if (!string.IsNullOrEmpty(txtRechercher.Text))
             {
                 result = result.Where(a => a.Libelle.ToUpper().Contains(txtRechercher.Text.ToUpper())).ToList();
             }


             dgProduit.DataSource =result;

            //dgProduit.DataSource = serv.getProdJoin();

        }*/

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            actualiser();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            frmReportProduit f = new frmReportProduit();
            f.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgProduit.DataSource = serv.searchProduit(txtSearch.Text);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgProduit.DataSource = serv.search(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgProduit.DataSource = serv.searchProduit(txtSearch.Text);
            }
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgProduit.DataSource = serv.searchProduit(txtSearch.Text);

        }
    }
}
