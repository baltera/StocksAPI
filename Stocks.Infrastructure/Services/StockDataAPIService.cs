using Stocks.Infrastructure.Commons;
using Stocks.Infrastructure.Models;

namespace Stocks.Infrastructure.Services
{
    public class StockDataAPIService
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
    }
}
