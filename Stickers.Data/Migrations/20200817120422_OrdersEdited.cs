using Microsoft.EntityFrameworkCore.Migrations;

namespace Stickers.Data.Migrations
{
    public partial class OrdersEdited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CuttingThrough",
                table: "OrderItems");

            migrationBuilder.AlterColumn<decimal>(
                name: "DeliveryCost",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CuttingType",
                table: "OrderItems",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CuttingType",
                table: "OrderItems");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryCost",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<bool>(
                name: "CuttingThrough",
                table: "OrderItems",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
