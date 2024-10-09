using PantheonApi.DTOs.Stock;

namespace PantheonApi.Repositories.Interfaces
{
    public interface IStockRepository
    {
        Task<IEnumerable<StockDto>> GetAllStocksAsync();
        Task<StockDto> GetStockByIdAsync(string warehouseId, string ident);
        Task<IEnumerable<dynamic>> GetFilteredStocksAsync(string fields);
    }
}
