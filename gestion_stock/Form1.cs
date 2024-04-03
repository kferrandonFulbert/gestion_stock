using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_stock
{
    public partial class frm_accueil : Form
    {
        public frm_accueil()
        {
            InitializeComponent();
        }

        private void btn_frs_Click(object sender, EventArgs e)
        {
            frm_frs frm_fournisseur = new frm_frs();
            frm_fournisseur.ShowDialog();
        }
    }
}
