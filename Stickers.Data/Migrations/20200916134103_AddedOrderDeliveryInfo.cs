using Microsoft.EntityFrameworkCore.Migrations;

namespace Stickers.Data.Migrations
{
    public partial class AddedOrderDeliveryInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeliveryAddress",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostIndex",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiverCredentials",
                table: "Orders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryAddress",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PostIndex",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ReceiverCredentials",
                table: "Orders");
        }
    }
}
