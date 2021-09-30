using Microsoft.EntityFrameworkCore.Migrations;

namespace Stickers.Data.Migrations
{
    public partial class AddedFieldsForProduction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CutCount",
                table: "OrderItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LaminatedCount",
                table: "OrderItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlotteredCount",
                table: "OrderItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrintedCount",
                table: "OrderItems",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CutCount",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "LaminatedCount",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "PlotteredCount",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "PrintedCount",
                table: "OrderItems");
        }
    }
}
