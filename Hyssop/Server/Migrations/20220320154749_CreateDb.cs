using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hyssop.Server.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MealTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItemTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItemTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    Special = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItems_MealTypes_MealId",
                        column: x => x.MealId,
                        principalTable: "MealTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuItemVariants",
                columns: table => new
                {
                    MenuItemId = table.Column<int>(type: "int", nullable: false),
                    MenuItemTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NormalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItemVariants", x => new { x.MenuItemId, x.MenuItemTypeId });
                    table.ForeignKey(
                        name: "FK_MenuItemVariants_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuItemVariants_MenuItemTypes_MenuItemTypeId",
                        column: x => x.MenuItemTypeId,
                        principalTable: "MenuItemTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MealTypes",
                columns: new[] { "Id", "ImageUrl", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "../images/background/bg1.jpg", "Breakfast", "breakfast" },
                    { 2, "../images/background/bg1.jpg", "Lunch", "lunch" },
                    { 3, "../images/background/bg1.jpg", "Dinner", "dinner" }
                });

            migrationBuilder.InsertData(
                table: "MenuItemTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Beef" },
                    { 2, "Chicken" },
                    { 3, "Pork" },
                    { 4, "Beyond Meat" },
                    { 5, "Impossible Meat" },
                    { 6, "Tempeh" }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Description", "ImageUrl", "MealId", "Name", "Special" },
                values: new object[] { 1, "Doctrine—what Christians believe—directly influences how they live. The biblical truths about God, humanity, and the world are not merely about knowing more—they are also about loving God and making sense of this life and the life to come. But what happens when there is disparity between what believers confess and how they live? In his latest book Do You Believe ?  pastor and best - selling author Paul David Tripp takes a close look at 12 core doctrines and how they engage and transform the human heart and mind.According to Tripp, true belief is always lived. To demonstrate,  he unpacks each doctrine and presents its relevance for the Christian life.As readers explore topics such as the doctrine of God, the holiness of God, and the doctrine of Scripture, they will be fueled to fall deeper in love with and stand in awe of their Creator and Father—putting the truths of God’s word on display for all the world to see", "../images/products/burger1.jpg", 1, "Burger", true });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Description", "ImageUrl", "MealId", "Name", "Special" },
                values: new object[] { 2, "Doctrine—what Christians believe—directly influences how they live. The biblical truths about God, humanity, and the world are not merely about knowing more—they are also about loving God and making sense of this life and the life to come. But what happens when there is disparity between what believers confess and how they live? In his latest book Do You Believe ?  pastor and best - selling author Paul David Tripp takes a close look at 12 core doctrines and how they engage and transform the human heart and mind.According to Tripp, true belief is always lived. To demonstrate,  he unpacks each doctrine and presents its relevance for the Christian life.As readers explore topics such as the doctrine of God, the holiness of God, and the doctrine of Scripture, they will be fueled to fall deeper in love with and stand in awe of their Creator and Father—putting the truths of God’s word on display for all the world to see", "../images/products/burger2.jpg", 1, "taco", true });

            migrationBuilder.InsertData(
                table: "MenuItemVariants",
                columns: new[] { "MenuItemId", "MenuItemTypeId", "NormalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 1, 0m, 9.99m },
                    { 1, 2, 0m, 9.99m },
                    { 1, 4, 9.99m, 11.99m },
                    { 1, 5, 9.99m, 11.99m },
                    { 1, 6, 9.99m, 11.99m },
                    { 2, 1, 0m, 9.99m },
                    { 2, 2, 0m, 9.99m },
                    { 2, 4, 9.99m, 10.99m },
                    { 2, 5, 9.99m, 10.99m },
                    { 2, 6, 9.99m, 10.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_MealId",
                table: "MenuItems",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItemVariants_MenuItemTypeId",
                table: "MenuItemVariants",
                column: "MenuItemTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItemVariants");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "MenuItemTypes");

            migrationBuilder.DropTable(
                name: "MealTypes");
        }
    }
}
