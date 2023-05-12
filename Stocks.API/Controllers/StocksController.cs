using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stocks.Domain.Models;

namespace Stocks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<Stock>> GetStocks([FromQuery] List<string> tickers)
        {
            return new List<Stock>() { new Stock() { Name = tickers[0] } };
        }
    }
}
