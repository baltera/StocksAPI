using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Infrastructure.Services
{
    public class HttpClientService : IHttpClientService
    {
        private readonly HttpClient _httpClient;
        public HttpClientService() {
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
