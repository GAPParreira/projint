using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterFrom.Model
{
    class Modelo
    {
        public string id = "11";
        public string nome = "Bike1";

        public Modelo()
        {
        }

        public Modelo(string id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
    }
}
