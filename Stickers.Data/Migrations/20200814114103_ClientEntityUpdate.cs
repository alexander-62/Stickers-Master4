using Microsoft.EntityFrameworkCore.Migrations;

namespace Stickers.Data.Migrations
{
    public partial class ClientEntityUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BusinessClients_Name",
                table: "BusinessClients");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "BusinessClients");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "BusinessClients",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostIndex",
                table: "BusinessClients",
                maxLength: 6,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiverCredentials",
                table: "BusinessClients",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VkId",
                table: "BusinessClients",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "BusinessClients");

            migrationBuilder.DropColumn(
                name: "PostIndex",
                table: "BusinessClients");

            migrationBuilder.DropColumn(
                name: "ReceiverCredentials",
                table: "BusinessClients");

            migrationBuilder.DropColumn(
                name: "VkId",
                table: "BusinessClients");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BusinessClients",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessClients_Name",
                table: "BusinessClients",
                column: "Name",
                unique: true);
        }
    }
}
