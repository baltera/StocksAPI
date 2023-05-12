using Stocks.Infrastructure.Commons;
using Stocks.Infrastructure.Models;
using Stocks.Application.Interfaces;
using Stocks.Domain.Models;
using Stocks.Infrastructure.Helpers;

namespace Stocks.Infrastructure.Services
{
    public class StockDataAPIService : IStocksService
    {
        private readonly StocksHttpClient _httpClient;
        public StockDataAPIService(StocksHttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<StockDataResponse> GetStockData(string ticker)
        {
            string query = "quote?symbols=" + ticker;
            return await _httpClient.GetAsync<StockDataResponse>(query);
        }

        public async Task<IEnumerable<Stock>> GetStockData(List<string> tickers)
        {
            string query = "quote?symbols=" + tickers.First();
            StockDataResponse stockDataResponse = await _httpClient.GetAsync<StockDataResponse>(query);
            List<Stock> stocks = StockDataResponseMapper.ToStockList(stockDataResponse);
            return stocks;
        }
    }
}
