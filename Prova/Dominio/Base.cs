using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Base
    {
        public Base()
        {
            Client = new RestClient("http://fichainscricaodesenv.azurewebsites.net/");
        }
        private readonly RestClient Client;

        public IRestResponse Salvar<T>(object Entidade, string apiEndPoint) where T : new()
        {
            
            var json = JsonConvert.SerializeObject(Entidade);
            var request = new RestRequest(apiEndPoint, Method.POST);
            request.AddParameter("text/json", json, ParameterType.RequestBody);
            var response = Client.Execute<T>(request);
            return response;
        }
    }
}
