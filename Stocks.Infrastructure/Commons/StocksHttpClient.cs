using Newtonsoft.Json;

namespace Stocks.Infrastructure.Commons
{
    public class StocksHttpClient : HttpClient
    {
        public StocksHttpClient()
        {
            this.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
        }

        public async Task<T> GetAsync<T>(string uri)
        {
            HttpResponseMessage response = await GetAsync($"{uri}");
            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }
    }
}
