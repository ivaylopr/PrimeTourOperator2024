using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeTourOperator.Infrastructure.Migrations
{
    public partial class AddingSeasonJobEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeasonalEmploymentId",
                table: "ApplicationUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SeasonalEmployments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Job title"),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Job description"),
                    HourlyWage = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Payment per hour"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Data for starting job"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "End date for the job"),
                    AgentId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Agent resposive for the offer"),
                    HotelId = table.Column<int>(type: "int", nullable: false, comment: "Hotel who is offering the season job")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeasonalEmployments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeasonalEmployments_ApplicationUsers_AgentId",
                        column: x => x.AgentId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeasonalEmployments_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Season job class");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_SeasonalEmploymentId",
                table: "ApplicationUsers",
                column: "SeasonalEmploymentId");

            migrationBuilder.CreateIndex(
                name: "IX_SeasonalEmployments_AgentId",
                table: "SeasonalEmployments",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_SeasonalEmployments_HotelId",
                table: "SeasonalEmployments",
                column: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUsers_SeasonalEmployments_SeasonalEmploymentId",
                table: "ApplicationUsers",
                column: "SeasonalEmploymentId",
                principalTable: "SeasonalEmployments",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUsers_SeasonalEmployments_SeasonalEmploymentId",
                table: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "SeasonalEmployments");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUsers_SeasonalEmploymentId",
                table: "ApplicationUsers");

            migrationBuilder.DropColumn(
                name: "SeasonalEmploymentId",
                table: "ApplicationUsers");
        }
    }
}
