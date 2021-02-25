using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity.Migrations
{
    public partial class InitCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Country_AspNetUsers_AppUserId",
                table: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Country_AppUserId",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Country");

            migrationBuilder.AddColumn<string>(
                name: "CityName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountryName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db6749bc-e6a9-44d6-bdcb-2e2603e40540", "AQAAAAEAACcQAAAAEAaOI++AbaLtqVNnrnpxOH/dDRtHKUzhtLaoTfYm8GOjru0zp1ntz/h7b0E1qN1/UQ==", "08dacda5-f3bd-4a59-bab4-063383e72d39" });

            migrationBuilder.CreateIndex(
                name: "IX_City_CityId",
                table: "City",
                column: "CityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CityId",
                table: "AspNetUsers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CountryId",
                table: "AspNetUsers",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_City_CityId",
                table: "AspNetUsers",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Country_CountryId",
                table: "AspNetUsers",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_City_CityId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Country_CountryId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_City_CityId",
                table: "City");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CityId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CountryId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CityName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CountryName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Country",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c4fe6d4-1968-4cc6-914e-21b8334762e3", "AQAAAAEAACcQAAAAEF6JpAzFzM3keq+Zmw7GNkvRH+LBHM4KlYrC7caGq8pGCIh1TED7Z4FP3OeAQZP5hw==", "5a633ee3-e533-4efd-80e1-1aad83cbdbed" });

            migrationBuilder.CreateIndex(
                name: "IX_Country_AppUserId",
                table: "Country",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Country_AspNetUsers_AppUserId",
                table: "Country",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
