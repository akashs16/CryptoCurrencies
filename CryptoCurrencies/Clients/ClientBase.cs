using System.Configuration;
using RestSharp;

namespace CryptoCurrencies.Clients
{
    public class ClientBase
    {
        public RestClient Client { get; set; }

        public ClientBase(string configrationName)
        {
            var baseUrl = ConfigurationManager.ConnectionStrings[configrationName].ConnectionString;
            Client = new RestClient(baseUrl);
        }
    }
}