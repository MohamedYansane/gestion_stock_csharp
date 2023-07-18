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
    public partial class frmEditerProduit : Form
    {
        private produit product;
        private gestionstockEntities db;

        ServiceGestionStock.Service1Client serv = new ServiceGestionStock.Service1Client();
        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr x, int s, int param, int lparam);
        public frmEditerProduit(produit p, gestionstockEntities bd)
        {
            InitializeComponent();
            this.product = p;
            this.db = bd;
            
        }

        private void frmEditerProduit_Load(object sender, EventArgs e)
        {
            // pour que je puissefaire la modification dans le champ de text de mon formulaire  facilement

            /*var list = db.categorieproduit.Select(catp => new { id =catp.cat_id, Nom = catp.cat_nom }).ToList();
            cbCategorie.DisplayMember = "Nom";
            cbCategorie.ValueMember = "id";*/
            var list = serv.getListCategorie();
            cbCategorie.DisplayMember = "cat_nom";
            cbCategorie.ValueMember = "cat_id";
            cbCategorie.DataSource = list;
            txtLibelle.Text = product.Libelle;
            txtDescription.Text = product.Description;
            txtQuantite.Text = product.Quantite.ToString();
            txtQuantiteMin.Text = product.QuantiteMin.ToString();
            txtPrix.Text = product.Prix.ToString();
            cbCategorie.SelectedItem = list.SingleOrDefault(c => c.cat_id == product.cat_id);
          
           
            
        }
        private void effacer()
        {
            txtDescription.Text = string.Empty;
            txtLibelle.Text = string.Empty;
            txtPrix.Text = string.Empty;
            txtQuantite.Text = string.Empty;
            txtQuantiteMin.Text = string.Empty;
            txtPrix.Text = string.Empty;
            txtLibelle.Focus();
        }
        private bool validationChampText()
        {

            if (txtLibelle.Text.Trim() == string.Empty)
                return true;
            if (txtDescription.Text.Trim() == string.Empty)
                return true;
            if (txtQuantite.Text.Trim() == string.Empty)
                return true;
            if (txtPrix.Text.Trim() == string.Empty)
                return true;
            return false;


        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (validationChampText())
            {
                MessageBox.Show("champ de texte obligatoire", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
          
                product.Libelle = txtLibelle.Text;
                product.Description = txtDescription.Text;
                product.Quantite = double.Parse(txtQuantite.Text);
                product.QuantiteMin = double.Parse(txtQuantiteMin.Text);
                product.Prix = double.Parse(txtPrix.Text);
                product.cat_id = int.Parse(cbCategorie.SelectedValue.ToString());
              
                db.SaveChanges();
                MessageBox.Show("Le produit a été modifié avec success");
            }

        }

        
    }
}
