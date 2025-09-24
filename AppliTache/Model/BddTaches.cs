using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliTache.Model
{
    class BddTaches
    {
        private List<Tache> liste;

        public List<Tache> GetList()
        {
            return liste;
        }

        public void Add(Tache t)
        {
            liste.Add(t);
        }

        public void Delete(Tache t)
        {
            foreach(Tache x in liste)
            {
                if (x.Titre == t.Titre)
                {
                    liste.Remove(t);
                }
            }
        }
    }
}
