using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Jokempo.Core.Models
{
    public class Rodada
    {
        private static List<string> _jogadas = new List<string> { "Pedra", "Papel", "Tesoura" };
        private static Random _random = new Random();

        public static string RealizarRodada(string jogada, Jogador jogador)
        {
            string opcaoPC = _jogadas[_random.Next(_jogadas.Count)];
            string resultado;

            if (jogada == opcaoPC)
            {
                jogador.Dados.RegistrarEmpate();
                resultado = $"Empate, não foi dessa vez! O computador também escolheu {opcaoPC}.";
            }
            else if ((jogada == "Pedra" && opcaoPC == "Tesoura") ||
                     (jogada == "Papel" && opcaoPC == "Pedra") ||
                     (jogada == "Tesoura" && opcaoPC == "Papel"))
            {
                jogador.Dados.RegistrarVitoria();
                resultado = $"Parabéns, você venceu! O computador escolheu {opcaoPC}.";
            }
            else
            {
                jogador.Dados.RegistrarDerrota();
                resultado = $"Que pena, você perdeu! O computador escolheu {opcaoPC}.";
            }
            return resultado;
        }

        
    }
}
