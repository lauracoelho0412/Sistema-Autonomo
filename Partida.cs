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
        public string Senha { get; set; }

        public static List<Partida> ListarPartidas()
        {
            string retorno = Jogo.ListarPartidas("T");

            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);

            string[] linhas = retorno.Split('\n');
            List<Partida> listaPartidas = new List<Partida>();

            for (int i = 0; i < linhas.Length; i++)
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