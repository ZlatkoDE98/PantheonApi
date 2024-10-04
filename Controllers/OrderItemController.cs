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
    public class OrderItemController : ControllerBase
    {
        private readonly RsMfDemoContext _context;

        public OrderItemController(RsMfDemoContext context)
        {
            _context = context;
        }

        // GET: api/OrderItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<THeOrderItem>>> GetTHeOrderItems()
        {
            return await _context.THeOrderItems
                .Include(i => i.AcDeptNavigation)
                .Include(i => i.AcIdentNavigation)
                .Include(i => i.AnOrderQ)  // Include related entities if necessary
                .ToListAsync();
        }

        // GET: api/OrderItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<THeOrderItem>> GetTHeOrderItem(string id, int no)
        {
            var tHeOrderItem = await _context.THeOrderItems
                .Include(i => i.AcDeptNavigation)
                .Include(i => i.AcIdentNavigation)
                .Include(i => i.AnOrderQ)  // Include related entities if necessary
                .FirstOrDefaultAsync(i => i.AcKey == id && i.AnNo == no);

            if (tHeOrderItem == null)
            {
                return NotFound();
            }

            return tHeOrderItem;
        }

        // PUT: api/OrderItems/5
        [HttpPut("{id}/{no}")]
        public async Task<IActionResult> PutTHeOrderItem(string id, int no, THeOrderItem tHeOrderItem)
        {
            if (id != tHeOrderItem.AcKey || no != tHeOrderItem.AnNo)
            {
                return BadRequest();
            }

            _context.Entry(tHeOrderItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!THeOrderItemExists(id, no))
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

        // POST: api/OrderItems
        [HttpPost]
        public async Task<ActionResult<THeOrderItem>> PostTHeOrderItem(THeOrderItem tHeOrderItem)
        {
            _context.THeOrderItems.Add(tHeOrderItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTHeOrderItem), new { id = tHeOrderItem.AcKey, no = tHeOrderItem.AnNo }, tHeOrderItem);
        }

        // DELETE: api/OrderItems/5
        [HttpDelete("{id}/{no}")]
        public async Task<IActionResult> DeleteTHeOrderItem(string id, int no)
        {
            var tHeOrderItem = await _context.THeOrderItems
                .Include(i => i.AcDeptNavigation)
                .Include(i => i.AcIdentNavigation)
                .Include(i => i.AnOrderQ)  // Include related entities if necessary
                .FirstOrDefaultAsync(i => i.AcKey == id && i.AnNo == no);
            if (tHeOrderItem == null)
            {
                return NotFound();
            }

            _context.THeOrderItems.Remove(tHeOrderItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool THeOrderItemExists(string id, int no)
        {
            return _context.THeOrderItems.Any(e => e.AcKey == id && e.AnNo == no);
        }
    }
}
