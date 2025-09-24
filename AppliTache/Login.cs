using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppliTache.Model;

namespace AppliTache
{
    public partial class Login : Form
    {

        private List<User> users;

        public Login()
        {
            InitializeComponent();

            users = new List<User>
            {
                new User { Login = "bruno@mail.com", Mdp = "123", Pseudo = "Bruno" },
                new User { Login = "laura@mail.com", Mdp = "1234", Pseudo = "Laura" }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.Trim();
            string mdp = textBox2.Text;

            // Vérification
            var user = users.FirstOrDefault(u => u.Login == login && u.Mdp == mdp);

            if (user != null)
            {

                this.Hide();
                var accueil = new Accueil(user);
                accueil.ShowDialog();
                this.Close();
            }

            else
            {
                // Échec 
                label1.Text = "Email ou mot de passe incorrect.";
                label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
