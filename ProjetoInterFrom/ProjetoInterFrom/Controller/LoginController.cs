using Newtonsoft.Json.Linq;
using ProjetoInterFrom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterFrom.Controller
{
    class LoginController
    {
        PessoaController apiP = new PessoaController();
        public string baseUrl
        {
            get
            {
                return "https://interbikeshop.herokuapp.com";
            }
        }

        public LoginMod GetLogin(string nome)
        {
            string action = string.Format("/usuario/name/{0}", nome);

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, baseUrl + action);

            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().SendAsync(request).Result;

            
            

            JObject loginJson = JObject.Parse(response.Content.ReadAsStringAsync().Result);
            idToken.idLogin = loginJson["id"].ToString();
            Pessoa pessoas = new Pessoa() { nome = loginJson["pessoa"]["nome"].ToString(), dateNasc = loginJson["pessoa"]["dateNasc"].ToString(), cpf = loginJson["pessoa"]["cpf"].ToString(), endereco = loginJson["pessoa"]["endereco"].ToString(), telefone = loginJson["pessoa"]["telefone"].ToString(), id = loginJson["pessoa"]["id"].ToString() };
            LoginMod loginList = new LoginMod(pessoas)
            {                
                login = loginJson["login"].ToString(),
                senha = loginJson["senha"].ToString(),                
            }; 
            
            return loginList;
        }

        public async void PostLogin(CreateUserMod login)
        {
            string action = string.Format("/usuario");

            string request = (baseUrl + action);


            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri(request);
                var response = await client.PostAsJsonAsync("", login);

            }
        }
    }
}
