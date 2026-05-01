using Draft;
using System;
using System.Collections.Generic;

namespace Sistema_Autonomo_Predadores
{
    public class Jogador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public List<Dinossauro> Mao { get; set; }
        public int Pontuacao { get; set; }

        /// <summary>
        /// Retorna a lista de jogadores de uma partida a partir do servidor.
        /// </summary>
        public static List<Jogador> ListarJogadores(int idPartida)
        {
            string retorno = Jogo.ListarJogadores(idPartida);
            retorno = retorno.Replace("\r", "");

            string[] linhas = retorno.Split('\n');
            var lista = new List<Jogador>();

            foreach (string linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha)) continue;

                string[] campos = linha.Split(',');

                lista.Add(new Jogador
                {
                    Id = Convert.ToInt32(campos[0]),
                    Nome = campos[1],
                    Pontuacao = Convert.ToInt32(campos[2])
                });
            }

            return lista;
        }
    }
}