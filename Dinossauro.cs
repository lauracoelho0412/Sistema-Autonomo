using System;
using System.Collections.Generic;

namespace Sistema_Autonomo_Predadores
{
    public class Dinossauro
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public string Localizacao { get; set; }

        /// <summary>
        /// Converte a string CSV retornada pelo servidor em uma lista de dinossauros.
        /// O formato esperado é: cabeçalho na linha 0, dados nas linhas seguintes,
        /// terminando com uma linha vazia.
        /// </summary>
        public static List<Dinossauro> ListarDinossauros(string csv)
        {
            csv = csv.Replace("\r", "");
            string[] linhas = csv.Split('\n');
            var lista = new List<Dinossauro>();

            // Linha 0 é cabeçalho; última linha costuma ser vazia
            for (int i = 1; i < linhas.Length - 1; i++)
            {
                if (string.IsNullOrWhiteSpace(linhas[i])) continue;

                string[] campos = linhas[i].Split(',');

                lista.Add(new Dinossauro
                {
                    Nome = campos[0],
                    Quantidade = Convert.ToInt32(campos[1])
                });
            }

            return lista;
        }
    }
}