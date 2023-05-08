using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stocks.Domain.Models;

namespace Stocks.Infrastructure.Persistence.FluentConfig
{
    public class StockConfig : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> modelBuilder)
        {
            modelBuilder.ToTable("stock");
        }
    }
}
