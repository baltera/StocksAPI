using Newtonsoft.Json;

namespace Stocks.Infrastructure.Commons
{
    public class StocksHttpClient : HttpClient
    {
        public StocksHttpClient()
        {
            this.BaseAddress = new Uri("https://api.stockdata.org/v1/data/");
        }

        public async Task<T> GetAsync<T>(string uri)
        {
            HttpResponseMessage response = await GetAsync($"{uri}&api_token="); //FIXME: Include API token
            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }
    }
}
