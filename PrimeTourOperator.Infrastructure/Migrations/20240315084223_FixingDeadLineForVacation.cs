using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeTourOperator.Infrastructure.Migrations
{
    public partial class FixingDeadLineForVacation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EnrollmentDeadline",
                table: "Vacations",
                type: "datetime2",
                nullable: true,
                comment: "Vacation enrollment deadline",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Vacation enrollment deadline");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "009c025b-05ed-41e7-bedd-15106b22946e", "AQAAAAEAACcQAAAAEFH7I7x2Qh1xSK1YjOTKc+C951oaPPB6wFf2ppJmrH41rBrqNogNjxQMLJA1rbuTbA==", "3275e351-e2d6-49e7-8be5-cf676af81ab9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "169c21f6-c075-448c-9e86-d77c5a903a97", "AQAAAAEAACcQAAAAEAhJ1yZuzSm7dI65bdV2M3DkxN1MiOhpX1rMhIwimF0rSJBjqRcTokqY6ufnck/WIQ==", "81204565-e0b4-4df2-9f86-5f230c891f98" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EnrollmentDeadline",
                table: "Vacations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Vacation enrollment deadline",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "Vacation enrollment deadline");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "103367a3-ecd7-4a3a-bca1-78a9429c2cc9", "AQAAAAEAACcQAAAAEPGlFCGgLxR8BJDyNkPio76Ps8bh5BJAYFG7fu61Q0IwLFm4v7dY7xxIloCOs1wkWQ==", "52741ae8-5380-484c-84bf-edba8380ff61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e256afbc-4616-47ea-a5eb-5fcf5e634e38", "AQAAAAEAACcQAAAAEGldDuJYA8x9EJWsS0UuLpd+VNnUt30jxXx9b25q5S15JT9e2iIl513j5MD+jZ8FAg==", "0bab3610-8bf1-4948-9fe8-13d744005396" });
        }
    }
}
