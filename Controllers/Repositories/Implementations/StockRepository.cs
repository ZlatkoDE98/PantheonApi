using Microsoft.EntityFrameworkCore;
using PantheonApi.DTOs.Stock;
using System.Linq.Dynamic.Core;
using PantheonApi.Models;
using PantheonApi.Repositories.Interfaces;

namespace PantheonApi.Repositories.Implementations
{
    public class StockRepository : IStockRepository
    {
        private readonly RsMfDemoContext _context;

        public StockRepository(RsMfDemoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StockDto>> GetAllStocksAsync()
        {
            return await _context.THeStocks
                .Select(s => new StockDto
                {
                    AcWarehouse = s.AcWarehouse,
                    AcIdent = s.AcIdent,
                    AnStock = s.AnStock,
                    AnValue = s.AnValue,
                    AnLastPrice = s.AnLastPrice,
                    AdTimeChg = s.AdTimeChg,
                    AnReserved = s.AnReserved,
                    AdTimeIns = s.AdTimeIns,
                    AnUserIns = s.AnUserIns,
                    AnUserChg = s.AnUserChg,
                    AnMinStock = s.AnMinStock,
                    AnOptStock = s.AnOptStock,
                    AnMaxStock = s.AnMaxStock,
                    AnQid = s.AnQid
                })
                .ToListAsync();
        }

        public async Task<StockDto> GetStockIdentById(string warehouseId, string ident)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _context.THeStocks
                .Where(s => s.AcWarehouse == warehouseId && s.AcIdent == ident)
                .Select(s => new StockDto
                {
                    AcWarehouse = s.AcWarehouse,
                    AcIdent = s.AcIdent,
                    AnStock = s.AnStock,
                    AnValue = s.AnValue,
                    AnLastPrice = s.AnLastPrice,
                    AdTimeChg = s.AdTimeChg,
                    AnReserved = s.AnReserved,
                    AdTimeIns = s.AdTimeIns,
                    AnUserIns = s.AnUserIns,
                    AnUserChg = s.AnUserChg,
                    AnMinStock = s.AnMinStock,
                    AnOptStock = s.AnOptStock,
                    AnMaxStock = s.AnMaxStock,
                    AnQid = s.AnQid
                })
                .FirstOrDefaultAsync();
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<List<StockDto>> GetByWarehouseIdAsync(string warehouseId)
        {
            return await _context.THeStocks
                .Where(s => s.AcWarehouse == warehouseId)
                .Select(s => new StockDto
                {
                    AcWarehouse = s.AcWarehouse,
                    AcIdent = s.AcIdent,
                    AnStock = s.AnStock,
                    AnValue = s.AnValue,
                    AnLastPrice = s.AnLastPrice,
                    AdTimeChg = s.AdTimeChg,
                    AnReserved = s.AnReserved,
                    AdTimeIns = s.AdTimeIns,
                    AnUserIns = s.AnUserIns,
                    AnUserChg = s.AnUserChg,
                    AnMinStock = s.AnMinStock,
                    AnOptStock = s.AnOptStock,
                    AnMaxStock = s.AnMaxStock,
                    AnQid = s.AnQid
                })
                .ToListAsync();
        }

        public async Task<List<StockDto>> GetByIdentIdAsync(string ident)
        {
            return await _context.THeStocks
                .Where(s => s.AcIdent == ident)
                .Select(s => new StockDto
                {
                    AcWarehouse = s.AcWarehouse,
                    AcIdent = s.AcIdent,
                    AnStock = s.AnStock,
                    AnValue = s.AnValue,
                    AnLastPrice = s.AnLastPrice,
                    AdTimeChg = s.AdTimeChg,
                    AnReserved = s.AnReserved,
                    AdTimeIns = s.AdTimeIns,
                    AnUserIns = s.AnUserIns,
                    AnUserChg = s.AnUserChg,
                    AnMinStock = s.AnMinStock,
                    AnOptStock = s.AnOptStock,
                    AnMaxStock = s.AnMaxStock,
                    AnQid = s.AnQid
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<dynamic>> GetFilteredStocksAsync(string fields)
        {
            if (string.IsNullOrWhiteSpace(fields))
            {
                throw new ArgumentException("Fields must be specified", nameof(fields));
            }
            
            var selectedFields = fields.Split(',');
            var validFields = typeof(THeStock).GetProperties()
                                                .Select(p => p.Name)
                                                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            foreach (var field in selectedFields)
            {
                if (!validFields.Contains(field.Trim()))
                {
                    throw new ArgumentException($"Field '{field}' is not valid.", nameof(fields));
                }
            }

            var query = _context.THeStocks
                .Select($"new({string.Join(",", selectedFields)})");
            
            return await query.ToDynamicListAsync();
        }
    }
}
