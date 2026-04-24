using Draft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo_Predadores
{
    public class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public int Pontuacao { get; set; }

        public static List<Jogador> ListarJogadores(int idPartida)
        {
            string retorno = Jogo.ListarJogadores(idPartida);

            retorno = retorno.Replace("\r", "");

            string[] linhas = retorno.Split('\n');
            List<Jogador> listaJogadores = new List<Jogador>();

            for (int i = 0; i < linhas.Length - 1; i++)
            {
                string[] campos = linhas[i].Split(',');

                Jogador jogador = new Jogador
                {
                    Id = Convert.ToInt32(campos[0]),
                    Nome = campos[1],
                    Pontuacao = Convert.ToInt32(campos[2])
                };

                listaJogadores.Add(jogador);
            }

            return listaJogadores;
        }
    }
}
