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
    public partial class Form2 : Form
    {
        private List<Jogador> jogadores;
        private int indiceJogador;
        private string jogada = "";

        public Form2(List<Jogador> jogadores, int indiceJogador)
        {
            InitializeComponent();
            this.jogadores = jogadores;
            this.indiceJogador = indiceJogador;
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            jogada = "Pedra";
            lblJogada.Text = $"Você escolheu {jogada}";
            btnJogar.Enabled = true;
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            jogada = "Papel";
            lblJogada.Text = $"Você escolheu {jogada}";
            btnJogar.Enabled = true;
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            jogada = "Tesoura";
            lblJogada.Text = $"Você escolheu {jogada}";
            btnJogar.Enabled = true;
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            btnJogar.Enabled = false;
            btnPedra.Enabled = false;
            btnPapel.Enabled = false;
            btnTesoura.Enabled = false;
            btnJogarNovamente.Enabled = true;
            btnTrocarJogador.Enabled = true;
            btnEstatisticas.Enabled = true;
            string resultado = Rodada.RealizarRodada(jogada, jogadores[indiceJogador]);
            if (resultado.Contains("VENCEU!"))
            {
                lblJogada.ForeColor = Color.Green;
            }
            else if (resultado.Contains("PERDEU!"))
            {
                lblJogada.ForeColor = Color.Red;
            }
            else
            {
                lblJogada.ForeColor = Color.Black;
            }
            lblJogada.Text = resultado;
        }

        private void btnJogarNovamente_Click(object sender, EventArgs e)
        {
            btnJogarNovamente.Enabled = false;
            btnTrocarJogador.Enabled = false;
            btnEstatisticas.Enabled = false;
            btnPedra.Enabled = true;
            btnPapel.Enabled = true;
            btnTesoura.Enabled = true;
            lblJogada.ForeColor = Color.Black;
            jogada = "";
            lblJogada.Text = "";
        }

        private void btnTrocarJogador_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEstatisticas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3(jogadores);
            form3.ShowDialog();
            this.Show();
        }
    }
}
