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

        public List<Aluguel> GetAlugueis(string nome)
        {
            string action = string.Format("/usuario/name/{0}", nome);

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, baseUrl + action);

            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().SendAsync(request).Result;

            JArray aluguelJson = JArray.Parse(response.Content.ReadAsStringAsync().Result);

            List<Aluguel> alugueis = new List<Aluguel>();

            foreach (var alugueisJson in aluguelJson)
            {
                StatusMod statusA = new StatusMod() { nome = aluguelJson["status"]["nome"].ToString(), id = aluguelJson["status"]["id"].ToString() };
                Multa multa = new Multa() { nome = aluguelJson["multa"]["nome"].ToString(), id = aluguelJson["multa"]["id"].ToString() };
                string dtIni = aluguelJson["tempo_inicio"].ToString();
                Aluguel aluguel = new Aluguel(dtIni, multa, statusA);
                alugueis.Add(aluguel);
            }
                        
            return alugueis;
        }
    }
}
