using PantheonApi.Models;

namespace PantheonApi.Repositories.Interfaces;

    public interface IOrderRepository
    {
        Task<IEnumerable<THeOrder>> GetAllOrdersAsync();
        Task<THeOrder> GetOrderByIdAsync(string id);
        Task<bool> OrderExistsAsync(string id);
        Task<string> CreateOrderAsync(OrderCreationDto orderDto);
    }



