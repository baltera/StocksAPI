﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Stocks.Infrastructure.Persistence.Data;

#nullable disable

namespace Stocks.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20230508184501_AddModelToDB_TblsExchangeNStockNStockQuote")]
    partial class AddModelToDB_TblsExchangeNStockNStockQuote
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);
#pragma warning restore 612, 618
        }
    }
}
