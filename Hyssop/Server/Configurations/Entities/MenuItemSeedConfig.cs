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
                    Name = "Beyond Burger",
                    Description = "Doctrine—what Christians believe—directly influences how they live. The biblical truths about God, humanity, and the world are not merely about knowing more—they are also about loving God and making sense of this life and the life to come. But what happens when there is disparity between ther—putting the truths of God’s word on display for all the world to see",
                    ImageUrl = "../images/products/burger1.jpg",
                    Special = true,
                    MealTypeId = 3,



                },


                  new MenuItem
                  {
                      Id = 2,
                      Name = "Street Tacos",
                      Description = "Doctrine—what Christians believe—directly influences how they live. The biblical truths about God, humanity, and the world are not merely about knowing more—they are also about loving God and making sense of this life and the life to come. But what happens when there is disparity between what believers confess and how they live? In his latest book Do You Believe tor and Father—putting the truths of God’s word on display for all the world to see",
                      ImageUrl = "../images/products/burger2.jpg",
                      Special = true,
                      MealTypeId = 3,

                  }
                );
        }
    }
}
