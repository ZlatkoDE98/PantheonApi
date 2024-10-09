// OrderRepository.cs
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PantheonApi.Models;
using PantheonApi.Repositories.Interfaces;

namespace PantheonApi.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly RsMfDemoContext _context;

        public OrderRepository(RsMfDemoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<THeOrder>> GetAllOrdersAsync()
        {
            return await _context.THeOrders
                .ToListAsync();
        }

        public async Task<THeOrder> GetOrderByIdAsync(string id)
        {
            return await _context.THeOrders
                .Include(o => o.THeOrderItems)
                .FirstOrDefaultAsync(o => o.AcKey == id);
        }

        public async Task<bool> OrderExistsAsync(string id)
        {
            return await _context.THeOrders.AnyAsync(e => e.AcKey == id);
        }

        public async Task<string> CreateOrderAsync(OrderCreationDto orderDto)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    // Prepare output parameters for the stored procedure
                    var acKeyParameter = new SqlParameter("@acKeyNew", SqlDbType.Char, 13)
                    {
                        Direction = ParameterDirection.Output
                    };
                    var cStatusParameter = new SqlParameter("@cStatus", SqlDbType.Char, 1)
                    {
                        Direction = ParameterDirection.Output
                    };
                    var cErrorParameter = new SqlParameter("@cError", SqlDbType.VarChar, 1024)
                    {
                        Direction = ParameterDirection.Output
                    };

                    // Execute the main stored procedure for creating the order
                    await _context.Database.ExecuteSqlRawAsync(
                        //"EXEC pHE_OrderCreAll @acDocType, @acReceiver, @acIssuer, '', @adDate, @param1, @param2, @acKeyNew OUTPUT, 'F', @cStatus OUTPUT, @cError OUTPUT",
                        "EXEC pHE_OrderCreAll @acDocType, @acReceiver, @acIssuer, '', @adDate, @param1, @param2, @acKeyNew OUTPUT, '', @cStatus OUTPUT, @cError OUTPUT",
                        new SqlParameter("@acDocType", orderDto.AcDocType),
                        new SqlParameter("@acReceiver", orderDto.AcReceiver),
                        new SqlParameter("@acIssuer", orderDto.AcIssuer),
                        new SqlParameter("@adDate", orderDto.AdDate),
                        new SqlParameter("@param1", 1),
                        new SqlParameter("@param2", string.Empty),
                        acKeyParameter,
                        cStatusParameter,
                        cErrorParameter
                    );

                    var acKeyNew = (string)acKeyParameter.Value;

                    // Handle items (assuming there's a list of items in orderDto)
                    foreach (var item in orderDto.OrderItems)
                    {
                        // Create order item
                        var acNoParameter = new SqlParameter("@anNo", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        var cErrorItemParameter = new SqlParameter("@cErrorItem", SqlDbType.VarChar, 1024)
                        {
                            Direction = ParameterDirection.Output
                        };
                        var cStatusItemParameter = new SqlParameter("@cStatusItem", SqlDbType.Char, 1)
                        {
                            Direction = ParameterDirection.Output
                        };

                        await _context.Database.ExecuteSqlRawAsync(
                           // "EXEC pHE_OrderItemsCreAll @acKeyNew, @acIdent, @anQty, '', 1, @anNo OUTPUT, @cErrorItem OUTPUT, @cStatusItem OUTPUT",
                            "EXEC pHE_OrderCreItemAll @acKeyNew, @acIdent, @anQty, '', 1, @anNo OUTPUT",
                            new SqlParameter("@acKeyNew", acKeyNew),
                            new SqlParameter("@acIdent", item.AcIdent),
                            new SqlParameter("@anQty", item.AnQty),
                            acNoParameter,
                            cErrorItemParameter,
                            cStatusItemParameter
                        );

                        var anNo = acNoParameter.Value != DBNull.Value ? (int)acNoParameter.Value : (int?)null;
                        

                        //Finalize item operations
                        await _context.Database.ExecuteSqlRawAsync(
                            "EXEC pHE_OrderItemOutPVItem @acKeyNew, @anNo",
                            new SqlParameter("@acKeyNew", acKeyNew),
                            new SqlParameter("@anNo", anNo)
                        );

                        // await _context.Database.ExecuteSqlRawAsync(
                        //     "EXEC pHE_OrderSetSum @acKeyNew",
                        //     new SqlParameter("@acKeyNew", acKeyNew)
                        // );
                    }

                    // Commit transaction
                    await transaction.CommitAsync();

                    return acKeyNew; // Return the new key after successful creation
                }
                catch (Exception ex)
                {
                    // Rollback transaction in case of error
                    await transaction.RollbackAsync();
                    throw new Exception("An error occurred while creating the order: " + ex.Message);
                }
            }
        }
    }
}
