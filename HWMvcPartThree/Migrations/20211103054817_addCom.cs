using Microsoft.EntityFrameworkCore.Migrations;

namespace HWMvcPartThree.Migrations
{
    public partial class addCom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PhoneCompanies",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Samsung" });

            migrationBuilder.InsertData(
                table: "PhoneCompanies",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Xiaomi" });

            migrationBuilder.InsertData(
                table: "PhoneCompanies",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Apple" });

            migrationBuilder.InsertData(
                table: "PhoneCompanies",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Huawei" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PhoneCompanies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PhoneCompanies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PhoneCompanies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PhoneCompanies",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
