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
    public partial class Prejuizos : UserControl
    {
        TelaPrincipal menu;
        public Prejuizos(TelaPrincipal menu)
        {
            InitializeComponent();
            this.menu = menu;
        }
    }
}
