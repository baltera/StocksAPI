using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stocks.Domain.Models;

namespace Stocks.Infrastructure.Persistence.FluentConfig
{
    public class ExchangeConfig : IEntityTypeConfiguration<Exchange>
    {
        public void Configure(EntityTypeBuilder<Exchange> modelBuilder)
        {
            modelBuilder.ToTable("exchange");
        }
    }
}
