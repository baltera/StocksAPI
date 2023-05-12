using Microsoft.AspNetCore.Mvc;
using Stocks.Application.Interfaces;
using Stocks.Domain.Models;

namespace Stocks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private IStocksService _stocksService;

        public StocksController(IStocksService stocksService)
        {
            _stocksService = stocksService;
        }

        [HttpGet]
        public async Task<IEnumerable<Stock>> GetStocks([FromQuery] List<string> tickers)
        {
            return await _stocksService.GetStockData(tickers);
        }
    }
}
