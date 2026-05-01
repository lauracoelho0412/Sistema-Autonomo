using Draft;
using System;
using System.Collections.Generic;

namespace Sistema_Autonomo_Predadores
{
    internal class Partida
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public string Senha { get; set; }
        public List<Jogador> Jogadores { get; set; }

        /// <summary>
        /// Retorna todas as partidas disponíveis no servidor.
        /// </summary>
        public static List<Partida> ListarPartidas()
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "").TrimEnd('\n');

            string[] linhas = retorno.Split('\n');
            var lista = new List<Partida>();

            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(',');

                lista.Add(new Partida
                {
                    Id = Convert.ToInt32(campos[0]),
                    Nome = campos[1],
                    Data = Convert.ToDateTime(campos[2]),
                    Status = campos[3]
                });
            }

            return lista;
        }

        /// <summary>
        /// Preenche Status e Turno a partir da resposta de VerificarPartida.
        /// Formato esperado: "StatusPartida,TurnoAtual,StatusTurno,IdJogadorDado,Dado"
        /// Retorna false se a resposta contiver erro.
        /// </summary>
        public bool CarregarDeVerificacao(string retorno, Turno turno)
        {
            if (retorno.Contains("ERRO"))
                return false;

            string[] campos = retorno.Replace("\r", "").Replace("\n", "").Split(',');
            Status = campos[0];
            turno.TurnoAtual = Convert.ToInt32(campos[1]);
            turno.Status = campos[2];
            turno.IdJogadorDado = Convert.ToInt32(campos[3]);
            turno.Dado = campos[4];
            return true;
        }
    }
}