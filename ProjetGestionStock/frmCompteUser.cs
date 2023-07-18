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
    public partial class frmCompteUser : Form
    {
        public frmCompteUser()
        {
            InitializeComponent();
        }
        gestionstockEntities db = new gestionstockEntities();

        public utilisateur user = null;
        
        private void actualiser()
        {
            var result = (from user in db.utilisateur where user.login == frmLogin.personne_connecte
                          select new
                          {
                              fonction = user.profil,
                              login = user.login,
                              status = user.isActive
                          }).SingleOrDefault();
            lblLogin.Text = result.login ;
            lblResultF.Text = result.fonction;
            if(result.status)
            {
                lblResultS.Text = "Actif";
            }
        }



        private void frmCompteUser_Load(object sender, EventArgs e)
        {
            actualiser();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmResetUser f = new frmResetUser();
            f.Show();
        }
    }
}
