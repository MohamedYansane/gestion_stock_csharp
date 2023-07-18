using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MetierGestionStock.Model;

namespace MetierGestionStock
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        gestionstockEntities db = new gestionstockEntities();
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public bool addProduit(produit p)
        {
            bool rep = false;
            try
            {
                db.produit.Add(p);
                db.SaveChanges();
                rep = true;
            }
            catch (Exception e)
            {

                Console.WriteLine("Ajout non reussi à cause de: " + e.Message);
            }
            return rep;
        }
        public List<JointureProduit> getProdJoin()
        {
            var result =(from pr in db.produit
             join catp in db.categorieproduit
             on pr.cat_id equals catp.cat_id
             select new JointureProduit
             {
                 id= pr.ID,
                 libelle =pr.Libelle,
                 description=pr.Description,
                 quantite=pr.Quantite,
                 quantiteMin=pr.QuantiteMin,
                 prix = pr.Prix,
                 catNom=catp.cat_nom
             }).ToList();
            return result;
        }
        public List<produit> getListProduit()
        {

            return db.produit.ToList();
        }

        public List<stock> getListStocks()
        {
            return db.stock.ToList();
        }
        public bool supprimerProduit(int id)

        {
            bool rep = false;
            try
            {
                var p = db.produit.Find(id);
                db.produit.Remove(p);
                db.SaveChanges();
                rep = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Suppression non effectué à cause de: " + e.Message);
            }
            return rep;
        }

        public void modifierProduit()
        {
            db.SaveChanges();
        }
        public bool editerProduit(produit p)
        {
            bool rep =  false;
            try
            {
                produit ps = new produit();
                ps.Libelle = p.Libelle;
                ps.Description = p.Description;
                ps.Quantite = p.Quantite;
                ps.QuantiteMin = p.QuantiteMin;
                ps.Prix = p.Prix;
                ps.cat_id = p.cat_id;
                db.SaveChanges();
                rep = true;
            }catch(Exception e )
            {
                Console.WriteLine("Modification non effectué à cause de: " + e.Message);

            }
            return rep;

        }
        


        public List<categorieproduit> getListCategorie()
        {
            return db.categorieproduit.ToList();
        }

        public List<ReportProduitStock> getReportJoin()
        {
            var result = (from p in db.produit
                          join catp in
                          db.categorieproduit on p.cat_id equals catp.cat_id
                          select new ReportProduitStock
                          {
                              produit = p.Libelle,
                              quantite = p.Quantite,
                              quantiteMin = p.QuantiteMin,
                              prix = p.Prix,
                              categorie = catp.cat_nom
                          }).ToList();
            return result;
        }

        public List<JointureProduit>searchProduit(string libelle)
        {
            var result = getProdJoin();
            if (!string.IsNullOrEmpty(libelle))
            {
                result = result.Where(a => a.libelle.ToUpper().Contains(libelle.ToUpper())).ToList();
            }
            if (!string.IsNullOrEmpty(libelle))
            {
                result = result.Where(a => a.description.ToUpper().Contains(libelle.ToUpper())).ToList();
            }
            return result;


        }
        public void activerDesactiverUser(int id)
        {
            var user = db.utilisateur.FirstOrDefault(ut => ut.id == id);
            user.isActive = user.isActive == true ? false : true;
            db.SaveChanges();
            

        }

        public bool addUser(utilisateur user)
        {
            bool rep = false;
            try
            {
                db.utilisateur.Add(user);
                db.SaveChanges();
                rep = true;
            }
            catch (Exception e)
            {

                Console.WriteLine("Ajout non reussi à cause de: " + e.Message);
            }
            return rep;
        }

        public List<JointureProduit>search(string s)
        {
            var result = getProdJoin();
            result.Where(p => p.libelle.ToUpper().Contains(s.ToUpper()) || p.description.ToUpper().Contains(s.ToUpper())).ToList();
            return result;
        }

        public List<categorieproduit> searchCategorie(string txt)
        {
            var result = db.categorieproduit.Where(c => c.cat_nom.ToUpper().Contains(txt.ToUpper())).ToList();
            return result;
        }

    }
}
