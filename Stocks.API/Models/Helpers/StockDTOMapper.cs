using Stocks.API.Models.Dto;
using Stocks.Domain.Models;

namespace Stocks.API.Models.Helpers
{
    public class StockDTOMapper
    {
        public static StockDTO ToStockDTO(Stock stock)
        {
            StockQuote quote = stock.StockQuotes.First();
            return new StockDTO()
            {
                Id = stock.Id,
                Name = stock.Name,
                Symbol = stock.Symbol,
                LastSalePrice = quote.Price,
                PercentChange = quote.DayPercentChange,
                MarketCap = quote.MarketCap,
                QuoteId = quote.Id
            };
        }

        public static List<StockDTO> ToStockDTOList(IEnumerable<Stock> stocks)
        {
            List<StockDTO> dtos = new List<StockDTO>();
            foreach (var stock in stocks)
            {
                dtos.Add(ToStockDTO(stock));
            }
            return dtos;
        }
    }
}
