using Draft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo_Predadores
{
    internal class Partida
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        internal Turno TurnoAtual { get; set; }

        public static List<Partida> ListarPartidas()
        {
            // Busca todas as partidas via API ("T" = Todas)
            string retorno = Jogo.ListarPartidas("T");

            // Normaliza o retorno: remove \r e elimina o último caractere (geralmente \n extra)
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);

            // Divide o retorno em linhas, cada linha representa uma partida
            string[] linhas = retorno.Split('\n');
            List<Partida> listaPartidas = new List<Partida>();

            // Para na penúltima posição para evitar processar a linha vazia final
            for (int i = 0; i < linhas.Length - 1; i++)
            {
                string[] campos = linhas[i].Split(',');

                Partida partida = new Partida
                {
                    Id = Convert.ToInt32(campos[0]),
                    Name = campos[1],
                    Data = Convert.ToDateTime(campos[2]),
                    Status = campos[3]
                };

                listaPartidas.Add(partida);
            }

            return listaPartidas;
        }
    }
}