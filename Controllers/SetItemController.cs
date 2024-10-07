using Microsoft.AspNetCore.Mvc;
using PantheonApi.DTOs.Item;
using PantheonApi.Repositories.Interfaces;

namespace PantheonApi.Controllers
{
    [ApiController]
    [Route("api/items")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemRepository _itemRepository;

        public ItemsController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemDto>>> GetItems()
        {
            var items = await _itemRepository.GetAllItemsAsync();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ItemDto>> GetItemById(string id)
        {
            var item = await _itemRepository.GetItemByIdAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpGet("filter")]
        public async Task<ActionResult<IEnumerable<dynamic>>> GetFilteredItems([FromQuery] string fields)
        {
            try
            {
                var filteredItems = await _itemRepository.GetFilteredItemsAsync(fields);
                return Ok(filteredItems);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("prices")]
        public async Task<ActionResult<ItemPriceDto>> GetItemPrices(string id)
        {
            var item = await _itemRepository.GetItemPrices(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpGet("with-prices")]
        public async Task<ActionResult<IEnumerable<dynamic>>> GetItemsWithPrices()
        {
            var itemsWithPrices = await _itemRepository.GetItemsWithPricesAsync();
            return Ok(itemsWithPrices);
        }
    }
}
