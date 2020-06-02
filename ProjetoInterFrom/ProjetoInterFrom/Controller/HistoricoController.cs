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
    class HistoricoController
    {
        public string baseUrl
        {
            get
            {
                return "https://projetov1.herokuapp.com";
            }
        }

        public List<HistoricoMod> GetHistorico(string id)
        {
            string action = string.Format("/bicicleta/{0}", id);

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, baseUrl + action);

            HttpResponseMessage response = HttpInstance.GetHttpClientInstance().SendAsync(request).Result;

            List<HistoricoMod> pessoaList = new List<HistoricoMod>();
            JObject pessoasJson = JObject.Parse(response.Content.ReadAsStringAsync().Result);

            //pessoaList.Add();

            return pessoaList;
        }

    }
}
