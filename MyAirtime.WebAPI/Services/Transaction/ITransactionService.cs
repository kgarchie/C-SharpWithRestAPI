using MyAirtime.WebAPI.Data;

namespace MyAirtime.WebAPI.Services.Transaction;

public interface ITransactionService
{
    void MakeTransaction(Models.Transaction transaction);
}