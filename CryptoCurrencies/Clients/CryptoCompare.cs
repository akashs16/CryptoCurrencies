using CryptoCurrencies.Model;
using Newtonsoft.Json;
using RestSharp;

namespace CryptoCurrencies.Clients
{
    public class CryptoCompare : ClientBase
    {
        public CryptoCompare() : base(Constants.CryptoCompate)
        {
        }

        public GetCoinList GetCoinList()
        {
            var request = new RestRequest("/coinlist/", Method.GET);
            return Client.Execute<GetCoinList>(request).Data;
        }

        public Pricing GetGetPrice(string cryptoCurrency, string requriedExchanges)
        {
            var request = new RestRequest($"/price?fsym={cryptoCurrency}&tsyms={requriedExchanges}", Method.GET);
            var content= Client.Execute<Pricing>(request).Content;
            return JsonConvert.DeserializeObject<Pricing>(content);
        }
    }
}