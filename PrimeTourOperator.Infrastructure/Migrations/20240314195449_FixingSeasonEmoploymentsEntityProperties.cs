using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeTourOperator.Infrastructure.Migrations
{
    public partial class FixingSeasonEmoploymentsEntityProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeasonalEmployments_ApplicationUsers_AgentId",
                table: "SeasonalEmployments");

            migrationBuilder.AlterColumn<int>(
                name: "AgentId",
                table: "SeasonalEmployments",
                type: "int",
                nullable: false,
                comment: "Agent responsible for the offer",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldComment: "Agent resposive for the offer");

            migrationBuilder.AlterColumn<string>(
                name: "AdditionalExtras",
                table: "Rooms",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                comment: "Additional room extras",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "Additional room exrtas");

            migrationBuilder.AddForeignKey(
                name: "FK_SeasonalEmployments_Agents_AgentId",
                table: "SeasonalEmployments",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeasonalEmployments_Agents_AgentId",
                table: "SeasonalEmployments");

            migrationBuilder.AlterColumn<string>(
                name: "AgentId",
                table: "SeasonalEmployments",
                type: "nvarchar(450)",
                nullable: false,
                comment: "Agent resposive for the offer",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Agent responsible for the offer");

            migrationBuilder.AlterColumn<string>(
                name: "AdditionalExtras",
                table: "Rooms",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                comment: "Additional room exrtas",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true,
                oldComment: "Additional room extras");

            migrationBuilder.AddForeignKey(
                name: "FK_SeasonalEmployments_ApplicationUsers_AgentId",
                table: "SeasonalEmployments",
                column: "AgentId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
