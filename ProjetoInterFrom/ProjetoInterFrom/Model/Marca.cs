using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterFrom.Model
{
    class Marca
    {
        public string id = "11";
        public string nome = "BMC";

        public Marca()
        {
        }

        public Marca(string id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
    }
}
