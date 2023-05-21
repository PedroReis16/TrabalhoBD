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
        public void CarregarVisaoGeral()
        {
            PainelPrincipal.Controls.Clear();

            PesquisaGeral pesquisa = new PesquisaGeral();

            pesquisa.Parent = PainelPrincipal;
            pesquisa.Dock = DockStyle.Fill;
            pesquisa.Show();
        }
        public void OrgaosLucrativos()
        {
            PainelPrincipal.Controls.Clear();

            OrgaosLucrativos orgaos = new OrgaosLucrativos();

            orgaos.Parent = PainelPrincipal;
            orgaos.Dock = DockStyle.Fill;
            orgaos.Show();
        }

        public void Receitas()
        {
            PainelPrincipal.Controls.Clear();

            Receitas receitas = new Receitas();

            receitas.Parent = PainelPrincipal;
            receitas.Dock = DockStyle.Fill;
            receitas.Show();
        }
        public void Prejuizos()
        {
            PainelPrincipal.Controls.Clear();

            Prejuizos prejuizos = new Prejuizos();

            prejuizos.Parent = PainelPrincipal;
            prejuizos.Dock = DockStyle.Fill;
            prejuizos.Show();
        }

        public void Voltar()
        {
            PainelPrincipal.Controls.Clear();

            LoadView();
        }
    }
}
