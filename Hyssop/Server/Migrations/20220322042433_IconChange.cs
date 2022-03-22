using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hyssop.Server.Migrations
{
    public partial class IconChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Icon",
                value: "../images/icons/toast.png");

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Icon",
                value: "../images/icons/sandwich.png");

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Icon",
                value: "../images/icons/steak.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Icon",
                value: "fa-solid fa-pancakes");

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Icon",
                value: "fa-solid fa-burger-fries");

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Icon",
                value: "fa-solid fa-plate-utensils");
        }
    }
}
