using Microsoft.EntityFrameworkCore;
using MyAirtime.WebAPI.Models;

namespace MyAirtime.WebAPI.Data;
public class ApplicationDatabaseContext : DbContext
{
    public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options){}
    
    public DbSet<Transaction> Transactions { get; set; }
}