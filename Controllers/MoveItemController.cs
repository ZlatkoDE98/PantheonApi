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
    public class MoveItemsController : ControllerBase
    {
        private readonly RsMfDemoContext _context;

        public MoveItemsController(RsMfDemoContext context)
        {
            _context = context;
        }

        // GET: api/MoveItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<THeMoveItem>>> GetTHeMoveItems()
        {
            return await _context.THeMoveItems.ToListAsync();
        }

        // GET: api/MoveItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<THeMoveItem>> GetTHeMoveItem(string id, int moveQid)
        {
            var tHeMoveItem = await _context.THeMoveItems
                .FirstOrDefaultAsync(item => item.AcKey == id && item.AnQid == moveQid);

            if (tHeMoveItem == null)
            {
                return NotFound();
            }

            return tHeMoveItem;
        }

        // PUT: api/MoveItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTHeMoveItem(string id, int moveQid, THeMoveItem tHeMoveItem)
        {
            if (id != tHeMoveItem.AcKey || moveQid != tHeMoveItem.AnQid)
            {
                return BadRequest();
            }

            _context.Entry(tHeMoveItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!THeMoveItemExists(id, moveQid))
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

        // POST: api/MoveItems
        [HttpPost]
        public async Task<ActionResult<THeMoveItem>> PostTHeMoveItem(THeMoveItem tHeMoveItem)
        {
            _context.THeMoveItems.Add(tHeMoveItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTHeMoveItem), new { id = tHeMoveItem.AcKey, moveQid = tHeMoveItem.AnQid }, tHeMoveItem);
        }

        // DELETE: api/MoveItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTHeMoveItem(string id, int moveQid)
        {
            var tHeMoveItem = await _context.THeMoveItems
                .FirstOrDefaultAsync(item => item.AcKey == id && item.AnQid == moveQid);
            if (tHeMoveItem == null)
            {
                return NotFound();
            }

            _context.THeMoveItems.Remove(tHeMoveItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool THeMoveItemExists(string id, int moveQid)
        {
            return _context.THeMoveItems.Any(e => e.AcKey == id && e.AnQid == moveQid);
        }
    }
}
