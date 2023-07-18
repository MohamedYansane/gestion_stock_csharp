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
    public partial class frmAchat : Form
    {
        public frmAchat()
        {
            InitializeComponent();
        }
        gestionstockEntities db = new gestionstockEntities();

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmAjouterArticle f = new frmAjouterArticle();
            f.Show();
        }

        private void frmAchat_Load(object sender, EventArgs e)
        {
            //dgAchat.DataSource = db.produit.Select(p => new { p.Libelle, p.Quantite, p.Prix, p.QuantiteMin }).ToList();
        }
    }
}
