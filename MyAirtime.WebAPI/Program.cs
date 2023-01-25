using Microsoft.EntityFrameworkCore;
using MyAirtime.WebAPI.Data;
using MyAirtime.WebAPI.Services.Transaction;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ITransactionService, TransactionService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDatabaseContext>(options => options
    .UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty)
    .LogTo(Console.WriteLine, LogLevel.Information)
    .EnableDetailedErrors()
    .EnableSensitiveDataLogging());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
