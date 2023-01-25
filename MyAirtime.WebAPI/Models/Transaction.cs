using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAirtime.WebAPI.Models;

public class Transaction : ITransaction
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int Id { get; set; }
    [Required]
    public string ToUser { get; set; }
    [Required]
    public string FromUser { get; set; }
    [Required]
    public string? TransactionId { get; set; }
    public DateTime TransactionDateTime { get; set; }
    public string TransactionType { get; set; }
    
    public int? StatusCode { get; set; }
    public int Amount { get; set; }

    public Transaction(string toUser, string fromUser, int amount)
    {
        ToUser = toUser;
        FromUser = fromUser;
        TransactionId = GenerateTransactionId(toUser, fromUser) ?? null;
        TransactionDateTime = DateTime.Now;
        Amount = amount;
        TransactionType = "Undefined";
    }
}