using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliTache.Model
{
    public class User
    {
        private string login;
        private string mdp;
        private string pseudo;

        public User()
        {

        }

        public User(string Login, string Mdp, string Pseudo)
        {
            this.login = Login;
            this.mdp = Mdp;
            this.pseudo = Pseudo;
        }

        public string Login
        { get; set; }

        public string Mdp
        { get; set; }

        public string Pseudo
        { get; set; }
    }
}
