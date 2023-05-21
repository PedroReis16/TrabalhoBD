using System;
using System.Collections;
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
    public partial class PesquisaGeral : UserControl
    {
        TelaPrincipal menu;
        List<Orgaos> orgaos;
        Orgaos selecionado;
        public PesquisaGeral(TelaPrincipal menu)
        {
            InitializeComponent();
            this.menu = menu;
            orgaos = DAO.Orgaos();
            CarregandoCampos();
            TotalReceitas.Text = ValorReceitas.Text = label3.Text = label4.Text = ""; 
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Voltar();
        }
        private void CarregandoCampos()
        {
            OrgaoCB.Items.Clear();
            orgaos = orgaos.OrderBy(x => x.Nome).ToList();

            foreach (var i in orgaos)
            {
                OrgaoCB.Items.Add(i.Nome);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Faturamento> lista = DAO.FaturmentoMes(selecionado.Codigo, MesCB.SelectedIndex + 1);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
            //for (int i = 0; i < lista.Count; i++)
            //{
            //    dataGridView1.Rows[i].Cells[0].Value = lista[i].Codigo;
            //    dataGridView1.Rows[i].Cells[1].Value = lista[i].Descricao;
            //    dataGridView1.Rows[i].Cells[2].Value = lista[i].Valor;
            //}

            TotalReceitas.Text = $"Total de receitas: ";
            label4.Text = $"{lista.Count}";
            ValorReceitas.Text = $"Total de rendimentos: ";
            label3.Text = $"{lista.Sum(x => x.Valor)}";
        }

        private void PesquisaMensal_SelectionIndexChanged(object sender, EventArgs e)
        {
            if (OrgaoCB.SelectedIndex != -1 && MesCB.SelectedIndex != -1)
            {
                button2.Enabled = true;
            }
            selecionado = orgaos.Where(x => x.Nome == OrgaoCB.SelectedItem.ToString()).FirstOrDefault(); ;
        }
    }
}
