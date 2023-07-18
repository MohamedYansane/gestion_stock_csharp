using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using MetierGestionStock.Model;
using System.Windows.Forms;

namespace ProjetGestionStock
{
    public partial class frmAjouterApprovisionnement : Form
    {
        gestionstockEntities db = new gestionstockEntities();
       
        
        public frmAjouterApprovisionnement()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr x, int s, int param, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmAjouterApprovisionnement_Load(object sender, EventArgs e)
        {
            approvisionnement ap = new approvisionnement();
            var list = db.produit.Select(p => new { ID = p.ID, Nom = p.Libelle}).ToList();
            cbbID.DisplayMember = "Nom";
            cbbID.ValueMember = "ID";
            cbbID.DataSource = list;
            
            

           
            
            
            
             
            
            
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            approvisionnement p = new approvisionnement();
            p.idProduit = int.Parse(cbbID.SelectedValue.ToString());
            //p.qteProd = double.Parse(txtQteProdAp.Text);
            p.datePeremption = DateTime.Parse(dateP.Value.ToString("dd-MM-yyyy"));
            db.approvisionnement.Add(p);
            db.SaveChanges();
            MessageBox.Show("Date d'expiration reussi avec success");
            
        }
    }
    
}
