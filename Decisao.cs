using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Autonomo_Predadores
{
    internal class Decisao
    {
        public static (string, string) EscolherJogada(List<Dinossauro> mao, string dado)
        {
            var dino = mao[0];
            string codigoDino = dino.Nome;

            string codigoCercado = "RI"; // fallback seguro (rio sempre pode)

            // DECISÃO BASEADA NO DADO
            if (dado == "FL")
                codigoCercado = "FI";

            else if (dado == "PR")
                codigoCercado = "PA";

            else if (dado == "VZ")
                codigoCercado = "IS";

            else if (dado == "TI")
                codigoCercado = "MT"; // mata tripla (normalmente sem restrição)

            else if (dado == "AL")
                codigoCercado = "CD";

            else if (dado == "WC")
                codigoCercado = "RS";

            return (codigoDino, codigoCercado);
        }
    }
}
