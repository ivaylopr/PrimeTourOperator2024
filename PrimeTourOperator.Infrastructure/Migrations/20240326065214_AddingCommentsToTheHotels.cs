using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeTourOperator.Infrastructure.Migrations
{
    public partial class AddingCommentsToTheHotels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Agents",
                type: "float",
                nullable: true,
                comment: "Rating of the agent");

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Comment identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Review = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, comment: "Review for the hotel"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User who give the review"),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id");
                },
                comment: "Class for comments and reviews by the users");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40c5bdd0-79f3-4f3b-aff8-a5f7601439c8", "AQAAAAEAACcQAAAAEFpl6xYz2scmBldowsPAftz8FworIvMvC3jVyana43ML/ZGczTqAPXsmbUuVoN35ZQ==", "9b58603a-5814-417c-baef-bfc7dd484e56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "954a46ef-c3c1-4bb2-a133-aec873f38b2b", "AQAAAAEAACcQAAAAEEHDQBdwuJdYmMsq9upofjt62maALg7PHcMkVmyIb5Y+2E5QaXoiCzjparNDdVUMeQ==", "052aeec2-abad-42de-89e6-94c2a9f75ad6" });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_HotelId",
                table: "Comment",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserId",
                table: "Comment",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Agents");

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
        }
    }
}
