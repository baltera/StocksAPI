using Stocks.Infrastructure.Commons;
using System.Net.Http;
using Xunit.Abstractions;

namespace Stocks.Infrastructure.Tests;

public class UnitTest1
{
    private readonly ITestOutputHelper output;
    private readonly StocksHttpClient httpClientService;

    public UnitTest1(ITestOutputHelper output)
    {
        this.output = output;
        httpClientService = new StocksHttpClient();
    }

    [Fact]
    public async void ShouldGetContent()
    {
        var content = await httpClientService.GetStocks();        
        output.WriteLine(content);
        Assert.NotEmpty(content);
    }
}