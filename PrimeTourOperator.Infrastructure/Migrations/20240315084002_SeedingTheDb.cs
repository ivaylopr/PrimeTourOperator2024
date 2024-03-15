using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeTourOperator.Infrastructure.Migrations
{
    public partial class SeedingTheDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "PhoneNumber", "UserId" },
                values: new object[] { 1, "+359888888888", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "103367a3-ecd7-4a3a-bca1-78a9429c2cc9", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEPGlFCGgLxR8BJDyNkPio76Ps8bh5BJAYFG7fu61Q0IwLFm4v7dY7xxIloCOs1wkWQ==", null, false, "52741ae8-5380-484c-84bf-edba8380ff61", false, "guest@mail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "e256afbc-4616-47ea-a5eb-5fcf5e634e38", "agent@mail.com", false, false, null, "agent@mail.com", "agent@mail.com", "AQAAAAEAACcQAAAAEGldDuJYA8x9EJWsS0UuLpd+VNnUt30jxXx9b25q5S15JT9e2iIl513j5MD+jZ8FAg==", null, false, "0bab3610-8bf1-4948-9fe8-13d744005396", false, "agent@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "AllInclusivePrice", "Capacity", "CategoryStars", "ChildrenAnimators", "Location", "Name", "Pool", "Spa" },
                values: new object[,]
                {
                    { 1, 100m, 200, 3, true, "Sozopol, Bulgaria", "Black Sea Star", true, true },
                    { 2, 200m, 300, 4, true, "Bansko, Bulgaria", "Bansko Resort", true, true },
                    { 3, 150m, 400, 5, true, "Kos iceland, Greece", "Porto Bello", true, true }
                });

            migrationBuilder.InsertData(
                table: "RoomCategory",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Room appropriate for two person, included: bathroom, balcony, refrigerator, air conditioning, room service.", "Two bed room" },
                    { 2, "Room appropriate for family, included: bathroom, balcony, refrigerator, air conditioning, room service, two single beds, kitchen.", "Studio" },
                    { 3, "Room appropriate for people who loves the lux. All extras and services of the hotel is available.", "President apartment" }
                });

            migrationBuilder.InsertData(
                table: "VacationCategories",
                columns: new[] { "Id", "Description", "VacationType" },
                values: new object[,]
                {
                    { 1, "Holiday next to the sea.", "Sea holiday" },
                    { 2, "Holiday in the mountain", "Mountain holiday" },
                    { 3, "Vacation in SPA resort", "Spa holiday" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "AdditionalExtras", "Count", "HotelId", "Price", "RoomCategoryId", "Title" },
                values: new object[,]
                {
                    { 1, null, 10, null, 70.00m, 1, "Two person room" },
                    { 2, null, 5, null, 90.00m, 2, "Studio room" },
                    { 3, null, 1, null, 300.00m, 3, "President apartment" },
                    { 4, null, 30, null, 100.00m, 1, "Bansko Resort two bed room" },
                    { 5, null, 10, null, 150.00m, 2, "Bansko Resort studio" },
                    { 6, null, 2, null, 800.00m, 3, "Bansko Resort president apartment" },
                    { 7, null, 35, null, 120m, 1, "Porto Bello two bed room" },
                    { 8, null, 15, null, 180m, 2, "Porto bello studio" },
                    { 9, null, 1, null, 500.00m, 3, "Porto Bello president apartment" }
                });

            migrationBuilder.InsertData(
                table: "SeasonalEmployments",
                columns: new[] { "Id", "AgentId", "Description", "EndDate", "HotelId", "HourlyWage", "StartDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Person who help to the shefs and performs the given tasks", new DateTime(2024, 9, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 5.5m, new DateTime(2024, 3, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), "Kitchen helper" },
                    { 2, 1, "Cleaning rooms and common areas and preparing the hotel for the customers", new DateTime(2024, 9, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 5.5m, new DateTime(2024, 3, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), "House keeper" },
                    { 3, 1, "Delivering and service to the hotel customers' room", new DateTime(2024, 10, 16, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, 6.5m, new DateTime(2024, 3, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), "Room service" },
                    { 4, 1, "Working to the reception, assistance to the customers problems and questions", new DateTime(2025, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, 7.5m, new DateTime(2024, 10, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), "Receptionist" },
                    { 5, 1, "Welcoming and full assistance with customers' luggage", new DateTime(2024, 10, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, 3.5m, new DateTime(2024, 3, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), "Piccolo" },
                    { 6, 1, "Welcoming and parking the cusstomers cars on the hotel parking", new DateTime(2024, 4, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, 3.5m, new DateTime(2024, 10, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), "Parking assistance" },
                    { 7, 1, "Lifeguard on the hotel pool", new DateTime(2024, 10, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, 8.00m, new DateTime(2024, 3, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), "Lifeguard" },
                    { 8, 1, "Waiter at the hotel restorant", new DateTime(2024, 10, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 3.00m, new DateTime(2024, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), "Waiter" },
                    { 9, 1, "Bartendering and enterteiment", new DateTime(2024, 10, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, 6.00m, new DateTime(2024, 2, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), "Barman" },
                    { 10, 1, "Washing the dishes in the kitchen", new DateTime(2024, 10, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 4.50m, new DateTime(2024, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), "Dishwasher" }
                });

            migrationBuilder.InsertData(
                table: "Vacations",
                columns: new[] { "Id", "AgentId", "AllInclusive", "Description", "EndDate", "EnrollmentDeadline", "HotelId", "Location", "Price", "RoomId", "StartDate", "Title", "VacationCategoryId" },
                values: new object[] { 1, 1, true, "Ten days all inclusive holiday next to Black sea in one of the oldest towns in Europe.Two bed room plus", new DateTime(2024, 6, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "Sozopol, Bulgaria", 800.00m, 1, new DateTime(2024, 6, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), "Black Sea Star Sozopol-AllInclusive offer", 1 });

            migrationBuilder.InsertData(
                table: "Vacations",
                columns: new[] { "Id", "AgentId", "AllInclusive", "Description", "EndDate", "EnrollmentDeadline", "HotelId", "Location", "Price", "RoomId", "StartDate", "Title", "VacationCategoryId" },
                values: new object[] { 2, 1, true, "Ten days all inclusive holiday next to Black sea in one of the oldest towns in Europe.Studio room plus", new DateTime(2024, 6, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), 2, "Sozopol, Bulgaria", 2000.00m, 2, new DateTime(2024, 6, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), "Bansko Resort-AllInclusive offer", 1 });

            migrationBuilder.InsertData(
                table: "Vacations",
                columns: new[] { "Id", "AgentId", "AllInclusive", "Description", "EndDate", "EnrollmentDeadline", "HotelId", "Location", "Price", "RoomId", "StartDate", "Title", "VacationCategoryId" },
                values: new object[] { 3, 1, true, "Ten days all inclusive holiday next to Agean sea in born place of Hipocrates.Studio room plus", new DateTime(2024, 7, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, "Sozopol, Bulgaria", 2000.00m, 3, new DateTime(2024, 7, 6, 10, 0, 0, 0, DateTimeKind.Unspecified), "Bansko Resort-AllInclusive offer", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SeasonalEmployments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SeasonalEmployments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SeasonalEmployments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SeasonalEmployments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SeasonalEmployments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SeasonalEmployments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SeasonalEmployments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SeasonalEmployments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SeasonalEmployments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SeasonalEmployments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VacationCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VacationCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vacations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vacations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vacations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VacationCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomCategory",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
