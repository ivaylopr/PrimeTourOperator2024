using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeTourOperator.Infrastructure.Migrations
{
    public partial class RemoveAppU : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agents_ApplicationUsers_UserId",
                table: "Agents");

            migrationBuilder.DropForeignKey(
                name: "FK_VacationCustomers_ApplicationUsers_UserId",
                table: "VacationCustomers");

            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.AddColumn<int>(
                name: "SeasonalEmploymentId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SeasonalEmploymentId",
                table: "AspNetUsers",
                column: "SeasonalEmploymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agents_AspNetUsers_UserId",
                table: "Agents",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SeasonalEmployments_SeasonalEmploymentId",
                table: "AspNetUsers",
                column: "SeasonalEmploymentId",
                principalTable: "SeasonalEmployments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VacationCustomers_AspNetUsers_UserId",
                table: "VacationCustomers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agents_AspNetUsers_UserId",
                table: "Agents");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SeasonalEmployments_SeasonalEmploymentId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_VacationCustomers_AspNetUsers_UserId",
                table: "VacationCustomers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SeasonalEmploymentId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SeasonalEmploymentId",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    Companion = table.Column<int>(type: "int", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SeasonalEmploymentId = table.Column<int>(type: "int", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUsers_SeasonalEmployments_SeasonalEmploymentId",
                        column: x => x.SeasonalEmploymentId,
                        principalTable: "SeasonalEmployments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_SeasonalEmploymentId",
                table: "ApplicationUsers",
                column: "SeasonalEmploymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agents_ApplicationUsers_UserId",
                table: "Agents",
                column: "UserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VacationCustomers_ApplicationUsers_UserId",
                table: "VacationCustomers",
                column: "UserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
