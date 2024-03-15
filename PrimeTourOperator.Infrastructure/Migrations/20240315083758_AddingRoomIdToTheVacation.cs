using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeTourOperator.Infrastructure.Migrations
{
    public partial class AddingRoomIdToTheVacation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Vacations",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Room for the vacation");

            migrationBuilder.CreateIndex(
                name: "IX_Vacations_RoomId",
                table: "Vacations",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_Rooms_RoomId",
                table: "Vacations",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_Rooms_RoomId",
                table: "Vacations");

            migrationBuilder.DropIndex(
                name: "IX_Vacations_RoomId",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Vacations");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Vacations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }
    }
}
