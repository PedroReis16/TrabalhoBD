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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            LoadView();
        }

        private void LoadView()
        {
            OpcoesIniciais opcoes = new OpcoesIniciais();

            opcoes.Parent = PainelPrincipal;
            opcoes.Dock = DockStyle.Fill;
            opcoes.Show();
        }
    }
}
