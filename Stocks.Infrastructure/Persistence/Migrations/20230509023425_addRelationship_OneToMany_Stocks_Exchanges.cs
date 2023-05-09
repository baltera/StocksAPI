using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stocks.Infrastructure.Persistence.Migrations
{
    public partial class addRelationship_OneToMany_Stocks_Exchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Exchange_Id",
                table: "stock",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_stock_Exchange_Id",
                table: "stock",
                column: "Exchange_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_stock_exchange_Exchange_Id",
                table: "stock",
                column: "Exchange_Id",
                principalTable: "exchange",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_stock_exchange_Exchange_Id",
                table: "stock");

            migrationBuilder.DropIndex(
                name: "IX_stock_Exchange_Id",
                table: "stock");

            migrationBuilder.DropColumn(
                name: "Exchange_Id",
                table: "stock");
        }
    }
}
