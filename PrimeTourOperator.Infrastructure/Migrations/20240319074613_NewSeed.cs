using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeTourOperator.Infrastructure.Migrations
{
    public partial class NewSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "577e6ee4-30af-400b-938f-3b2aa96cb877", "AQAAAAEAACcQAAAAEFOXDNmyLRfcfkuwTcB4QdzDESU7V7y3kj3aXNqW9qnGWemkCP4TopKaziRiVIkeoQ==", "d67d6b87-ed45-4d90-b85c-f194979666da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7f2f778-425d-42cd-9b8d-152dcf934731", "AQAAAAEAACcQAAAAEJ+fE3shc7k7qtQO5OtTqdeNc6odAH1AjTkYJ9elFd/zxqSlxJhlx88BRgx+/mKQag==", "ed9a16d9-d196-4380-8f43-1b4b4d57a013" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "BSea Two person room");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "BSea Studio room");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "BanskoPresiden apartmen");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Bansko Two bed room");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "Bansko Studio");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Title",
                value: "Bansko President apartment");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Title",
                value: "PBello Two bed room");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "Title",
                value: "PBello Studio");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "Title",
                value: "PBello President apartment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91bfb231-0ed3-44b4-b6d7-3333fe01ebde", "AQAAAAEAACcQAAAAEKRwDnImIu9MFEVmF3kyBFL+EvVNoK9AD3pFBTLQo0Pno9VCAMNbaTf5QBVIS+lpNg==", "5398413f-cef5-4762-a145-ffc6350a3f48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a5fac05-0085-4529-a16e-04fa0e6092b0", "AQAAAAEAACcQAAAAEBrGLiosOXnE0Q4ujDm7u1muTSjNj4NPM0NSkpd2CCL0qVZAvurtMYwXDbM4b9Sd3w==", "83e99140-a5d9-43d7-80c7-76374b408261" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Two person room");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Studio room");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "Presiden apartmen");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Two bed room");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "Studio");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Title",
                value: "President apartment");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Title",
                value: "Two bed room");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "Title",
                value: "Studio");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "Title",
                value: "President apartment");
        }
    }
}
