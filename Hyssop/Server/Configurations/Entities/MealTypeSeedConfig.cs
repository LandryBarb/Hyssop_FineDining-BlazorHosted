using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hyssop.Server.Configurations.Entities
{
    public class MealTypeSeedConfig : IEntityTypeConfiguration<MealType>
    {
        public void Configure(EntityTypeBuilder<MealType> builder)
        {
            builder.HasData(

                new MealType
                {
                    Id = 1,
                    Name = "Breakfast",
                    Url = "breakfast",
                    ImageUrl = "../images/background/bg1.jpg",
                    Icon = "../images/icons/toast.png"
                },
                 new MealType
                 {
                     Id = 2,
                     Name = "Lunch",
                     Url = "lunch",
                     ImageUrl = "../images/background/bg1.jpg",
                     Icon = "../images/icons/sandwich.png"
                 },
                  new MealType
                  {
                      Id = 3,
                      Name = "Dinner",
                      Url = "dinner",
                      ImageUrl = "../images/background/bg1.jpg",
                      Icon = "../images/icons/steak.png"
                  }


                );
        }
    }
}
