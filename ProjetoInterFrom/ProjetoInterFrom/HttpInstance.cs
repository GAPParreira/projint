using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterFrom
{
    public class HttpInstance
    {
        private static HttpClient httpClientInstance;

        private HttpInstance()
        {
        }

        public static HttpClient GetHttpClientInstance()
        {
            if(httpClientInstance == null)
            {
                httpClientInstance = new HttpClient();
                httpClientInstance.DefaultRequestHeaders.ConnectionClose = false;
            }
            return httpClientInstance;
        }
    }
}
