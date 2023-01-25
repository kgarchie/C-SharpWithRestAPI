using BuyAirtime.Contracts;
using Microsoft.AspNetCore.Mvc;
using MyAirtime.WebAPI.Data;
using MyAirtime.WebAPI.Models;
using MyAirtime.WebAPI.Services.Transaction;

namespace MyAirtime.WebAPI.Controllers;

[ApiController]
[Route("transactions")]
public class TransactionController : ControllerBase
{
    private readonly ITransactionService _transactionService;
    

    public TransactionController(ITransactionService transactionService, ApplicationDatabaseContext db)
    {
        _transactionService = transactionService;
    }

    [HttpPost("buy-airtime")]
    public IActionResult BuyAirtime(BuyAirtimeRequest request)
    {
        var transaction = new Transaction(request.ToUser, request.FromUser, request.Amount);
        
        _transactionService.MakeTransaction(transaction);
        
        return Ok(request);
    }

    [HttpGet("user/{id:int}")]
    public IActionResult GetRecentTransactions(int id)
    {
        return Ok(id);
    }
}