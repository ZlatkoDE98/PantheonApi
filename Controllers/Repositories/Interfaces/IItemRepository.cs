using PantheonApi.DTOs.Item;
using PantheonApi.Models;

namespace PantheonApi.Repositories
{
    public interface IItemRepository
    {
        Task<IEnumerable<ItemDto>> GetAllItemsAsync();
        Task<ItemDto> GetItemByIdAsync(string id);
        Task<ItemDto> GetItemByNameAsync(string name);
        Task<IEnumerable<ItemDto>> GetItemsByCategoryAndMinQuantityAsync(string category, int minQuantity);
        Task<IEnumerable<THeSetItem>> GetFilteredItemsAsync(string fields);
    }
}