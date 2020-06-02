using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterFrom.Model
{
    class LoginMod
    {
        public string Id { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        CreateUserMod response;
        
        Pessoa pessoa = new Pessoa();

        public LoginMod()
        {
        }

        public LoginMod(string login, string senha)
        {
            this.login = login;
            this.senha = senha;
            
        }

        public LoginMod(Pessoa pessoa)
        {
            this.pessoa = pessoa;
        }

        public string rspId()
        {
            return pessoa.id;
        }

        public string rspNome()
        {
            return pessoa.nome;
        }
        
        public CreateUserMod returnCreate()
        {
            response = new CreateUserMod(login, senha, pessoa.id);
            return response;
        }
    }
}
