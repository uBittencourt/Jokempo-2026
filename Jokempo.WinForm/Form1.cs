using Jokempo.Core.Models;

namespace Jokempo.WinForm
{
    public partial class Form1 : Form
    {
        private List<Jogador> jogadores = new();

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
    }
}
