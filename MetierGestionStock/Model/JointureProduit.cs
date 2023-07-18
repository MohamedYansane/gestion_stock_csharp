using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetierGestionStock.Model
{
    public class JointureProduit
    {
        public int id { get; set; }
        public string libelle { get; set; }
        public string description { get; set; }
        public double quantite { get; set; }
        public double quantiteMin { get; set; }
        public double prix { get; set; }
        public string catNom { get; set; }
    }
}