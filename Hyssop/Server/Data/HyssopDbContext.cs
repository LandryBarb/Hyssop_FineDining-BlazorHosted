using Hyssop.Server.Configurations.Entities;

namespace Hyssop.Server.Data
{
    public class HyssopDbContext : DbContext
    {
        public HyssopDbContext(DbContextOptions<HyssopDbContext> options) : base(options)
        {

        }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<MenuItemType> MenuItemTypes { get; set; }
        public DbSet<MealType> MealTypes { get; set; }
        public DbSet<MenuItemVariant> MenuItemVariants { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //composite key


            modelBuilder.ApplyConfiguration(new MenuItemSeedConfig());
            modelBuilder.ApplyConfiguration(new MenuItemTypeSeedConfig());
            modelBuilder.ApplyConfiguration(new MealTypeSeedConfig());
            modelBuilder.ApplyConfiguration(new MenuItemVariantSeedConfig());
        }
    }
}
