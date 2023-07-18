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
using System.Security.Cryptography;
using MetierGestionStock.Model;

namespace ProjetGestionStock
{
    public partial class frmResetPassword : Form
    {
       
        private utilisateur User;
        private gestionstockEntities db;
       
        public frmResetPassword(utilisateur user,gestionstockEntities bd)
        {
            InitializeComponent();
            this.User = user;
            this.db = bd;
        }
        // j'importe la librairie interopservices afin de pouvoir creer la fonction release
        //capture pour deplacer mes formulaires
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr x, int s, int param, int lparam);
        private void frmResetPassword_Load(object sender, EventArgs e)
        {
           
            txtLogin.Text = User.login;
            
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
        /* using (MD5 md5Hash = MD5.Create())
         {
                
         // ut.password = GetMd5Hash(md5Hash, "P@sser123");
           }*/

      

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       

        

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void checkBoxAf_CheckedChanged_1(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = txtNewPassword.UseSystemPasswordChar == true ? false : true;
            txtConfirmPassword.UseSystemPasswordChar = txtConfirmPassword.UseSystemPasswordChar == true ? false : true;
        }

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            //var login = txtLogin.Text;
            var user = db.utilisateur.FirstOrDefault(ut => ut.login == txtLogin.Text);
            //string hash = user != null ? user.password : string.Empty;
            using (MD5 md5Hash = MD5.Create())
            {

                if (user == null)
                {
                    MessageBox.Show("Oups désolé cet utilisateur n'existe pas dans le systeme");
                }
               
                if(txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Oups désolé y'a eu un erreur veuillez réessayer à nouveau");
                }

                else
                {
                    User.password = GetMd5Hash(md5Hash, txtConfirmPassword.Text);
                    db.SaveChanges();
                    txtLogin.Clear();
                    txtNewPassword.Clear();
                    txtConfirmPassword.Clear();
                    txtLogin.Focus();
                    DialogResult dr = MessageBox.Show("Mot de passe modifié avec succes pourque les c" +
                    "hangements soit effectuésil va falloir se deconnecter", "Information",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {

                        Application.Restart();


                    }
                }



            }


        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
