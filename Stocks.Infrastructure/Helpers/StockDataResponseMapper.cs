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
                Exchange exchange = new Exchange()
                {
                    LongName = stockQuote.ExchangeLong,
                    Name = stockQuote.ExchangeShort
                };
                StockQuote quote = new StockQuote()
                {
                    Price = stockQuote.Price,
                    DayHigh = stockQuote.DayHigh,
                    DayLow = stockQuote.DayLow,
                    DayOpen = stockQuote.DayOpen,
                    PreviousClosePrice = stockQuote.PreviousClosePrice,
                    DayPercentChange = stockQuote.DayChange,
                    MarketCap = stockQuote.MarketCap,
                    Volume = stockQuote.Volume,
                    LastTradeTime = stockQuote.LastTradeTime,
                };
                Stock stock = new Stock()
                {
                    Symbol = stockQuote.Ticker,
                    Name = stockQuote.Name,
                    Currency = stockQuote.Currency,
                    Exchange = exchange,
                    StockQuotes = new List<StockQuote> { quote }

                };
                stocks.Add(stock);
            }
            return stocks;
        }
    }
}
