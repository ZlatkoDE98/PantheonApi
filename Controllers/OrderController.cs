using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PantheonApi.Models;

namespace PantheonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class OrderController : ControllerBase
    {
        private readonly RsMfDemoContext _context;

        public OrderController(RsMfDemoContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<THeOrder>>> GetTHeOrders()
        {
            return await _context.THeOrders
                .Include(o => o.THeOrderItems)  // Include related entities if necessary
                .ToListAsync();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<THeOrder>> GetTHeOrder(string id)
        {
            var tHeOrder = await _context.THeOrders
                .Include(o => o.THeOrderItems)  // Include related entities if necessary
                .FirstOrDefaultAsync(o => o.AcKey == id);

            if (tHeOrder == null)
            {
                return NotFound();
            }

            return tHeOrder;
        }

        // PUT: api/Orders/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTHeOrder(string id, THeOrder tHeOrder)
        {
            if (id != tHeOrder.AcKey)
            {
                return BadRequest();
            }

            _context.Entry(tHeOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!THeOrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Orders
        [HttpPost]
        public async Task<ActionResult<THeOrder>> PostTHeOrder(THeOrder tHeOrder)
        {
            _context.THeOrders.Add(tHeOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTHeOrder), new { id = tHeOrder.AcKey }, tHeOrder);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTHeOrder(string id)
        {
            var tHeOrder = await _context.THeOrders
                .Include(o => o.THeOrderItems)  // Include related entities if necessary
                .FirstOrDefaultAsync(o => o.AcKey == id);
            if (tHeOrder == null)
            {
                return NotFound();
            }

            _context.THeOrders.Remove(tHeOrder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool THeOrderExists(string id)
        {
            return _context.THeOrders.Any(e => e.AcKey == id);
        }
    }
}
