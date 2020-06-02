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
        
        public string baseUrl
        {
            get
            {
                return "https://interbikeshop.herokuapp.com"; 
            }
        }

        public List<Pessoa> GetPessoa(string id)
        {
            string action = string.Format("/pessoa/{0}", id);

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, baseUrl + action);

            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().SendAsync(request).Result;

            List<Pessoa> pessoaList = new List<Pessoa>();
            JObject pessoasJson = JObject.Parse(response.Content.ReadAsStringAsync().Result);
                        
            pessoaList.Add(new Pessoa() { nome = pessoasJson["nome"].ToString(), dateNasc = pessoasJson["dateNasc"].ToString(), cpf = pessoasJson["cpf"].ToString(), endereco = pessoasJson["endereco"].ToString(), telefone = pessoasJson["telefone"].ToString() });
            
            return pessoaList;
        }

        public List<Pessoa> GetPessoaId(string cpf)
        {
            string action = string.Format("/pessoa/cpf/{0}", cpf);

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, baseUrl + action);

            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().SendAsync(request).Result;

            List<Pessoa> pessoaList = new List<Pessoa>();
            JObject pessoasJson = JObject.Parse(response.Content.ReadAsStringAsync().Result);

            pessoaList.Add(new Pessoa() { nome = pessoasJson["nome"].ToString(), dateNasc = pessoasJson["dateNasc"].ToString(), cpf = pessoasJson["cpf"].ToString(), endereco = pessoasJson["endereco"].ToString(), telefone = pessoasJson["telefone"].ToString() });

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
