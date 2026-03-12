using Jokempo.Core.Models;

namespace Jokempo.WinForm
{
    public partial class Form1 : Form
    {
        private List<Jogador> jogadores = new();
        private string jogada = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Jogador jogador = new Jogador(txtNomeJogador.Text);
            jogadores.Add(jogador);
            listJogadores.Items.Add(jogador.Nome);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jogada = "Pedra";
            txtJogada.Text = $"Você escolheu {jogada}";
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            jogada = "Papel";
            txtJogada.Text = $"Você escolheu {jogada}";
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            jogada = "Tesoura";
            txtJogada.Text = $"Você escolheu {jogada}";
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            int indiceJogador = ValidarJogador(txtNome.Text);
            string resultado = Rodada.RealizarRodada(jogada, jogadores[indiceJogador]);
            txtJogada.Text = resultado;
        }

        // FAZER VALIDAÇÃO DE NOME E VERIFICAR SE JÁ EXISTE NA LISTA
        private int ValidarJogador(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                txtNome.Text = "Por favor, digite um nome válido!";
                return -1;
            }
            else
            {
                if (jogadores.FindIndex(j => j.Nome == nome) != -1)
                {
                    return jogadores.FindIndex(j => j.Nome == nome);
                }
                else
                {
                    jogadores.Add(new Jogador(nome));
                    return jogadores.Count - 1;
                }
            }
        }

        private void btnJogarNovamente_Click(object sender, EventArgs e)
        {
            jogada = "";
            txtJogada.Text = "";
        }
    }
}
