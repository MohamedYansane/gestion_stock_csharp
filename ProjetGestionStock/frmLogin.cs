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
using System.Runtime.InteropServices;
using MetierGestionStock.Model;

namespace ProjetGestionStock
{
    public partial class frmLogin : Form
    {
     
        gestionstockEntities db = new gestionstockEntities();
 
        public frmLogin()
        {
            InitializeComponent();
        }
        public static string personne_connecte { get; set; }
        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr x, int s, int param, int lparam);
        private void frmLogin_Load(object sender, EventArgs e)
        {

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
        // Verify a hash against a string.
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);
            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

     
        private void btnConexion_Click(object sender, EventArgs e)
        {
            var utilisateur = db.utilisateur.Where(a => a.login ==
txtIdentifiant.Text && a.isActive == true).FirstOrDefault();
            string hash = utilisateur != null ? utilisateur.password : string.Empty;
            using (MD5 md5Hash = MD5.Create())
            {
                if (VerifyMd5Hash(md5Hash, txtPassword.Text, hash))
                {
                    //comme chaque utilisateur du system n'a qu'un seul profil dans ma bd 
                    //donc j'ecris selement firstofdefault

                   
                    frmMenu f = new frmMenu();
                    f.profil_name = txtIdentifiant.Text;
                   
                    personne_connecte = txtIdentifiant.Text;
                    f.Show();
                    this.Hide();
                }
                else
                {
                    lblMsg.Text = "Identifiant ou mot de passe incorrect";
                }
            }
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbQuiiter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRenitialiser_Click(object sender, EventArgs e)
        {
            txtIdentifiant.Clear();
            txtPassword.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAficher.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtIdentifiant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
                txtPassword.Select();
                
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
                btnConexion.Select();

            }
        }
    }
}
