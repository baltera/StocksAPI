using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stocks.Infrastructure.Persistence.Migrations
{
    public partial class AddFluentModelsConfig_TableNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockQuotes",
                table: "StockQuotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exchanges",
                table: "Exchanges");

            migrationBuilder.RenameTable(
                name: "Stocks",
                newName: "stock");

            migrationBuilder.RenameTable(
                name: "StockQuotes",
                newName: "stock_quote");

            migrationBuilder.RenameTable(
                name: "Exchanges",
                newName: "exchange");

            migrationBuilder.AddPrimaryKey(
                name: "PK_stock",
                table: "stock",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_stock_quote",
                table: "stock_quote",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_exchange",
                table: "exchange",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_stock_quote",
                table: "stock_quote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_stock",
                table: "stock");

            migrationBuilder.DropPrimaryKey(
                name: "PK_exchange",
                table: "exchange");

            migrationBuilder.RenameTable(
                name: "stock_quote",
                newName: "StockQuotes");

            migrationBuilder.RenameTable(
                name: "stock",
                newName: "Stocks");

            migrationBuilder.RenameTable(
                name: "exchange",
                newName: "Exchanges");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockQuotes",
                table: "StockQuotes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stocks",
                table: "Stocks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exchanges",
                table: "Exchanges",
                column: "Id");
        }
    }
}
