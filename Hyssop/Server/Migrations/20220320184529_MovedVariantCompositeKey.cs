using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hyssop.Server.Migrations
{
    public partial class MovedVariantCompositeKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Doctrine—what Christians believe—directly influences how they live. The biblical truths about God, humanity, and the world are not merely about knowing more—they are also about loving God and making sense of this life and the life to come. But what happens when there is disparity between ther—putting the truths of God’s word on display for all the world to see");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Doctrine—what Christians believe—directly influences how they live. The biblical truths about God, humanity, and the world are not merely about knowing more—they are also about loving God and making sense of this life and the life to come. But what happens when there is disparity between what believers confess and how they live? In his latest book Do You Believe ?  pastor and best - selling author Paul David Tripp takes a close look at 12 core doctrines and how they engage and transform the human heart and mind.According to Tripp, true belief is always lived. To demonstrate,  he unpacks each doctrine and presents its relevance for the Christian life.As readers explore topics such as the doctrine of God, the holiness of God, and the doctrine of Scripture, they will be fueled to fall deeper in love with and stand in awe of their Creator and Father—putting the truths of God’s word on display for all the world to see");
        }
    }
}
