using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stocks.Infrastructure.Persistence.Migrations
{
    public partial class addRelationship_OneToMany_StockQuotes_Stocks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stock_Id",
                table: "stock_quote",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_stock_quote_Stock_Id",
                table: "stock_quote",
                column: "Stock_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_stock_quote_stock_Stock_Id",
                table: "stock_quote",
                column: "Stock_Id",
                principalTable: "stock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_stock_quote_stock_Stock_Id",
                table: "stock_quote");

            migrationBuilder.DropIndex(
                name: "IX_stock_quote_Stock_Id",
                table: "stock_quote");

            migrationBuilder.DropColumn(
                name: "Stock_Id",
                table: "stock_quote");
        }
    }
}
