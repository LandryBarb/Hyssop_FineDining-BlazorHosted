using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hyssop.Server.Migrations
{
    public partial class AddedMealTypeIcons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "MealTypes",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "MealTypes");
        }
    }
}
