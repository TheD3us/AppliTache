using AppliTache.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliTache
{
    public partial class Accueil : Form
    {
        private string user_actuel;
        public static List<Tache> taches = new List<Tache>();


        public Accueil()
        {
            InitializeComponent();
            RefreshDataGrid();

        }
        private void RefreshDataGrid()
        {
            dataGridView1.DataSource = null;
            foreach(Tache t in taches)
            {
                if(t.User.Pseudo == user_actuel)
                {
                    dataGridView1.Rows.Add(t.Titre, t.Description, t.Statut, t.User);
                }
                
            }
        }

        private void BAjoutTache_Click(object sender, EventArgs e)
        {
            AjoutTache formAjout = new AjoutTache();
            formAjout.ShowDialog();

            RefreshDataGrid();

        }
    }
}
