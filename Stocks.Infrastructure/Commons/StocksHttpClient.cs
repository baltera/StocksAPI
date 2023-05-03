namespace Stocks.Infrastructure.Commons
{
    public class StocksHttpClient
    {
        private readonly HttpClient _httpClient;
        public StocksHttpClient()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
        }

        public async Task<string> GetStocks()
        {
            var response = await _httpClient.GetAsync("posts");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
