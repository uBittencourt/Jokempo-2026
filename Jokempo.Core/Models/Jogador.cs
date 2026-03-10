using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokempo.Core.Models
{
    public class Jogador(String nome)
    {
        public string Nome { get; set; } = nome;
    }
}
