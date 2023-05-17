using Stocks.Domain.Models;

namespace Stocks.Application.Interfaces
{
    public interface IStocksService
    {
        Task<IEnumerable<Stock>> GetStockData(List<string> tickers);
    }
}
