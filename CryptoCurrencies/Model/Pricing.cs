namespace CryptoCurrencies.Model
{
    public class Pricing
    {
        public string Response { get; set; }
        public string Message { get; set; }
        public PricingDetails[] Data { get; set; }
        public int Type { get; set; }
    }

    public class PricingDetails
    {
        public string Symbol { get; set; }
        public float Price { get; set; }
        public float Open24Hour { get; set; }
        public int LastUpdateTS { get; set; }
        public float Volume24Hours { get; set; }
        public float Volume24HoursTo { get; set; }
    }
}