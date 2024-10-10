using PantheonApi.DTOs.Stock;

namespace PantheonApi.Repositories.Interfaces
{
    public interface IStockRepository
    {
        Task<IEnumerable<StockDto>> GetAllStocksAsync();
        Task<StockDto> GetStockIdentById(string warehouseId, string ident);
        Task<List<StockDto>> GetByWarehouseIdAsync(string warehouseId);
        Task<List<StockDto>> GetByIdentIdAsync(string ident);
        Task<IEnumerable<dynamic>> GetFilteredStocksAsync(string fields);
    }
}
