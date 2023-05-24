using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListingAPI.Migrations
{
    /// <inheritdoc />
    public partial class modelsupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Countries_CountryId",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_CountryId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Countries");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Countries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Countries",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CountryId", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CountryId", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CountryId", "Rating" },
                values: new object[] { null, 0.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CountryId",
                table: "Countries",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Countries_CountryId",
                table: "Countries",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }
    }
}
