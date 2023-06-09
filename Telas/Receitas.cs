﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TrabalhoBD
{
    public partial class Receitas : UserControl
    {
        TelaPrincipal menu;
        public Receitas(TelaPrincipal menu)
        {
            InitializeComponent();
            this.menu = menu;
            GraficoColunas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Voltar();
        }
        private void GraficoColunas()
        {
            Title title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.ForeColor = Color.Black;
            title.Text = "Maiores receitas";
            chart1.Titles.Add(title);

            chart1.Series.Add("Vendas");
            //chart1.Series["vendas"].LegendText = "Vendas";

            chart1.Series["vendas"].ChartType = SeriesChartType.Column;
            chart1.Series["vendas"].BorderWidth = 4;

            List<MaioresReceitas> orgaos = DAO.MaioresReceitas();

            List<decimal> valores = new List<decimal>();

            foreach (MaioresReceitas i in orgaos)
            {
                valores.Add(i.valor);
            }

            for (int i = 0; i < valores.Count; i++)
            {
                chart1.Series["vendas"].Points.AddXY(i, valores[i]);
            }
        }
    }
}
