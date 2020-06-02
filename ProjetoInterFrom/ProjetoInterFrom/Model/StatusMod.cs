using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterFrom.Model
{
    class StatusMod
    {
        public string id { get; set; }
        public string nome { get; set; }

        public string returnNome()
        {
            return nome;
        }
    }
}
