﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoBD
{
    public partial class OpcoesIniciais : UserControl
    {
        public OpcoesIniciais()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipal.VisaoGeral();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Receitas();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            TelaPrincipal.OrgaosLucrativos();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Prejuizos();
        }
    }
}
