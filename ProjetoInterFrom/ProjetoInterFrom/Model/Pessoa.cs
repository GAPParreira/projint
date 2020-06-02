
namespace ProjetoInterFrom.Model
{
    class Pessoa
    {   
        public string id { get; set; }
        public string cpf { get; set; }
        public string dateNasc { get; set; }
        public string endereco { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string cpf, string dateNasc, string endereco, string nome, string telefone)
        {
            this.cpf = cpf;
            this.dateNasc = dateNasc;
            this.endereco = endereco;
            this.nome = nome;
            this.telefone = telefone;
        }

        public Pessoa(string id, string cpf, string dateNasc, string endereco, string nome, string telefone)
        {
            this.id = id;
            this.cpf = cpf;
            this.dateNasc = dateNasc;
            this.endereco = endereco;
            this.nome = nome;
            this.telefone = telefone;
        }
    }
}
