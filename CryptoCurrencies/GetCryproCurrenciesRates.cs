using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CryptoCurrencies.Clients;

namespace CryptoCurrencies
{
    public class GetCryproCurrenciesRates
    {
        public static void Main(string[] args)
        {
            PrintRatesUsd();
           // PrintRatesBtc();
        }

        private static void PrintRatesUsd()
        {
            var cryptoCurrencies = new CryptoCompare();
            var coinList = cryptoCurrencies.GetCoinList();
            var pricing = new List<string>
            {
                $"{DateTime.Now}",
                $"{coinList.Data.BTC.Name} : {cryptoCurrencies.GetGetPrice(coinList.Data.BTC.Name, Constants.Usd).Data.First().Price}",
                $"{coinList.Data.DSH.Name} : {cryptoCurrencies.GetGetPrice(coinList.Data.DSH.Name, Constants.Usd).Data.First().Price}",
                $"{coinList.Data.ETH.Name} : {cryptoCurrencies.GetGetPrice(coinList.Data.ETH.Name, Constants.Usd).Data.First().Price}",
                $"{coinList.Data.LTC.Name} : {cryptoCurrencies.GetGetPrice(coinList.Data.LTC.Name, Constants.Usd).Data.First().Price}",
                $"{coinList.Data.ZEC.Name} : {cryptoCurrencies.GetGetPrice(coinList.Data.ZEC.Name, Constants.Usd).Data.First().Price}"
            };

            WriteToFile(pricing, "pricingUsd.txt");
        }

        private static void PrintRatesBtc()
        {
            var cryptoCurrencies = new CryptoCompare();
            var coinList = cryptoCurrencies.GetCoinList();
            var pricing = new List<string>
            {
                $"{DateTime.Now}",
                $"{coinList.Data.BTC.Name} : {cryptoCurrencies.GetGetPrice(coinList.Data.BTC.Name, Constants.Btc).Data.First().Price}",
                $"{coinList.Data.DSH.Name} : {cryptoCurrencies.GetGetPrice(coinList.Data.DSH.Name, Constants.Btc).Data.First().Price}",
                $"{coinList.Data.ETH.Name} : {cryptoCurrencies.GetGetPrice(coinList.Data.ETH.Name, Constants.Btc).Data.First().Price}",
                $"{coinList.Data.LTC.Name} : {cryptoCurrencies.GetGetPrice(coinList.Data.LTC.Name, Constants.Btc).Data.First().Price}",
                $"{coinList.Data.ZEC.Name} : {cryptoCurrencies.GetGetPrice(coinList.Data.ZEC.Name, Constants.Btc).Data.First().Price}"
            };

            WriteToFile(pricing, "pricingBtc.txt");
        }


        private static void WriteToFile(IEnumerable<string> pricingList, string fileName)
        {
            var path = $"{ Directory.GetCurrentDirectory().Split(new string[] { "visual" }, StringSplitOptions.None)[0]}fileName";
            File.WriteAllLines(path, pricingList);
        }
    }
}
