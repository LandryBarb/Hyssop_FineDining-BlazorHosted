using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hyssop.Server.Migrations
{
    public partial class MealTypeCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_MealTypes_MealId",
                table: "MenuItems");

            migrationBuilder.RenameColumn(
                name: "MealId",
                table: "MenuItems",
                newName: "MealTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItems_MealId",
                table: "MenuItems",
                newName: "IX_MenuItems_MealTypeId");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "MealTypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "MealTypeId",
                value: 3);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_MealTypes_MealTypeId",
                table: "MenuItems",
                column: "MealTypeId",
                principalTable: "MealTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_MealTypes_MealTypeId",
                table: "MenuItems");

            migrationBuilder.RenameColumn(
                name: "MealTypeId",
                table: "MenuItems",
                newName: "MealId");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItems_MealTypeId",
                table: "MenuItems",
                newName: "IX_MenuItems_MealId");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "MealId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "MealId",
                value: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_MealTypes_MealId",
                table: "MenuItems",
                column: "MealId",
                principalTable: "MealTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
