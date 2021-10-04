using Microsoft.EntityFrameworkCore.Migrations;

namespace Stickers.Data.Migrations
{
    public partial class AddPaint_priceFieldToCost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Paint_price",
                table: "Costs",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Paint_price",
                table: "Costs");
        }
    }
}
