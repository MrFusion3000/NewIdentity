using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity.Migrations
{
    public partial class UpdateDbCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryCity");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae79b532-bded-44fb-8b3d-8eb63a08c0b6", "nico@crepro.com", "nico", "AQAAAAEAACcQAAAAENolB2NnznxFJkNmVdzrbpyEUweZ8zyPZCzO132wQKDpOw29WTwfwteMziingmcjuw==", "0c0b0749-51e5-44fc-8a1f-f1e12db0a74f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountryCity",
                columns: table => new
                {
                    CountryCityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryCity", x => x.CountryCityID);
                    table.ForeignKey(
                        name: "FK_CountryCity_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryCity_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47667460-0244-4745-8841-be18ce3a55a1", null, null, "AQAAAAEAACcQAAAAECmjLxvwsIAmBIhyk7GHe6i8HXN/z6KVZlp7UdgEpieIXkrKoaBgJ3PK8BLRlbnYkg==", "f8a940d6-6b3f-42b3-9cdc-7d9e5cb91974" });

            migrationBuilder.CreateIndex(
                name: "IX_CountryCity_CityId",
                table: "CountryCity",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryCity_CountryId",
                table: "CountryCity",
                column: "CountryId");
        }
    }
}
