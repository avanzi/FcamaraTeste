using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FcamaraTeste.Services;
using FcamaraTeste.Domain.Entidades;
using System.Web.Configuration;
using System.Net.Http;
using Newtonsoft.Json;

namespace FcamaraTeste.BusinessService
{
    public class ProdutoBusinessService
    {
        readonly string baseUri = "http://localhost:27592/api/Produto";



        public void AddProduct(Produto pProd)
        {
            string uri = baseUri;


            using (HttpClient httpClient = new HttpClient())
            {
                var response = httpClient.PostAsync(baseUri, new StringContent(JsonConvert.SerializeObject(pProd).ToString(),Encoding.UTF8, "application/json")) .Result;

                if (response.IsSuccessStatusCode)
                {
                //    dynamic content = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);

                //    // Access variables from the returned JSON object
                //    var appHref = content.links.applications.href;
                }


            }
        }

        public List<Produto> GetProducts()
        {
          
            string uri = baseUri;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObjectAsync<List<Produto>>(response.Result).Result;
            }

        }

        public Produto GetProductById(int id)
        {
            string uri = baseUri + "/" + id;

                  using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObjectAsync<Produto>(response.Result).Result;
            }
        }


    }
}
