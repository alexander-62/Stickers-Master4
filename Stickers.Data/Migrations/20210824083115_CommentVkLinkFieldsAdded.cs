using Microsoft.EntityFrameworkCore.Migrations;

namespace Stickers.Data.Migrations
{
    public partial class CommentVkLinkFieldsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "BusinessClients",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VkLink",
                table: "BusinessClients",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "BusinessClients");

            migrationBuilder.DropColumn(
                name: "VkLink",
                table: "BusinessClients");
        }
    }
}
