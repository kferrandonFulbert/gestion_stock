using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_stock.oPOO
{
    internal class Fournisseur
    {
        private int ? _id;
        private string _Nom;
        private string _Adresse;
        private string _Tel;
        private string _Mail;

        public Fournisseur(string unNom, string uneAdresse, string unTel, string unMail, int ? unId   ) {
            this.Id = unId;
            this.Tel = unTel;
            this.Mail = unMail;
            this.Nom = unNom;
            this.Adresse = uneAdresse;
        }

        public int? Id { get => _id; set => _id = value; }
        public string Nom { get => _Nom; set => _Nom = value; }
        public string Adresse { get => _Adresse; set => _Adresse = value; }
        public string Tel { get => _Tel; set => _Tel = value; }
        public string Mail { get => _Mail; set => _Mail = value; }
    }
}
