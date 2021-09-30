using Microsoft.EntityFrameworkCore.Migrations;

namespace Stickers.Data.Migrations
{
    public partial class WorkRepostPaperParametersEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkReports_OrderItems_OrderItemId",
                table: "WorkReports");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkReports_Rolls_RollId",
                table: "WorkReports");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkReports_Users_UserId",
                table: "WorkReports");

            migrationBuilder.AlterColumn<string>(
                name: "PaperParameters",
                table: "WorkReports",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkReports_OrderItems_OrderItemId",
                table: "WorkReports",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkReports_Rolls_RollId",
                table: "WorkReports",
                column: "RollId",
                principalTable: "Rolls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkReports_Users_UserId",
                table: "WorkReports",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkReports_OrderItems_OrderItemId",
                table: "WorkReports");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkReports_Rolls_RollId",
                table: "WorkReports");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkReports_Users_UserId",
                table: "WorkReports");

            migrationBuilder.AlterColumn<string>(
                name: "PaperParameters",
                table: "WorkReports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkReports_OrderItems_OrderItemId",
                table: "WorkReports",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkReports_Rolls_RollId",
                table: "WorkReports",
                column: "RollId",
                principalTable: "Rolls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkReports_Users_UserId",
                table: "WorkReports",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
