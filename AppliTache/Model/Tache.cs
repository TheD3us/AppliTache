using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliTache.Model
{
    class Tache
    {
        private string titre;
        private string description;
        private string statut;   // à faire, attribué, fini
        // private User user;

        public Tache()
        { }

        public Tache(string Titre, string Description, string Statut)
        {
            this.titre = Titre;
            this.description = Description;
            this.statut = Statut;
        }

        public string Titre
        { get; set; }

        public string Description
        { get; set; }

        public string Statut
        { get; set; }


    }
}
