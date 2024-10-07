using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PruebaNet.Migrations
{
    /// <inheritdoc />
    public partial class finishSeeder1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "room_types",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "a cozy basic room with a single bed, ideal for solo travelers.", "single room" },
                    { 2, "offers flexibility with either two single beds or a double bed, perfect for couples or friends.", "double room" },
                    { 3, "spacious and luxurious, with a king-size bed and a separate living area, ideal for those seeking comfort and exclusivity.", "suite" },
                    { 4, "designed for families, with extra space and multiple beds for a comfortable stay.", "family room" }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "id", "availability", "max_occuppancy_person", "price_per_night", "room_number", "RoomTypeId" },
                values: new object[,]
                {
                    { 1, true, 1, 50.0, "101", 2 },
                    { 2, false, 2, 150.0, "102", 4 },
                    { 3, true, 2, 80.0, "103", 1 },
                    { 4, true, 4, 200.0, "104", 3 },
                    { 5, false, 1, 50.0, "105", 2 },
                    { 6, true, 2, 150.0, "106", 3 },
                    { 7, false, 2, 80.0, "107", 4 },
                    { 8, true, 4, 200.0, "108", 1 },
                    { 9, true, 1, 50.0, "109", 3 },
                    { 10, false, 2, 150.0, "110", 2 },
                    { 11, true, 4, 200.0, "201", 1 },
                    { 12, false, 2, 80.0, "202", 4 },
                    { 13, true, 1, 50.0, "203", 3 },
                    { 14, true, 2, 150.0, "204", 2 },
                    { 15, false, 4, 200.0, "205", 1 },
                    { 16, true, 2, 80.0, "206", 3 },
                    { 17, true, 1, 50.0, "207", 4 },
                    { 18, false, 2, 150.0, "208", 2 },
                    { 19, true, 4, 200.0, "209", 3 },
                    { 20, true, 2, 80.0, "210", 1 },
                    { 21, false, 1, 50.0, "301", 4 },
                    { 22, true, 2, 150.0, "302", 1 },
                    { 23, true, 2, 80.0, "303", 2 },
                    { 24, true, 4, 200.0, "304", 3 },
                    { 25, false, 1, 50.0, "305", 1 },
                    { 26, true, 2, 150.0, "306", 4 },
                    { 27, false, 2, 80.0, "307", 3 },
                    { 28, true, 4, 200.0, "308", 2 },
                    { 29, true, 1, 50.0, "309", 3 },
                    { 30, true, 2, 150.0, "310", 1 },
                    { 31, false, 2, 80.0, "401", 4 },
                    { 32, true, 4, 200.0, "402", 2 },
                    { 33, true, 1, 50.0, "403", 3 },
                    { 34, true, 2, 150.0, "404", 1 },
                    { 35, true, 2, 80.0, "405", 3 },
                    { 36, false, 4, 200.0, "406", 4 },
                    { 37, true, 1, 50.0, "407", 2 },
                    { 38, true, 2, 150.0, "408", 1 },
                    { 39, true, 2, 80.0, "409", 4 },
                    { 40, true, 4, 200.0, "410", 3 },
                    { 41, true, 1, 50.0, "501", 4 },
                    { 42, true, 2, 150.0, "502", 3 },
                    { 43, false, 2, 80.0, "503", 2 },
                    { 44, true, 4, 200.0, "504", 1 },
                    { 45, true, 1, 50.0, "505", 3 },
                    { 46, true, 2, 150.0, "506", 4 },
                    { 47, false, 2, 80.0, "507", 1 },
                    { 48, true, 4, 200.0, "508", 2 },
                    { 49, true, 1, 50.0, "509", 4 },
                    { 50, true, 2, 150.0, "510", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
