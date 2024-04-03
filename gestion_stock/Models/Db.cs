using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace gestion_stock.Models
{
    internal class Db
    {
        private MySqlConnection connection;
        private static Db instance =null;
        private Db()
        {
         
          this.connection = new MySqlConnection("Server=localhost;Port=3307;User ID=root;Password=;Database=gestionstock");
          
        }

        public static Db getInstance()
        {
            if (instance == null)
            {
                Db.instance = new Db();
            }
            
            return Db.instance;
        }
        async public void OpenAsync()
        {
            //this.connection.Open();
            await connection.OpenAsync();
        }

        public void Open()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            if (instance != null && connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }
        public MySqlConnection GetConnection()
        {
            this.Open();
            return this.connection;
        }
        public void closeConnection()
        {
            this.connection?.Close();
        }

    }
}
