using Microsoft.EntityFrameworkCore;

namespace Stocks.Infrastructure.Persistence.Data
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ERAMIREZ;Database=Stocks;TrustServerCertificate=True;Trusted_Connection=True;");
        }

    }
}
