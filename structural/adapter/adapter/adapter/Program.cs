using adapter.Adapters;
using adapter.Domain.Services;
using System;

namespace adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var exchangeRateAPI = new ExchangeRateAPIManager();

            var exchangeRate = new ExchangeRateAPIAdapter(exchangeRateAPI);

            var amountResult = exchangeRate.getCurrentBRLtoUSD();

            Console.WriteLine($"Amount result: {amountResult}");
        }
    }
}