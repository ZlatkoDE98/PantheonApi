using Microsoft.AspNetCore.Mvc;
using PantheonApi.DTOs.Stock;
using PantheonApi.Repositories.Interfaces;

namespace PantheonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockRepository _stockRepository;

        public StockController(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        // GET: api/stock
        [HttpGet]
        public async Task<IActionResult> GetAllStocks()
        {
            var stocks = await _stockRepository.GetAllStocksAsync();
            return Ok(stocks);
        }

        // GET: api/stock/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStockById(string warehouse, string ident)
        {
            var stock = await _stockRepository.GetStockByIdAsync(warehouse, ident);
            if (stock == null)
            {
                return NotFound();
            }
            return Ok(stock);
        }

    
    }
}
