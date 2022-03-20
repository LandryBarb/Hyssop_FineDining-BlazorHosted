using Hyssop.Shared.Menu;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hyssop.Server.Configurations.Entities
{
    public class MenuItemSeedConfig : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            builder.HasData(

                new MenuItem
                {
                    Id = 1,
                    Name = "Burger",
                    Description = "Doctrine—what Christians believe—directly influences how they live. The biblical truths about God, humanity, and the world are not merely about knowing more—they are also about loving God and making sense of this life and the life to come. But what happens when there is disparity between what believers confess and how they live? In his latest book Do You Believe ?  pastor and best - selling author Paul David Tripp takes a close look at 12 core doctrines and how they engage and transform the human heart and mind.According to Tripp, true belief is always lived. To demonstrate,  he unpacks each doctrine and presents its relevance for the Christian life.As readers explore topics such as the doctrine of God, the holiness of God, and the doctrine of Scripture, they will be fueled to fall deeper in love with and stand in awe of their Creator and Father—putting the truths of God’s word on display for all the world to see",
                    ImageUrl = "../images/products/burger1.jpg",
                    Special = true,
                    MealId = 1,
                },


                  new MenuItem
                  {
                      Id = 2,
                      Name = "taco",
                      Description = "Doctrine—what Christians believe—directly influences how they live. The biblical truths about God, humanity, and the world are not merely about knowing more—they are also about loving God and making sense of this life and the life to come. But what happens when there is disparity between what believers confess and how they live? In his latest book Do You Believe ?  pastor and best - selling author Paul David Tripp takes a close look at 12 core doctrines and how they engage and transform the human heart and mind.According to Tripp, true belief is always lived. To demonstrate,  he unpacks each doctrine and presents its relevance for the Christian life.As readers explore topics such as the doctrine of God, the holiness of God, and the doctrine of Scripture, they will be fueled to fall deeper in love with and stand in awe of their Creator and Father—putting the truths of God’s word on display for all the world to see",
                      ImageUrl = "../images/products/burger2.jpg",
                      Special = true,
                      MealId = 1,
                  }
                );
        }
    }
}
