using Draft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo_Predadores
{
    internal class Dinossauro
    {
        public string Nome { get; set; }

        public int Quantidade { get; set; }

        public string Localizacao { get; set; }

        public static List<Dinossauro> ListarDinossauros(string mao)
        {
            // Normaliza quebras de linha para evitar caracteres \r em sistemas Windows
            mao = mao.Replace("\r", "");

            // Divide a string por linha para processar cada dinossauro individualmente
            string[] linhas = mao.Split('\n');
            List<Dinossauro> listaDinossauros = new List<Dinossauro>();

            // Começa do índice 1 para pular o cabeçalho (primeira linha)
            // Para na penúltima linha para evitar linha vazia no final
            for (int i = 1; i < linhas.Length - 1; i++)
            {
                string[] campos = linhas[i].Split(',');

                Dinossauro dinossauro = new Dinossauro
                {
                    Nome = campos[0],
                    Quantidade = Convert.ToInt32(campos[1])
                };

                listaDinossauros.Add(dinossauro);
            }

            return listaDinossauros;
        }
    }
}