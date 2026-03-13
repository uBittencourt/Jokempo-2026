using Jokempo.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jokempo.WinForm
{
    public partial class Form3 : Form
    {
        private List<Jogador> jogadores;

        public Form3(List<Jogador> jogadores)
        {
            InitializeComponent();
            this.jogadores = jogadores;
            GerarGrade();
            PopularGrade();
        }

        private void GerarGrade()
        {
            listEstatisticas.Columns.Add("Nome", 125).TextAlign = HorizontalAlignment.Left;
            listEstatisticas.Columns.Add("Vitórias", 75).TextAlign = HorizontalAlignment.Center;
            listEstatisticas.Columns.Add("Empates", 75).TextAlign = HorizontalAlignment.Center;
            listEstatisticas.Columns.Add("Derrotas", 75).TextAlign = HorizontalAlignment.Center;
            listEstatisticas.View = View.Details;
        }

        private void PopularGrade()
        {
            foreach (var jogador in jogadores)
            {
                var item = new ListViewItem(jogador.Nome);
                item.SubItems.Add(jogador.Dados.Vitorias.ToString());
                item.SubItems.Add(jogador.Dados.Empates.ToString());
                item.SubItems.Add(jogador.Dados.Derrotas.ToString());
                listEstatisticas.Items.Add(item);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
