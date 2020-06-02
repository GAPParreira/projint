using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterFrom.Model
{
    class HistoricoMod
    {
        public string Dia { get; set; }
        public string Status { get; set; }
        public string Multa { get; set; }
        public string valorMulta { get; set; }

        public HistoricoMod()
        {
        }

        public HistoricoMod(string dia, string status, string multa, string valorMulta)
        {
            Dia = dia;
            Status = status;
            Multa = multa;
            this.valorMulta = valorMulta;
        }
    }
}
