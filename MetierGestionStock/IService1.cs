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
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: ajoutez vos opérations de service ici

        [OperationContract]
        List<produit> getListProduit();

        [OperationContract]

        void modifierProduit();

        [OperationContract]
        bool addProduit(produit p);

        [OperationContract]
        bool supprimerProduit(int id);

        [OperationContract]
        List<categorieproduit> getListCategorie();

        [OperationContract]
        List<JointureProduit> getProdJoin();

        [OperationContract]
        List<ReportProduitStock> getReportJoin();

        [OperationContract]
        List<stock> getListStocks();

        [OperationContract]
        List<JointureProduit> searchProduit(string libelle);

        [OperationContract]
        void activerDesactiverUser(int id);

        [OperationContract]
        bool addUser(utilisateur user);

        [OperationContract]
        List<JointureProduit> search(string s);

        [OperationContract]
        List<categorieproduit> searchCategorie(string txt);
    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
