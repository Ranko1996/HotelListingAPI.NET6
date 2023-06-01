using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListingAPI.Migrations
{
    /// <inheritdoc />
    public partial class roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49894c6e-bf68-43d5-9cd0-586ea7648056");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4313184-2819-4edc-8a6d-3e5228b9c87b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37717e5f-4eb0-43a6-b993-bc3036747c55", "d746692e-af32-41b6-9030-4fa09b148f70", "User", "USER" },
                    { "7c3ddf09-949a-4743-9e89-038f58a607f9", "fd525195-44cb-4909-8f83-df1905c5e637", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37717e5f-4eb0-43a6-b993-bc3036747c55");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c3ddf09-949a-4743-9e89-038f58a607f9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "49894c6e-bf68-43d5-9cd0-586ea7648056", "2b38e32f-be9c-43d1-9b10-bb7d9efef8a1", "User", "USER" },
                    { "e4313184-2819-4edc-8a6d-3e5228b9c87b", "8363b5b0-c9ab-41c2-9a39-4b5d4f891d3f", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
