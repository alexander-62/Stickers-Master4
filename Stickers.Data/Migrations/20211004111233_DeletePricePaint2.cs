using Microsoft.EntityFrameworkCore.Migrations;

namespace Stickers.Data.Migrations
{
    public partial class DeletePricePaint2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Paint_price",
                table: "Costs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Paint_price",
                table: "Costs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
