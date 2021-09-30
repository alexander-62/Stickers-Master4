using Microsoft.EntityFrameworkCore.Migrations;

namespace Stickers.Data.Migrations
{
    public partial class FilmsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Film",
                table: "Rolls");

            migrationBuilder.DropColumn(
                name: "Film",
                table: "OrderItems");

            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "Rolls",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "OrderItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rolls_FilmId",
                table: "Rolls",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_FilmId",
                table: "OrderItems",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_Name",
                table: "Films",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Films_FilmId",
                table: "OrderItems",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rolls_Films_FilmId",
                table: "Rolls",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Films_FilmId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Rolls_Films_FilmId",
                table: "Rolls");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropIndex(
                name: "IX_Rolls_FilmId",
                table: "Rolls");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_FilmId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "Rolls");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "OrderItems");

            migrationBuilder.AddColumn<int>(
                name: "Film",
                table: "Rolls",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Film",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
