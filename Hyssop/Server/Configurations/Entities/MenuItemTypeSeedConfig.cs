using Hyssop.Shared.Menu;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hyssop.Server.Configurations.Entities
{
    public class MenuItemTypeSeedConfig : IEntityTypeConfiguration<MenuItemType>
    {
        public void Configure(EntityTypeBuilder<MenuItemType> builder)
        {
            builder.HasData(

                new MenuItemType
                {
                    Id = 1,
                    Name = "Beef"
                },
                  new MenuItemType
                  {
                      Id = 2,
                      Name = "Chicken"
                  },
                    new MenuItemType
                    {
                        Id = 3,
                        Name = "Pork"
                    },
                      new MenuItemType
                      {
                          Id = 4,
                          Name = "Beyond Meat"
                      },
                      new MenuItemType
                      {
                          Id = 5,
                          Name = "Impossible Meat"
                      },
                      new MenuItemType
                      {
                          Id = 6,
                          Name = "Tempeh"
                      }


                );
        }
    }
}
