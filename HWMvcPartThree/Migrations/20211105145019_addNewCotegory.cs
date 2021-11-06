using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HWMvcPartThree.Migrations
{
    public partial class addNewCotegory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "PhoneCompanies");

            migrationBuilder.CreateTable(
                name: "foodCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foodCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameP = table.Column<string>(type: "TEXT", nullable: false),
                    Cost = table.Column<decimal>(type: "TEXT", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FoodCategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_foods_foodCategories_FoodCategoryId",
                        column: x => x.FoodCategoryId,
                        principalTable: "foodCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "foodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Meat (including poultry)" });

            migrationBuilder.InsertData(
                table: "foodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Fruit and vegetable" });

            migrationBuilder.InsertData(
                table: "foodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Starch, sugar, honey and confectionery" });

            migrationBuilder.InsertData(
                table: "foodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Fish and fish products" });

            migrationBuilder.CreateIndex(
                name: "IX_foods_FoodCategoryId",
                table: "foods",
                column: "FoodCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "foods");

            migrationBuilder.DropTable(
                name: "foodCategories");

            migrationBuilder.CreateTable(
                name: "PhoneCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cost = table.Column<decimal>(type: "TEXT", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneCompanyId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phones_PhoneCompanies_PhoneCompanyId",
                        column: x => x.PhoneCompanyId,
                        principalTable: "PhoneCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PhoneCompanies",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Meat (including poultry)" });

            migrationBuilder.InsertData(
                table: "PhoneCompanies",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Fruit and vegetable" });

            migrationBuilder.InsertData(
                table: "PhoneCompanies",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Starch, sugar, honey and confectionery" });

            migrationBuilder.InsertData(
                table: "PhoneCompanies",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Fish and fish products" });

            migrationBuilder.CreateIndex(
                name: "IX_Phones_PhoneCompanyId",
                table: "Phones",
                column: "PhoneCompanyId");
        }
    }
}
