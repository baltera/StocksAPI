using Stocks.Infrastructure.Commons;
using Xunit.Abstractions;

namespace Stocks.Infrastructure.Tests;

public class UnitTest1
{
    private readonly ITestOutputHelper output;
    private readonly StocksHttpClient httpClient;

    public UnitTest1(ITestOutputHelper output)
    {
        this.output = output;
        this.httpClient = new StocksHttpClient();
    }

    [Fact]
    public async void ShouldGetContent()
    {
        var content = await httpClient.GetAsync<object>("posts");
        output.WriteLine(content.ToString());
        Assert.NotEmpty((System.Collections.IEnumerable) content);
    }
}