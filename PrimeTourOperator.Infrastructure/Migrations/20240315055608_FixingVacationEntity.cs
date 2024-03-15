using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeTourOperator.Infrastructure.Migrations
{
    public partial class FixingVacationEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_VacationCategories_CategoryId",
                table: "Vacations");

            migrationBuilder.DropIndex(
                name: "IX_Vacations_CategoryId",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Vacations");

            migrationBuilder.RenameColumn(
                name: "VacationCapacity",
                table: "Vacations",
                newName: "VacationCategoryId");

            migrationBuilder.AddColumn<int>(
                name: "HotelId",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Hotel identifier of the holiday");

            migrationBuilder.AddColumn<decimal>(
                name: "AllInclusivePrice",
                table: "Hotels",
                type: "decimal(18,2)",
                nullable: true,
                comment: "All inclusive additional price to the room offer");

            migrationBuilder.CreateIndex(
                name: "IX_Vacations_HotelId",
                table: "Vacations",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacations_VacationCategoryId",
                table: "Vacations",
                column: "VacationCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_Hotels_HotelId",
                table: "Vacations",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_VacationCategories_VacationCategoryId",
                table: "Vacations",
                column: "VacationCategoryId",
                principalTable: "VacationCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_Hotels_HotelId",
                table: "Vacations");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_VacationCategories_VacationCategoryId",
                table: "Vacations");

            migrationBuilder.DropIndex(
                name: "IX_Vacations_HotelId",
                table: "Vacations");

            migrationBuilder.DropIndex(
                name: "IX_Vacations_VacationCategoryId",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "AllInclusivePrice",
                table: "Hotels");

            migrationBuilder.RenameColumn(
                name: "VacationCategoryId",
                table: "Vacations",
                newName: "VacationCapacity");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vacations_CategoryId",
                table: "Vacations",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_VacationCategories_CategoryId",
                table: "Vacations",
                column: "CategoryId",
                principalTable: "VacationCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
