using Microsoft.EntityFrameworkCore.Migrations;

namespace HWMvcPartThree.Migrations
{
    public partial class addCotegory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PhoneCompanies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Meat (including poultry)");

            migrationBuilder.UpdateData(
                table: "PhoneCompanies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Fruit and vegetable");

            migrationBuilder.UpdateData(
                table: "PhoneCompanies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Starch, sugar, honey and confectionery");

            migrationBuilder.UpdateData(
                table: "PhoneCompanies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Fish and fish products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PhoneCompanies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Samsung");

            migrationBuilder.UpdateData(
                table: "PhoneCompanies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Xiaomi");

            migrationBuilder.UpdateData(
                table: "PhoneCompanies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Apple");

            migrationBuilder.UpdateData(
                table: "PhoneCompanies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Huawei");
        }
    }
}
