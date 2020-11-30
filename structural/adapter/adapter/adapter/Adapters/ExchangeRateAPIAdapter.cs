using adapter.Domain.Interfaces;
using adapter.Domain.Services;

namespace adapter.Adapters
{
    public class ExchangeRateAPIAdapter : IExchangeRateAPI
    {
        private readonly ExchangeRateAPIManager adaptee;

        public ExchangeRateAPIAdapter(ExchangeRateAPIManager adaptee)
        {
            this.adaptee = adaptee;
        }

        public double getCurrentBRLtoUSD()
        {
            return this.adaptee.getBRLtoUSD();
        }
    }
}