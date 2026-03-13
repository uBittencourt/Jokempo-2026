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


        // FAZER VALIDAÇÃO DE NOME E VERIFICAR SE JÁ EXISTE NA LISTA
        private int ValidarJogador(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
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

        private void btnSalvarJogador_Click(object sender, EventArgs e)
        {
            int indiceJogador = ValidarJogador(txtNome.Text);
            if (indiceJogador == -1)
            {
                txtNome.Text = "";
                lblErroJogador.Text = "Por favor, digite um nome válido!";
            } 
            else
            {
                txtNome.Text = "";
                this.Hide();
                Form2 form2 = new Form2(jogadores, indiceJogador);
                form2.ShowDialog();
                this.Show();
            }
        }
    }
}
