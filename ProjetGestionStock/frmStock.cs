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
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }
        gestionstockEntities db = new gestionstockEntities();
        ServiceGestionStock.Service1Client serv = new ServiceGestionStock.Service1Client();
        private stock stockProduit;
        private void dgStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void actualiser()
        {
            /* var r = (from p in db.produit
                      join s in db.stock on p.ID equals s.CodeProduit
                      select new
                      {
                          s.ID,
                          p.Libelle,
                          s.DateStockage,
                          p.Quantite
                      }).ToList();
             dgStock.DataSource = r;*/
            dgStock.DataSource = serv.getListStocks() ;
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            actualiser();
           
        }

        private void btnSaveModication_Click(object sender, EventArgs e)
        {
            frmEditerStock f = new frmEditerStock(stockProduit,db);
            f.ShowDialog();
            actualiser();

        }

        private void dgStock_SelectionChanged(object sender, EventArgs e)
        {
            stockProduit = null;
            int id = int.Parse(dgStock.CurrentRow.Cells[0].Value.ToString());
            stockProduit = db.stock.SingleOrDefault(s => s.ID == id);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmAjouterStock f = new frmAjouterStock();
            f.Show();
            actualiser();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            stockProduit = null;
            int id = int.Parse(dgStock.CurrentRow.Cells[0].Value.ToString());
            stockProduit = db.stock.SingleOrDefault(s => s.ID == id);
            DialogResult dr = MessageBox.Show($"Vouliez vous supprimer le stock du produit {stockProduit.nomProduit}", "SUPPRESSION", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                db.stock.Remove(stockProduit);
                db.SaveChanges();
                MessageBox.Show("Suppression effectue avec success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualiser();
            }
        }
    }
}
