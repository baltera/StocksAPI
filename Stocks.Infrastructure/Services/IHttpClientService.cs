namespace Stocks.Infrastructure.Services
{
    public interface IHttpClientService
    {
        Task<String> GetStocks();
    }

}
