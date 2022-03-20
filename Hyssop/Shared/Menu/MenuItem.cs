namespace Hyssop.Shared.Menu
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public MealType? Meal { get; set; }
        public int MealId { get; set; }
        public bool Special { get; set; } = false;
        public List<MenuItemVariant> MenuItemVariants { get; set; } = new List<MenuItemVariant>();
    }
}
