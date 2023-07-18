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
using System.Runtime.InteropServices;
namespace ProjetGestionStock
{
    public partial class frmAjouterStock : Form
    {
        public frmAjouterStock()
        {
            InitializeComponent();
        }
        gestionstockEntities db = new gestionstockEntities();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr x, int s, int param, int lparam);
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            controleChampTexte();
            stock s = new stock();
            s.CodeProduit = int.Parse(txtNumProduit.Text);
            s.nomProduit = txtProductName.Text;
            s.Quantite = double.Parse(txtQuantite.Text);
            s.status = cbbStatus.Text;
            s.DateStockage = DateTime.Parse(DateTime.Now.ToLongDateString());
            db.stock.Add(s);
            db.SaveChanges();
            MessageBox.Show("Nouveau stock ajouté avec success");
            effacer();
        }
        private void controleChampTexte()
        {
            if(string.IsNullOrWhiteSpace(txtNumProduit.Text))
            {
                AffichageErreur.Clear();
                AffichageErreur.SetError(txtNumProduit, "Champ de texte Obligatoire");
            }
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                AffichageErreur.Clear();
                AffichageErreur.SetError(txtProductName, "Champ de texte Obligatoire");
            }
            if (string.IsNullOrWhiteSpace(txtQuantite.Text))
            {
                AffichageErreur.Clear();
                AffichageErreur.SetError(txtQuantite, "Champ de texte Obligatoire");
            }
            if (cbbStatus.SelectedIndex == -1)
            {
                AffichageErreur.Clear();
                AffichageErreur.SetError(cbbStatus, "Champ de texte Obligatoire");
            }
           
        }
        private void effacer()
        {
            txtNumProduit.Text = string.Empty;
            txtProductName.Text = string.Empty;
            cbbStatus.SelectedIndex = -1;
            txtQuantite.Text = string.Empty;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void frmAjouterStock_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelInformation_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtNumProduit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;
                txtProductName.Select();

            }
        }

        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;
                txtQuantite.Select();

            }
        }

        private void txtQuantite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;
                cbbStatus.Select();

            }
        }
    }
}
