using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// j'import la librairie pour pouvoir deplacer l'ecran
using System.Runtime.InteropServices;
using MetierGestionStock.Model;
namespace ProjetGestionStock
{
    public partial class frmMenu : Form
    {

        public string profil_name { get; set; }

        gestionstockEntities db = new gestionstockEntities();
        
       
        public frmMenu()
        {
            InitializeComponent();
            
        }
        private bool isCollapsed;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr x, int s, int param, int lparam);


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(panelMenuVertical.Width ==  173)
            {
                // a chaque clique sur mon image et que le MenuVertical est a 250 qu'il octroie une
                //nouvelle largeur de 70 sinon la valeur initiale
                this.pictureBoutique.Location = new Point (300, 12);
                panelMenuVertical.Width = 50;
            }
            else { panelMenuVertical.Width = 173; this.pictureBoutique.Location = new Point(228, 12); }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Vouliez vous fermez l'application?","Message",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        // ses variables c'est pour creer un objet de type point afin que lorsque j'elargis
        //l'ecran quelle prend la taille de l'ecran de mon ordi
        int Lx, Ly;
        private void iconElargir_Click(object sender, EventArgs e)
        {
            Lx = this.Location.X;
            Ly = this.Location.Y;
            // this.WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            icon.Visible = true;
            iconElargir.Visible = false;
           
        }

        private void iconReduire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void iconRestaurer_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Lx, Ly);
            //this.WindowState = FormWindowState.Normal;
            //je l'initialise avec la taille initiale de mon winform
            this.Size = new Size(885, 481);
            icon.Visible = false;
            iconElargir.Visible = true;


        }


        private void btnStock_Click(object sender, EventArgs e)
        {
            pageRedirection(new frmStock());
        }
        private void pageRedirection(object FormPage)
        {
            if(this.panelContent.Controls.Count > 0)
                this.panelContent.Controls.RemoveAt(0);
            Form form = FormPage as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(form);
            this.panelContent.Tag = form;
            form.Show();
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            pageRedirection(new frmProduit());
        }



        private void btnApprovisionnement_Click(object sender, EventArgs e)
        {
            pageRedirection(new frmApprovisionnement());
            
        }

        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
            pageRedirection(new frmUtilisateur());
        }

        

       


       private void iconMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconRestaurer_Click_1(object sender, EventArgs e)
        {
            this.Location = new Point(Lx, Ly);
            //this.WindowState = FormWindowState.Normal;
            //je l'initialise avec la taille initiale de mon winform
            this.Size = new Size(1174, 650);
            icon.Visible = true;
            iconAgrandir.Visible = true;
            //iconMini.Visible = true;
            iconRestaurer.Visible = false;
        }

        private void iconAgrandir_Click(object sender, EventArgs e)
        {
            Lx = this.Location.X;
            Ly = this.Location.Y;
            // this.WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            icon.Visible = true;
            iconAgrandir.Visible = false;
       
            iconRestaurer.Visible = true;


        }

        private void iconFermer_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Vouliez vous fermer l'application", "FERMTURE DE L'ONGLET", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                frmLogin f = new frmLogin();
                f.Show();
                this.Hide();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(panelMenuVertical.Width == 189)
            {
                panelMenuVertical.Width = 62;
            }
            else { panelMenuVertical.Width = 189; }
        }

        private void Produit_Load(object sender, EventArgs e)
        {

            pictureBox2_Click(null, e);
            var user = db.utilisateur.Where(users => users.login == profil_name).FirstOrDefault();
            if(user.profil == "Gestionnaire")
            {
                btnUtilisateur.Visible = false;
                //btnStock.Visible = true;
              
            }
            else if(user.profil.Equals("Admin"))
            {
                btnApprovisionnement.Visible = false;
                btnCategorie.Visible = false;
                btnProduit.Visible = false;
                
            }
            else if(user.profil.Equals("Vendeur"))
            {
                btnUtilisateur.Visible = false;
                

            }
            else
            {
                btnUtilisateur.Visible = true;
               // btnStock.Visible = false;
            }
         
        }

      

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            pageRedirection(new frmCategorie());
        }

        private void btnCompte_Click(object sender, EventArgs e)
        {
            pageRedirection(new frmCompteUser());
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsers_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {

        }

  

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                panelVente.Height += 10;
                if (panelVente.Size == panelVente.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
               
            }
            else
            {
                panelVente.Height -= 10;
                if (panelVente.Size == panelVente.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnAchat_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Achat");
            pageRedirection(new frmAchat());
        }

        private void btnHistorique_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Historique");
        }

        private void btnVente_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           //pageRedirection(new frmMenuPrincipal());
           pageRedirection(new frmMenuTest());
        }

        private void panelMenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCopyright_Click(object sender, EventArgs e)
        {

        }

        private void BarreTitre_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
