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
    class AluguelController
    {
        public string baseUrl
        {
            get
            {
                return "https://interbikeshop.herokuapp.com";
            }
        }

        public async void PostAluguel(MontarAluguel aluguel)
        {
            string action = string.Format("/aluguel");

            string request = (baseUrl + action);


            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri(request);
                var response = await client.PostAsJsonAsync("", aluguel);

            }
        }

        /*public Aluguel GetAlugueis(string nome)
        {
            string action = string.Format("/usuario/name/{0}", nome);

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, baseUrl + action);

            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().SendAsync(request).Result;




            JObject loginJson = JObject.Parse(response.Content.ReadAsStringAsync().Result);

            Pessoa pessoas = new Pessoa() { nome = loginJson["pessoa"]["nome"].ToString(), dateNasc = loginJson["pessoa"]["dateNasc"].ToString(), cpf = loginJson["pessoa"]["cpf"].ToString(), endereco = loginJson["pessoa"]["endereco"].ToString(), telefone = loginJson["pessoa"]["telefone"].ToString(), id = loginJson["pessoa"]["id"].ToString() };
            LoginMod loginList = new LoginMod(pessoas)
            {
                login = loginJson["login"].ToString(),
                senha = loginJson["senha"].ToString(),
            };

            return loginList;
        }*/
    }
}
