using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokempo.Core.Models
{
    public class Jogador(string nome)
    {
        public string Nome { get; set; } = nome;
        public Estatistica Dados { get; private set; } = new Estatistica();
    }
}
