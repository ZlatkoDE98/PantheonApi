using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PantheonApi.Models;
using System.Linq.Dynamic.Core;

namespace PantheonApi.Controllers
{
    [ApiController]
    [Route("api/items")]
    public class ItemsController : ControllerBase
    {
        private readonly RsMfDemoContext _context;

        public ItemsController(RsMfDemoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<THeSetItem>>> GetItems()
        {
            return await _context.THeSetItems.ToListAsync();
        }

        [HttpGet("filter")]
        public async Task<ActionResult<IEnumerable<dynamic>>> GetFilteredItems([FromQuery] string fields)
        {
            if (string.IsNullOrWhiteSpace(fields))
            {
                return BadRequest("No fields specified.");
            }

            var selectedFields = fields.Split(',');
            var validFields = typeof(THeSetItem).GetProperties()
                                                .Select(p => p.Name)
                                                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            foreach (var field in selectedFields)
            {
                if (!validFields.Contains(field.Trim()))
                {
                    return BadRequest($"Field '{field}' is not valid.");
                }
            }

            var query = _context.THeSetItems
                .Select($"new({string.Join(",", selectedFields)})");

            var result = await query.ToDynamicListAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<THeSetItem>> GetItemById(string id)
        {
            var item = await _context.THeSetItems
                .FirstOrDefaultAsync(i => i.AcIdent == id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpGet("name/{name}")]
        public async Task<ActionResult<THeSetItem>> GetItemByName(string name)
        {
            var item = await _context.THeSetItems
                .FirstOrDefaultAsync(i => i.AcName == name);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }
    }
}