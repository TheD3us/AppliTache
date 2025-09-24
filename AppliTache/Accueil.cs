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
        private User user_actuel;
        public static List<Tache> taches = new List<Tache>();

        public Accueil(User user)
        {
            InitializeComponent();
            user_actuel = user;

            // message de bienvenue
            label1.Text = $"Bonjour {user_actuel.Pseudo} !";

            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();

            foreach (Tache t in taches)
            {
                dataGridView1.Rows.Add(t.Titre, t.Description, t.Statut); 
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
