using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProjetoInterFrom.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterFrom.Controller
{
    internal class PessoaController
    {
        private static HttpClient _httpClient = new HttpClient();
        public string baseUrl
        {
            get
            {
                return "https://projetov1.herokuapp.com"; 
            }
        }

        public List<Pessoa> GetPessoa(string id)
        {
            string action = string.Format("/pessoa/{0}", id);

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, baseUrl + action);

            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().SendAsync(request).Result;

            List<Pessoa> pessoaList = new List<Pessoa>();
            JObject pessoasJson = JObject.Parse(response.Content.ReadAsStringAsync().Result);
                        
            pessoaList.Add(new Pessoa() { Nome = pessoasJson["nome"].ToString(), DataNascimento = pessoasJson["data"].ToString(), CPF = pessoasJson["cpf"].ToString(), Endereco = pessoasJson["endereco"].ToString(), Telefone = pessoasJson["telefone"].ToString() });
            
            return pessoaList;
        }

        public async void PostPessoa(Pessoa pessoa)
        {
            string action = string.Format("/pessoa");

            string request = (baseUrl + action);

            
            using (HttpClient client = new HttpClient())
            {
                
                client.BaseAddress =new Uri(request);
                var response = await client.PostAsJsonAsync("", pessoa);

            }
        }
    }
}
