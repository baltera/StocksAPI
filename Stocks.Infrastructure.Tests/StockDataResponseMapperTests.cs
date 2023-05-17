using Stocks.Domain.Models;
using Stocks.Infrastructure.Helpers;
using Stocks.Infrastructure.Models;
using Xunit.Abstractions;

namespace Stocks.Infrastructure.Tests
{
    public class StockDataResponseMapperTests
    {
        private readonly ITestOutputHelper _output;

        public StockDataResponseMapperTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void GivenStockDataResponse_ToStockList_ShouldReturnStockList()
        {
            //Arrange
            QuoteStockDataResponse quote = new QuoteStockDataResponse() { Ticker = "TSLA" };
            List<QuoteStockDataResponse> quotes = new List<QuoteStockDataResponse>();
            quotes.Add(quote);
            StockDataResponse response = new StockDataResponse() { Data = quotes };
            //Act
            List<Stock> stocks = StockDataResponseMapper.ToStockList(response);
            //Assert
            Assert.NotEmpty(stocks);
        }
    }
}
