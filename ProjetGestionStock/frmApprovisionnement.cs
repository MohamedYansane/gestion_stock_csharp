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
    public partial class frmApprovisionnement : Form
    {
        public frmApprovisionnement()
        {
            InitializeComponent();
        }
        gestionstockEntities db = new gestionstockEntities();
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmAjouterApprovisionnement f = new frmAjouterApprovisionnement();
            f.Show();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            frmEditerApprovisionnement f = new frmEditerApprovisionnement();
            f.Show();
        }

        private void frmApprovisionnement_Load(object sender, EventArgs e)
        {
            
        }
    }
}
