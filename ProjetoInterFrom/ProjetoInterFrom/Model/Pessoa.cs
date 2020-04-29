using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterFrom.Model
{
    class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Telefone { get; set; }
        public string Endereco { get; set; }
        public string CPF { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, DateTime dataNascimento, int telefone, string endereco, string cPF)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Endereco = endereco;
            CPF = cPF;
        }

        
    }
}
