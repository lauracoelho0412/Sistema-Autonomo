using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo_Predadores
{
    internal class Turno
    {
        public int TurnoAtual { get; set; }
        public int IdJogadorDado { get; set; }
        public List<Jogador> listaJogadores { get; set; }
        public string Dado { get; set; }
        public string Status { get; set; }
    }
}