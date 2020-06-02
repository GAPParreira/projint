using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterFrom.Model
{
    class CreateUserMod
    {
        public string Id { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string pessoa { get; set; }

        public CreateUserMod(string login, string senha, string pessoa)
        {
            this.login = login;
            this.senha = senha;
            this.pessoa = pessoa;
        }

        public CreateUserMod()
        {
        }
    }
}
