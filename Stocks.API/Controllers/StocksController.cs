using Microsoft.AspNetCore.Mvc;
using Stocks.API.Models.Dto;
using Stocks.API.Models.Helpers;
using Stocks.Application.Interfaces;

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
        public async Task<IEnumerable<StockDTO>> GetStocks([FromQuery] List<string> tickers)
        {
            var stocks = await _stocksService.GetStockData(tickers);
            return StockDTOMapper.ToStockDTOList(stocks);
        }
    }
}
