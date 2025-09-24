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
    public partial class AjoutTache : Form
    {
        public AjoutTache()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Tache tache = new Tache
            {
                Titre = nomTache.Text,
                Description = descTache.Text,
                Statut = "À faire",
                //User = 
            };

            Accueil.taches.Add(tache);
            this.Close();
        }
    }
}
