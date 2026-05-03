using System;

namespace Sistema_Autonomo_Predadores
{
    internal class Turno
    {
        public int TurnoAtual { get; set; }
        public int IdJogadorDado { get; set; }
        public string Dado { get; set; }
        public string Status { get; set; }

        /// <summary>
        /// Preenche os dados do turno a partir de uma string CSV retornada pelo servidor.
        /// Formato esperado: "Status,IdJogadorDado,Dado"
        /// </summary>
        /* public void CarregarDeCsv(string csv)
         {
             string[] campos = csv.Replace("\r", "").Replace("\n", "").Split(',');
             Status = campos[0];
             IdJogadorDado = Convert.ToInt32(campos[1]);
             Dado = campos[2];
         }
        */
        // vamos mudar isso 

        public void CarregarDeCsv(string csv)
        {
            if (string.IsNullOrWhiteSpace(csv))
                return;

            csv = csv.Replace("\r", "").Replace("\n", "");

            if (csv.Contains("ERRO"))
                return;
            string[] campos = csv.Split(',');

            // garanta que tem pelo menos 3 posiçoes 
            if (campos.Length < 3)
                return;

            Status = campos[0];

            if (int.TryParse(campos[1], out int idJogador))
                IdJogadorDado = idJogador;

            Dado = campos[2];
        }
    }
}