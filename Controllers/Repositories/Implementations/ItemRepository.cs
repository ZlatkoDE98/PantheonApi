using Microsoft.EntityFrameworkCore;
using PantheonApi.Models;
using System.Linq.Dynamic.Core;
using PantheonApi.DTOs.Item;
using PantheonApi.Repositories.Interfaces;

namespace PantheonApi.Repositories.Implementations
{
    public class ItemRepository : IItemRepository
    {
        private readonly RsMfDemoContext _context;

        public ItemRepository(RsMfDemoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ItemDto>> GetAllItemsAsync()
        {
            return await _context.THeSetItems
                .Select(i => new ItemDto
                {
                    AcIdent = i.AcIdent,
                    AcName = i.AcName,
                    AnSalePrice = i.AnSalePrice,
                    anBuyPrice = i.AnBuyPrice,
                    AcCode = i.AcCode,
                    AnRebate = i.AnRebate
                })
                .ToListAsync();
        }

        public async Task<ItemDto> GetItemByIdAsync(string id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _context.THeSetItems
                .Where(i => i.AcIdent == id)
                .Select(i => new ItemDto
                {
                    AcIdent = i.AcIdent,
                    AcName = i.AcName,
                    AnSalePrice = i.AnSalePrice,
                    anBuyPrice = i.AnBuyPrice,
                    AcCode = i.AcCode,
                    AnRebate = i.AnRebate
                })
                .FirstOrDefaultAsync();
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<IEnumerable<dynamic>> GetFilteredItemsAsync(string fields)
        {
            if (string.IsNullOrWhiteSpace(fields))
            {
                throw new ArgumentException("Fields must be specified", nameof(fields));
            }

            var selectedFields = fields.Split(',');
            var validFields = typeof(THeSetItem).GetProperties()
                                                .Select(p => p.Name)
                                                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            foreach (var field in selectedFields)
            {
                if (!validFields.Contains(field.Trim()))
                {
                    throw new ArgumentException($"Field '{field}' is not valid.", nameof(fields));
                }
            }

            var query = _context.THeSetItems
                .Select($"new({string.Join(",", selectedFields)})");

            return await query.ToDynamicListAsync();
        }

        public async Task<ItemPriceDto> GetItemPrices(string id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _context.THeSetItems
                .Where(i => i.AcIdent == id)
                .Select(i => new ItemPriceDto
                {
                    AcIdent = i.AcIdent,
                    AcName = i.AcName,
                    AnSalePrice = i.AnSalePrice,
                    anBuyPrice = i.AnBuyPrice,
                    anPrice = i.AnPrice
                })
                .FirstOrDefaultAsync();
#pragma warning restore CS8603 // Possible null reference return.
        }


        //dodati THeSetItemPriceForWrh tabelu
        public async Task<IEnumerable<dynamic>> GetItemsWithPricesAsync()
        {
            var query = from item in _context.THeSetItems
                        join price in _context.THeSetItemPriceForWrhs
                        on item.AcIdent equals price.AcIdent
                        select new
                        {
                            item.AcIdent,
                            item.AcName,
                            item.AcCode,
                            item.AnPrice,
                            price.AnWsprice,
                            price.AnBuyPrice,
                            price.AcWarehouse
                        };

            return await query.ToListAsync();
        }
    }
}
