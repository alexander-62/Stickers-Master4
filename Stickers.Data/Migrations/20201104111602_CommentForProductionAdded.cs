using Microsoft.EntityFrameworkCore.Migrations;

namespace Stickers.Data.Migrations
{
    public partial class CommentForProductionAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "OrderItems",
                newName: "CommentForDesigner");

            migrationBuilder.AddColumn<string>(
                name: "CommentForProduction",
                table: "OrderItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommentForDesigner",
                table: "OrderItems",
                newName: "Comment");

            migrationBuilder.DropColumn(
                name: "CommentForProduction",
                table: "OrderItems");
        }
    }
}
