using gestion_stock.oPOO;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_stock.Models
{
    internal class Fournisseur
    {
        private Db _FrsDb;
        private gestion_stock.oPOO.Fournisseur _frs;
        public Fournisseur()
        {
            this._FrsDb = Db.getInstance();
        }
        public Fournisseur(gestion_stock.oPOO.Fournisseur unFournisseur)
        {
            this._FrsDb = Db.getInstance();
            this._frs = unFournisseur;
        }

        public MySqlDataReader getFournisseurs()
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM fournisseur;", this._FrsDb.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();
            
            return reader;
        }

        public void addFournisseur(gestion_stock.oPOO.Fournisseur unFournisseur = null)
        {
            if (unFournisseur != null)
            {
                this._frs = unFournisseur;
            }

            string sql = "INSERT INTO Fournisseur (nom, Adresse, Tel, Mail) " +
               "VALUES (@nom,@adresse,@tel, @mail)";
           
            MySqlCommand cmd = new MySqlCommand(sql, this._FrsDb.GetConnection());
    
            cmd.Parameters.AddWithValue("@nom", this._frs.Nom);
            cmd.Parameters.AddWithValue("@adresse", this._frs.Adresse);
            cmd.Parameters.AddWithValue("@tel", this._frs.Tel);
            cmd.Parameters.AddWithValue("@mail", this._frs.Mail);
        
            this._FrsDb.Open(); 
            cmd.ExecuteNonQuery();
            
        }

    }
}
