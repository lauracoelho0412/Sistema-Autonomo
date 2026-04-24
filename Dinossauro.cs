using Draft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo_Predadores
{
    public class Dinossauro
    {
        public string Nome { get; set; }

        public int Quantidade { get; set; }

        public string Localizacao { get; set; }

        public static List<Dinossauro> ListarDinossauros(string mao)
        {
            mao = mao.Replace("\r", "");

            string[] linhas = mao.Split('\n');
            List<Dinossauro> listaDinossauros = new List<Dinossauro>();

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