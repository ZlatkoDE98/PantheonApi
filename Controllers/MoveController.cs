using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PantheonApi.DTOs;
using PantheonApi.Models;
using System.Data;

namespace PantheonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class MoveController : ControllerBase
    {
        private readonly RsMfDemoContext _context;

        public MoveController(RsMfDemoContext context)
        {
            _context = context;
        }

        // GET: api/THeMove
        [HttpGet]
        public async Task<IActionResult> GetMove()
        {
            var moves = await _context.THeMoves
                .Include(m => m.THeMoveItems) // Include the related THeMoveItems
                .Select(m => new MoveDto
                {
                    AcKey = m.AcKey,
                    AcDocType = m.AcDocType,
                    AdDate = m.AdDate,
                    AcReceiver = m.AcReceiver,
                    AcIssuer = m.AcIssuer,
                    AcReceiverStock = m.AcReceiverStock,
                    AcIssuerStock = m.AcIssuerStock,
                    AcPrsn3 = m.AcPrsn3,
                    AcContactPrsn = m.AcContactPrsn,
                    AcDoc1 = m.AcDoc1,
                    AdDateDoc1 = m.AdDateDoc1,
                    AcDoc2 = m.AcDoc2,
                    AdDateDoc2 = m.AdDateDoc2,
                    AcStatement = m.AcStatement,
                    AcWayOfSale = m.AcWayOfSale,
                    AcPriceRate = m.AcPriceRate,
                    AcPayMethod = m.AcPayMethod,
                    AcDelivery = m.AcDelivery,
                    AcForm = m.AcForm,
                    AcInvoiceForm = m.AcInvoiceForm,
                    AdDateInv = m.AdDateInv,
                    AnDaysForPayment = m.AnDaysForPayment,
                    AdDateDue = m.AdDateDue,
                    AnValue = m.AnValue,
                    AnVat = m.AnVat,
                    AnDiscount = m.AnDiscount,
                    AnForPay = m.AnForPay,
                    THeMoveItems = m.THeMoveItems // Map the related THeMoveItems
                })
                .ToListAsync();

            return Ok(moves);
        }

        // GET: api/THeMove/5
        [HttpGet("{id}")]
        public async Task<ActionResult<THeMove>> GetTHeMove(string id)
        {
            var tHeMove = await _context.THeMoves
                                        .FirstOrDefaultAsync(m => m.AcKey == id);

            if (tHeMove == null)
            {
                return NotFound();
            }

            return tHeMove;
        }

        // DELETE: api/THeMove/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTHeMove(string id)
        {
            var tHeMove = await _context.THeMoves.FindAsync(id);
            if (tHeMove == null)
            {
                return NotFound();
            }

            _context.THeMoves.Remove(tHeMove);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool THeMoveExists(string id)
        {
            return _context.THeMoves.Any(e => e.AcKey == id);
        }
[HttpPost("CreateMove")]
    public async Task<IActionResult> CreateMove([FromBody] MoveCreationDto moveDto)
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

                // Execute the main stored procedure
                await _context.Database.ExecuteSqlRawAsync(
                    "EXEC pHE_MoveCreAll @acDocType, @acReceiver, @acIssuer, @adDate, @param1, @param2, @acKeyNew OUTPUT, 'F', @cStatus OUTPUT, @cError OUTPUT",
                    new SqlParameter("@acDocType", moveDto.AcDocType),
                    new SqlParameter("@acReceiver", moveDto.AcReceiver),
                    new SqlParameter("@acIssuer", moveDto.AcIssuer),
                    new SqlParameter("@adDate", moveDto.AdDate),
                    new SqlParameter("@param1", 1),
                    new SqlParameter("@param2", string.Empty),
                    acKeyParameter,
                    cStatusParameter,
                    cErrorParameter
                );

                var acKeyNew = (string)acKeyParameter.Value;

                // Update the main move table
                
                // Handle items (assuming there's a list of items in moveDto)
                foreach (var item in moveDto.MoveItems)
                {
                    // Create move item
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
                        "EXEC pHE_MoveItemsCreAll @acKeyNew, @acIdent, @anQty, '', 1, @anNo OUTPUT, @cErrorItem OUTPUT, @cStatusItem OUTPUT",
                        new SqlParameter("@acKeyNew", acKeyNew),
                        new SqlParameter("@acIdent", item.AcIdent),
                        new SqlParameter("@anQty", item.AnQty),
                        acNoParameter,
                        cErrorItemParameter,
                        cStatusItemParameter
                    );

                    var anNo = acNoParameter.Value != DBNull.Value ? (int)acNoParameter.Value : (int?)null;

                    Console.WriteLine($"acKeyNew: {acKeyNew}");
                    Console.WriteLine($"anNo: {acNoParameter.Value}");


                    //Finalize item operations
                    await _context.Database.ExecuteSqlRawAsync(
                        "EXEC pHE_MoveItemOutPVItem @acKeyNew, @anNo",
                        new SqlParameter("@acKeyNew", acKeyNew),
                        new SqlParameter("@anNo", anNo)
                    );

                    await _context.Database.ExecuteSqlRawAsync(
                        "EXEC pHE_MoveSetSum @acKeyNew",
                        new SqlParameter("@acKeyNew", acKeyNew)
                    );
                }

                // Commit transaction
                await transaction.CommitAsync();

                return Ok(new { acKey = acKeyNew });
            }
            catch (Exception ex)
            {
                // Rollback transaction in case of error
                await transaction.RollbackAsync();
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
     
    }
}
