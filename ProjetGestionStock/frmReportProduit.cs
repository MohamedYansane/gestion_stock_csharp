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
using MetierGestionStock.Report;

namespace ProjetGestionStock
{
    public partial class frmReportProduit : Form
    {
        public frmReportProduit()
        {
            InitializeComponent();
        }
        gestionstockEntities db = new gestionstockEntities();

        ServiceGestionStock.Service1Client serv = new ServiceGestionStock.Service1Client();
        public DataTable GetTableProduit()
        {
            DataTable table = new DataTable();
            table.Columns.Add("produit", typeof(string));
            table.Columns.Add("quantite", typeof(double));
            table.Columns.Add("quantiteMin", typeof(double));
            table.Columns.Add("prix", typeof(double));
            table.Columns.Add("categorie", typeof(string));
           
            var App = serv.getReportJoin();
            foreach (var item in App)
            {
                table.Rows.Add(item.produit, item.quantite, item.quantiteMin, item.prix,
                item.categorie);
            }

            return table;
        }
        private void frmReportProduit_Load(object sender, EventArgs e)
        {
            rptProduitStock objRpt = new rptProduitStock();
            objRpt.SetDataSource(GetTableProduit());
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
