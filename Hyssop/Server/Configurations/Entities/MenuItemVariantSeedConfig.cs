using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hyssop.Server.Configurations.Entities
{
    public class MenuItemVariantSeedConfig : IEntityTypeConfiguration<MenuItemVariant>
    {
        public void Configure(EntityTypeBuilder<MenuItemVariant> builder)
        {
            builder.HasKey(m => new { m.MenuItemId, m.MenuItemTypeId });

            builder.HasData(
                //burger
                new MenuItemVariant
                {
                    MenuItemId = 1,
                    MenuItemTypeId = 1,
                    Price = 9.99m
                },
                  new MenuItemVariant
                  {
                      MenuItemId = 1,
                      MenuItemTypeId = 2,
                      Price = 9.99m
                  },
                    new MenuItemVariant
                    {
                        MenuItemId = 1,
                        MenuItemTypeId = 4,
                        Price = 11.99m,
                        NormalPrice = 9.99m
                    },
                     new MenuItemVariant
                     {
                         MenuItemId = 1,
                         MenuItemTypeId = 5,
                         Price = 11.99m,
                         NormalPrice = 9.99m
                     },
                      new MenuItemVariant
                      {
                          MenuItemId = 1,
                          MenuItemTypeId = 6,
                          Price = 11.99m,
                          NormalPrice = 9.99m
                      },
                        //tacos
                        new MenuItemVariant
                        {
                            MenuItemId = 2,
                            MenuItemTypeId = 1,
                            Price = 9.99m
                        },

                        new MenuItemVariant
                        {
                            MenuItemId = 2,
                            MenuItemTypeId = 2,
                            Price = 9.99m
                        },
                          new MenuItemVariant
                          {
                              MenuItemId = 2,
                              MenuItemTypeId = 4,
                              Price = 10.99m,
                              NormalPrice = 9.99m
                          },
                           new MenuItemVariant
                           {
                               MenuItemId = 2,
                               MenuItemTypeId = 5,
                               Price = 10.99m,
                               NormalPrice = 9.99m
                           },
                            new MenuItemVariant
                            {
                                MenuItemId = 2,
                                MenuItemTypeId = 6,
                                Price = 10.99m,
                                NormalPrice = 9.99m
                            }

                );
        }
    }
}
