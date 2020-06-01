using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterFrom.Model
{
    class Pessoa
    {
        public string Id { get; set; }
        //[JsonProperty("cpf")]
        public string CPF { get; set; }
        //[JsonProperty("data")]
        public string DataNascimento { get; set; }
        // [JsonProperty("endereco")]
        public string Endereco { get; set; }
        //[JsonProperty("nome")]
        public string Nome { get; set; }        
        //[JsonProperty("telefone")]
        public string Telefone { get; set; }
       
        
    }
}
