using Microsoft.EntityFrameworkCore.Migrations;

namespace Stickers.Data.Migrations
{
    public partial class RollAddedToWorkReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RollId",
                table: "WorkReports",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkReports_RollId",
                table: "WorkReports",
                column: "RollId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkReports_Rolls_RollId",
                table: "WorkReports",
                column: "RollId",
                principalTable: "Rolls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkReports_Rolls_RollId",
                table: "WorkReports");

            migrationBuilder.DropIndex(
                name: "IX_WorkReports_RollId",
                table: "WorkReports");

            migrationBuilder.DropColumn(
                name: "RollId",
                table: "WorkReports");
        }
    }
}
