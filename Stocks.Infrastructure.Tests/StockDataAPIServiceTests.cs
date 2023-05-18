using Stocks.Infrastructure.Commons;
using Stocks.Infrastructure.Services;
using Xunit.Abstractions;

namespace Stocks.Infrastructure.Tests
{
    public class StockDataAPIServiceTests
    {
        private readonly ITestOutputHelper _output;
        private readonly StockDataAPIService _service;
        public StockDataAPIServiceTests(ITestOutputHelper output)
        {
            this._output = output;
            this._service = new StockDataAPIService(new StocksHttpClient("https://api.stockdata.org/v1/data/", "ApiKey"));
        }

        [Fact]
        public async void GetDataStock_ShouldReturnResponse()
        {
            //Arrange
            const string TESLA_TICKER = "TSLA";
            //Act
            var content = await _service.GetStockData(TESLA_TICKER);
            //Assert
            Assert.NotNull(content);
        }
    }
}
