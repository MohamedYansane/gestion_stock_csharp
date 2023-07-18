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
    public partial class frmEditerStock : Form
    {
   
        public frmEditerStock(stock s, gestionstockEntities bd)
        {
            InitializeComponent();
            this.stockProduit = s;
            this.db = bd;
        }
        private gestionstockEntities db;
        private stock stockProduit;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr x, int s, int param, int lparam);
        private void frmEditerStock_Load(object sender, EventArgs e)
        {

            txtNumProduit.Text = stockProduit.CodeProduit.ToString();
            txtProduit.Text = stockProduit.nomProduit;
            txtQuantite.Text = stockProduit.Quantite.ToString();
            cbbStatus.Text = stockProduit.status.ToString();
            
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            stockProduit.CodeProduit = int.Parse(txtNumProduit.Text);
            stockProduit.nomProduit = txtProduit.Text;
            stockProduit.Quantite = double.Parse(txtQuantite.Text);
            stockProduit.status = cbbStatus.Text;
            stockProduit.DateStockage = DateTime.Parse(DateTime.Now.ToLongDateString());
            db.SaveChanges();
            MessageBox.Show("Modification reussi avec success");

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
