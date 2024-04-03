using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestion_stock.Models;
using gestion_stock.oPOO;
using MySqlConnector;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace gestion_stock
{
    public partial class frm_frs : Form
    {
        private gestion_stock.Models.Fournisseur _frs;
        public frm_frs()
        {
            InitializeComponent();
            this._frs = new gestion_stock.Models.Fournisseur();
        }

        private void init_frm()
        {
            grid_frs.Rows.Clear();
            var reader = this._frs.getFournisseurs();
            while (reader.Read())
            {
                grid_frs.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
            }
            grid_frs.AutoResizeColumn(3, DataGridViewAutoSizeColumnMode.DisplayedCells);

        }
        private void frm_frs_Load(object sender, EventArgs e)
        {
            init_frm();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            gestion_stock.oPOO.Fournisseur frs = new gestion_stock.oPOO.Fournisseur(txtNom.Text, txtAdresse.Text, txtTel.Text, txtMail.Text, null);
            this._frs.addFournisseur(frs);
            init_frm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> lst = new List<string>();
            foreach(DataGridViewRow f in grid_frs.Rows)
            {
                if (f.Cells["nom"].Value!=null)
                {
                    string nom = f.Cells["nom"].Value.ToString();
                    string adresse = f.Cells[1].Value.ToString();
                    gestion_stock.oPOO.Fournisseur frs = new gestion_stock.oPOO.Fournisseur(nom, adresse, f.Cells[2].Value.ToString(), f.Cells[3].Value.ToString(), 0);
                    lst.Add(JsonConvert.SerializeObject(frs));
                }
            }
            string obj = JsonConvert.SerializeObject(lst);
            using (StreamWriter writer = new StreamWriter("data.json"))
            {
                writer.WriteLine(obj);
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            //   StreamReader sr = new StreamReader("data.json");
            string path = "data.json";

            // Vérifiez si le fichier existe
            if (File.Exists(path))
            {
                // Lecture de tout le contenu du fichier
                string json = File.ReadAllText(path);

                // Désérialisation du tableau complet d'objets fournisseur
                List<gestion_stock.oPOO.Fournisseur> lst = new List<gestion_stock.oPOO.Fournisseur>();

                // Désérialiser chaque élément de la liste JSON séparément
                foreach (string jsonString in JsonConvert.DeserializeObject<List<string>>(json))
                {
                    gestion_stock.oPOO.Fournisseur fournisseur = JsonConvert.DeserializeObject<gestion_stock.oPOO.Fournisseur>(jsonString);
                    lst.Add(fournisseur);
                    grid_frs.Rows.Add(fournisseur.Nom, fournisseur.Adresse, fournisseur.Tel, fournisseur.Mail);
                }
                 
                // Utilisez la liste 'lst' comme vous le souhaitez
            }
            else
            {
                Console.WriteLine("Le fichier n'existe pas.");
            }
        }
    }
}
