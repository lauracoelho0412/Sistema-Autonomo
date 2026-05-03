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

                if (campos.Length < 3)
                    continue;


                  if(  int.TryParse(campos[0], out int id) &&
                       int.TryParse(campos[2], out int pontuacao))
                {
                    lista.Add(new Jogador
                    {
                        Id = id,
                        Nome = campos[1],
                        Pontuacao = pontuacao
                    });
                }
                    
            }

            return lista;
        }
    }
}