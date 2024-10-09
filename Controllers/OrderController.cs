using Microsoft.AspNetCore.Mvc;
using PantheonApi.Models;
using PantheonApi.Repositories.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace PantheonApi.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        // GET: api/orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<THeOrder>>> GetTHeOrders()
        {
            return Ok(await _orderRepository.GetAllOrdersAsync());
        }

        // GET: api/orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<THeOrder>> GetTHeOrder(string id)
        {
            var tHeOrder = await _orderRepository.GetOrderByIdAsync(id);

            if (tHeOrder == null)
            {
                return NotFound();
            }

            return Ok(tHeOrder);
        }

        [HttpPost("CreateOrder")]
        public async Task<IActionResult> CreateOrder([FromBody] OrderCreationDto orderDto)
        {
            try
            {
                var acKeyNew = await _orderRepository.CreateOrderAsync(orderDto);
                return Ok(new { acKey = acKeyNew });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}
