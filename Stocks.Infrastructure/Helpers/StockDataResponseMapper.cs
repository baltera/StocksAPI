using Stocks.Domain.Models;
using Stocks.Infrastructure.Models;

namespace Stocks.Infrastructure.Helpers
{
    public class StockDataResponseMapper
    {
        public static List<Stock> ToStockList(StockDataResponse stockDataResponse)
        {
            List<Stock> stocks = new List<Stock>();
            foreach (QuoteStockDataResponse stockQuote in stockDataResponse.Data)
            {
                stocks.Add(new Stock()
                {
                    Symbol = stockQuote.Ticker,
                    Name = stockQuote.Name,
                    Currency = stockQuote.Currency

                });
            }
            return stocks;
        }
    }
}
