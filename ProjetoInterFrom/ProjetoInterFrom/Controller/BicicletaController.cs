using ProjetoInterFrom.Model;
using ProjetoInterFrom.View.FormsHome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ProjetoInterFrom.Controller
{
    class BicicletaController
    {

        public string baseUrl
        {
            get
            {
                return "https://interbikeshop.herokuapp.com";
            }
        }

        public async void GetBicicleta()
        {
            string action = string.Format("/bicicleta");

            string request = (baseUrl + action);


            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri(request);
                var response = await client.GetAsync("");
                string dados = await response.Content.ReadAsStringAsync();
                List<Bicicleta> bicicleta = new JavaScriptSerializer().Deserialize<List<Bicicleta>>(dados);                
            }
        }

    }
}
