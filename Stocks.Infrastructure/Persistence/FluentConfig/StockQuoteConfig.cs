using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stocks.Domain.Models;

namespace Stocks.Infrastructure.Persistence.FluentConfig
{
    public class StockQuoteConfig : IEntityTypeConfiguration<StockQuote>
    {
        public void Configure(EntityTypeBuilder<StockQuote> modelBuilder)
        {
            modelBuilder.ToTable("stock_quote");
        }
    }
}
