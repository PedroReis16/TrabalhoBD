using System;
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
    public partial class Receitas : UserControl
    {
        TelaPrincipal menu;
        public Receitas(TelaPrincipal menu)
        {
            InitializeComponent();
            this.menu = menu; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Voltar();
        }
    }
}
