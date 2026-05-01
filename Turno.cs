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
        public void CarregarDeCsv(string csv)
        {
            string[] campos = csv.Replace("\r", "").Replace("\n", "").Split(',');
            Status = campos[0];
            IdJogadorDado = Convert.ToInt32(campos[1]);
            Dado = campos[2];
        }
    }
}