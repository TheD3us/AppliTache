﻿using System;
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
        public Accueil()
        {
            InitializeComponent();

        }

        private void BAjoutTache_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("", "", "À faire");

        }
    }
}
