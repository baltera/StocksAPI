using Microsoft.EntityFrameworkCore;
namespace Stocks.Infrastructure.Data
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ERAMIREZ;Databse=Stocks;TrustServerCertificate=True;Trusted_Connection=True;");
        }

    }
}
