using PantheonApi.DTOs.Item;

namespace PantheonApi.Repositories.Interfaces;

public interface IItemRepository
    {
        Task<IEnumerable<ItemDto>> GetAllItemsAsync();
        Task<ItemDto> GetItemByIdAsync(string id);
        Task<IEnumerable<dynamic>> GetFilteredItemsAsync(string fields);
        Task<ItemPriceDto> GetItemPrices(string id);
        Task<IEnumerable<dynamic>> GetItemPrices();
        Task<IEnumerable<dynamic>> GetItemsWithPricesAsync();
    }
