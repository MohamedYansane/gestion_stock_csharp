using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MetierGestionStock.Model;

namespace ProjetGestionStock
{
    public partial class frmPanneau : Form
    {
        gestionstockEntities db = new gestionstockEntities();

        ServiceGestionStock.Service1Client serv = new ServiceGestionStock.Service1Client();
        
        public frmPanneau()
        {
            InitializeComponent();
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr x, int s, int param, int lparam );
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblLibelle_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmPanneau_Load(object sender, EventArgs e)
        {
            //var list = db.categorieproduit.Select(catp => new { ID = catp.cat_id, Nom = catp.cat_nom }).ToList();
         
            cbCategorie.DisplayMember = "cat_nom";
            cbCategorie.ValueMember = "cat_id";
            cbCategorie.DataSource = serv.getListCategorie(); 

            /*var list = serv.getListCategorie();
            foreach(var item in list)
            {
                //String nom = item.cat_nom;
                //int id =  item.cat_id;
                cbCategorie.DisplayMember = item.cat_nom;
                cbCategorie.ValueMember = item.cat_id.ToString();
            }
           
            cbCategorie.DataSource =serv.getListCategorie();*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelInformation_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
      

        private void panelInformation_Paint(object sender, PaintEventArgs e)
        {

        }

      


        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantite_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLibelle_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrix_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantiteMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrix_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQuantite_Click(object sender, EventArgs e)
        {

        }

        private void lblQuantiteMin_Click(object sender, EventArgs e)
        {

        }

        private void lblLibelle_Click_1(object sender, EventArgs e)
        {

        }

        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            
           if(validationChampText())
           {
                MessageBox.Show("champ de texte obligatoire","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
           }
           else
            {
                produit p = new produit();
                p.Libelle = txtLibelle.Text;
                p.Description = txtDescription.Text;
                p.Quantite = double.Parse(txtQuantite.Text);
                p.QuantiteMin = double.Parse(txtQuantiteMin.Text);
                p.Prix = double.Parse(txtPrix.Text);
                p.cat_id = int.Parse(cbCategorie.SelectedValue.ToString());
                //db.produit.Add(p);
                //db.SaveChanges();
                serv.addProduit(p);
                MessageBox.Show("Le produit a été ajouté avec success");
                effacer();
            }

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

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void txtLibelle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              
                e.SuppressKeyPress = true;
                txtDescription.Select();

            }
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
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
                txtQuantiteMin.Select();

            }
        }

        private void txtQuantiteMin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;
                txtPrix.Select();

            }
        }

        private void txtPrix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;
                cbCategorie.Select();

            }
        }
    }
}
