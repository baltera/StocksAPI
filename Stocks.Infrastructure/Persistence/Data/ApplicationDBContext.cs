using Microsoft.EntityFrameworkCore;
using Stocks.Domain.Models;

namespace Stocks.Infrastructure.Persistence.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Exchange> Exchanges { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockQuote> StockQuotes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ERAMIREZ;Database=Stocks;TrustServerCertificate=True;Trusted_Connection=True;");
        }        

    }
}
