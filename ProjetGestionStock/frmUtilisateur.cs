using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MetierGestionStock.Model;

namespace ProjetGestionStock
{
  
    
    public partial class frmUtilisateur : Form
    {
        gestionstockEntities db = new gestionstockEntities();
        ServiceGestionStock.Service1Client serv = new ServiceGestionStock.Service1Client();

        public utilisateur superUser;
      
        public frmUtilisateur()
        {
            InitializeComponent();
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
       

       

        private void actualiser()

        {
            dgUtilisateur.DataSource = db.utilisateur.Select(user => new {
                user.id,
                user.login,
                user.profil,
                user.isActive
              
            }).ToList();
          
                

        }

        private void frmUtilisateur_Load(object sender, EventArgs e)
        {
            

            actualiser();
        }
        private void effacer()
        {
            txtIdentifiantUser.Text = string.Empty;
            
            cbbProfilUser.SelectedIndex = -1;
            cbbStatutUser.SelectedIndex = -1;
            txtIdentifiantUser.Focus();
        }

 

      

       

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
           
        }

        private void dgUtilisateur_SelectionChanged(object sender, EventArgs e)
        {
            superUser = null;
            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            superUser = db.utilisateur.SingleOrDefault(user => user.id == id);

        }

       


      

        private void btnSaveModication_Click(object sender, EventArgs e)
        {
            using (MD5 md5Hash = MD5.Create())
            {
             

                int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
             
                superUser.login = txtIdentifiantUser.Text;
                superUser.profil = cbbProfilUser.Text;
                superUser.isActive =bool.Parse(cbbStatutUser.Text);

                db.SaveChanges();
                MessageBox.Show("Utilisateur modifié avec succes");
                actualiser();
                effacer();


            }
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());

            txtIdentifiantUser.Text = dgUtilisateur.CurrentRow.Cells[1].Value.ToString();

            cbbProfilUser.Text = dgUtilisateur.CurrentRow.Cells[2].Value.ToString();
            cbbStatutUser.Text = dgUtilisateur.CurrentRow.Cells[3].Value.ToString();

        }

     

        private void btnActiverDesactiver_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(dgUtilisateur.CurrentRow.Cells[0].Value.ToString());
            /*var user = db.utilisateur.FirstOrDefault(ut => ut.id == id);
            user.isActive = user.isActive == true ? false : true;
            db.SaveChanges();*/
            serv.activerDesactiverUser(id);
            MessageBox.Show($"le statut  as été changé");
            actualiser();
        }

        private void btnRenitialisation_Click(object sender, EventArgs e)
        {
            
            frmResetPassword f = new frmResetPassword(superUser, db);
            f.ShowDialog();
            actualiser();
        }

        private void btnAjouterUser_Click(object sender, EventArgs e)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                //Returns the only element of a sequence, or a default value if the sequence is empty
                // it throws an exeption if there's more than one value 
                string loginUser = txtIdentifiant.Text;
                if (db.utilisateur.SingleOrDefault(user => user.login == loginUser) == null)
                {
                    utilisateur ut = new utilisateur();
                    ut.login = txtIdentifiantUser.Text;
                    ut.password = GetMd5Hash(md5Hash, "P@sser123");
                    ut.profil = cbbProfilUser.Text;
                    ut.isActive = bool.Parse(cbbStatutUser.Text);
                    /*db.utilisateur.Add(ut);
                    db.SaveChanges();
                    */
                    serv.addUser(ut);
                    actualiser();
                    MessageBox.Show("Insertion reussi avec succes");
                    effacer();


                }
                else
                {
                    MessageBox.Show("L'identifiant existe deja dans la base de donée", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            effacer();
        }

        private void dgUtilisateur_DefaultCellStyleChanged(object sender, EventArgs e)
        {

        }

        private void dgUtilisateur_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }
    }
}
