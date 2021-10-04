using Microsoft.EntityFrameworkCore.Migrations;

namespace Stickers.Data.Migrations
{
    public partial class Add3FieldsForWorkReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CostMaterial",
                table: "WorkReports",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PaintCost",
                table: "WorkReports",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SpentMaterial",
                table: "WorkReports",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostMaterial",
                table: "WorkReports");

            migrationBuilder.DropColumn(
                name: "PaintCost",
                table: "WorkReports");

            migrationBuilder.DropColumn(
                name: "SpentMaterial",
                table: "WorkReports");
        }
    }
}
