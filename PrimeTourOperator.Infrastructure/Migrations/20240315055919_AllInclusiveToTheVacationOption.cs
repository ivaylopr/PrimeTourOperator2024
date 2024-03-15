using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeTourOperator.Infrastructure.Migrations
{
    public partial class AllInclusiveToTheVacationOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AllInclusive",
                table: "Vacations",
                type: "bit",
                nullable: true,
                comment: "Is all inclusive option added to the vacation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllInclusive",
                table: "Vacations");
        }
    }
}
