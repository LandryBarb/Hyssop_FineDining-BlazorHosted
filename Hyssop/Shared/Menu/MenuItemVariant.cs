using System.ComponentModel.DataAnnotations.Schema;

namespace Hyssop.Shared.Menu
{
    public class MenuItemVariant
    {
        public MenuItem? MenuItem { get; set; }
        public int MenuItemId { get; set; }
        public MenuItemType? MenuItemType { get; set; }
        public int MenuItemTypeId { get; set; }
        [Column(TypeName = "decimal(18,2)")]

        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]

        public decimal NormalPrice { get; set; }
    }
}
