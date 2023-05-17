using Newtonsoft.Json;

namespace Stocks.Infrastructure.Commons
{
    public class StocksHttpClient : HttpClient
    {
        private readonly string _apiKey;

        public StocksHttpClient(string baseUri, string apiKey)
        {
            //this.BaseAddress = new Uri("https://api.stockdata.org/v1/data/");            
            this.BaseAddress = new Uri(baseUri);
            this._apiKey = apiKey;
        }

        public async Task<T> GetAsync<T>(string uri)
        {
            HttpResponseMessage response = await GetAsync($"{uri}&api_token=" + _apiKey);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }
    }
}
