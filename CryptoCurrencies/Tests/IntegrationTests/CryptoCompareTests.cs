using System.Linq;
using CryptoCurrencies.Clients;
using CryptoCurrencies.Model;
using Newtonsoft.Json;
using NUnit.Framework;

namespace CryptoCurrencies.Tests.IntegrationTests
{
    [TestFixture]
    public class CryptoCompareTests
    {
        [Test]
        public void WhenIMakeCallToGetTheCoinList_ThenIshouldBeSuccessful()
        {
            var testClass = new CryptoCompare();
            var response = testClass.GetCoinList();
            Assert.NotNull(response.Data.BTC);
            Assert.NotNull(response.Data.DSH);
            Assert.NotNull(response.Data.ETH);
            Assert.NotNull(response.Data.LTC);
            Assert.NotNull(response.Data.ZEC);
        }

        [Test]
        public void WhenIMakeACallForPricingForEthInUSD_ThenIShouldGetBackPricing()
        {
            var testClass = new CryptoCompare();
            var response = testClass.GetGetPrice("ETH", "USD");
            Assert.NotNull(response);
            Assert.NotNull(response.Data);
            Assert.NotNull(response.Data.First().Price);
        }
    }
}