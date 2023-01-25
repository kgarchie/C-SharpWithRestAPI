using MyAirtime.WebAPI.Data;

namespace MyAirtime.WebAPI.Services.Transaction;

/* Transaction Status Codes
 * 101 - Initial
 * 102 - In Progress
 * 103 - Complete
 * 105 - Failed
 */

public class TransactionService : ITransactionService
{
    private readonly ApplicationDatabaseContext _db;

    public TransactionService(ApplicationDatabaseContext db)
    {
        _db = db;
    }

    public void MakeTransaction(Models.Transaction transaction)
    {
        transaction.StatusCode = 103;
        _db.Transactions.Add(transaction);
        _db.SaveChanges();
    }
}