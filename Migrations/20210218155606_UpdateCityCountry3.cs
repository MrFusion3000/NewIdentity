using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity.Migrations
{
    public partial class UpdateCityCountry3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryID",
                table: "City",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryID",
                table: "City",
                column: "CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Country_CountryID",
                table: "City",
                column: "CountryID",
                principalTable: "Country",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Country_CountryID",
                table: "City");

            migrationBuilder.DropIndex(
                name: "IX_City_CountryID",
                table: "City");

            migrationBuilder.DropColumn(
                name: "CountryID",
                table: "City");
        }
    }
}
