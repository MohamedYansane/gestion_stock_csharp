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
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }
        ServiceGestionStock.Service1Client serv = new ServiceGestionStock.Service1Client();

        private void frmTest_Load(object sender, EventArgs e)
        {
            //dgProd.DataSource= serv.getListCategorie();
            dgProd.DataSource = serv.getProdJoin();
        }
    }
}
