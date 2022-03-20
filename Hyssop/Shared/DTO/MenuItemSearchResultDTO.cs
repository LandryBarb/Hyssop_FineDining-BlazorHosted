using Hyssop.Shared.Menu;

namespace Hyssop.Shared.DTO
{
    public class MenuItemSearchResultDTO
    {
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
    }
}
