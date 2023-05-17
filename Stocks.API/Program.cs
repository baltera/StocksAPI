using Stocks.Application.Interfaces;
using Stocks.Infrastructure.Commons;
using Stocks.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var dataSettings = builder.Configuration.GetSection("Data");
string API_URL = dataSettings.GetValue<string>("ApiUrl");
string API_KEY = dataSettings.GetValue<string>("ApiKey");

builder.Services.AddScoped<StocksHttpClient>(serviceProvider =>
{
    return new StocksHttpClient(API_URL, API_KEY);
});

builder.Services.AddHttpClient<IStocksService, StockDataAPIService>();
builder.Services.AddScoped<IStocksService, StockDataAPIService>();

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder.AllowAnyHeader()
                        .AllowAnyMethod()
                        .WithOrigins("http://localhost:4200")
            );

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
