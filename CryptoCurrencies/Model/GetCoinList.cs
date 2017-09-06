namespace CryptoCurrencies.Model
{
    public class GetCoinList
    {
        public string Response { get; set; }
        public string Message { get; set; }
        public string BaseImageUrl { get; set; }
        public string BaseLinkUrl { get; set; }
        public Data Data { get; set; }
        public int Type { get; set; }
    }

    public class Data
    {
        public Coin LTC { get; set; }
        public Coin BTC { get; set; }
        public Coin ETH { get; set; }
        public Coin DSH { get; set; }
        public Coin ZEC { get; set; }
    }
}