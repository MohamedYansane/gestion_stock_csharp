using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetierGestionStock.Model
{
    public class ReportProduitStock
    {
     
        public string produit { get; set; }
        public double quantite { get; set; }
        public double quantiteMin { get; set; }
        public double prix { get; set; }
        public string categorie { get; set; }
    }
}