
namespace ProjetoInterFrom.Model
{
    class Pessoa
    {        
        public string CPF { get; set; }
        public string DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string cPF, string dataNascimento, string endereco, string nome, string telefone)
        {            
            CPF = cPF;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Nome = nome;
            Telefone = telefone;
        }
    }
}
