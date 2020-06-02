using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterFrom.Model
{
    class MetododePagamento
    {
        public string id ;
        public string nome ;

        public MetododePagamento()
        {
        }

        public MetododePagamento(string id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public string MetodoPagamento()
        {
            if (nome == "credito")
                id = "11";
            else
                id = "21";
            return id;
        }
    }
}
