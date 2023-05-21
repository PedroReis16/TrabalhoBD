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
        static Panel Painel;
        public TelaPrincipal()
        {
            InitializeComponent();
            Painel = PainelPrincipal;
            LoadView();
        }

        private static void LoadView()
        {
            OpcoesIniciais opcoes = new OpcoesIniciais();

            opcoes.Parent = Painel;
            opcoes.Dock = DockStyle.Fill;
            opcoes.Show();
        }
        public static void VisaoGeral()
        {
            Painel.Controls.Clear();

            PesquisaGeral pesquisa = new PesquisaGeral();

            pesquisa.Parent = Painel;
            pesquisa.Dock = DockStyle.Fill;
            pesquisa.Show();
        }
        public static void OrgaosLucrativos()
        {
            Painel.Controls.Clear();

            OrgaosLucrativos orgaos = new OrgaosLucrativos();

            orgaos.Parent = Painel;
            orgaos.Dock = DockStyle.Fill;
            orgaos.Show();
        }

        public static void Receitas()
        {
            Painel.Controls.Clear();

            Receitas receitas = new Receitas();

            receitas.Parent = Painel;
            receitas.Dock = DockStyle.Fill;
            receitas.Show();
        }
        public static void Prejuizos()
        {
            Painel.Controls.Clear();

            Prejuizos prejuizos = new Prejuizos();

            prejuizos.Parent = Painel;
            prejuizos.Dock = DockStyle.Fill;
            prejuizos.Show();
        }

        public static void Voltar()
        {
            Painel.Controls.Clear();

            LoadView();
        }
    }
}
