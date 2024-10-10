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
        [HttpGet("stock-ident")]
        public async Task<IActionResult> GetStockIdentById(string warehouse, string ident)
        {
            var stock = await _stockRepository.GetStockIdentById(warehouse, ident);
            if (stock == null)
            {
                return NotFound();
            }
            return Ok(stock);
        }
        [HttpGet("stock")]
        public async Task<IActionResult> GetByWarehouse(string warehouse)
        {
            var stock = await _stockRepository.GetByWarehouseIdAsync(warehouse);
            if (stock == null)
            {
                return NotFound();
            }
            return Ok(stock);
        }

        [HttpGet("ident")]
        public async Task<IActionResult> GetByIdent(string ident)
        {
            var res = await _stockRepository.GetByIdentIdAsync(ident);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

    
    }
}
