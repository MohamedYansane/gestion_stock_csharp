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
    public partial class frmMenuTest : Form
    {
        public frmMenuTest()
        {
            InitializeComponent();
        }
        gestionstockEntities db = new gestionstockEntities();

        ServiceGestionStock.Service1Client serv = new ServiceGestionStock.Service1Client();

        private void AfichageHeure_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblHeure.Text = DateTime.Now.ToString("H:mm:ss");
        }

        private void frmMenuTest_Load(object sender, EventArgs e)
        {
            var user = db.utilisateur.Where(users => users.isActive == true).Count().ToString();
            lblNbreUsers.Text = user;
            var product = (from p in db.produit select new { p.ID }).Count().ToString();
            lblNbreProduits.Text = product;
            var stock = db.stock.Where(s => s.status.Equals("Disponible")).Count().ToString();
            lblNbreStocks.Text = stock;
            //dgProductAndStock.DataSource = serv.getReportJoin();
            

        }

        private void lblHeure_Click(object sender, EventArgs e)
        {

        }
    }
}
