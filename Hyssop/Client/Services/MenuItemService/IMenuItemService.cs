namespace Hyssop.Client.Services.MenuItemService
{
    public interface IMenuItemService
    {
        //add event
        event Action MenuItemsChanged;
        List<MenuItem> MenuItems { get; set; }
        string Message { get; set; }
        int CurrentPage { get; set; }
        int PageCount { get; set; }
        string LastSearchText { get; set; }

        Task GetMenuItems(string? mealTypeUrl = null);
        Task<ServiceResponse<MenuItem>> GetMenuItem(int menuItemId);
        Task SearchMenuItems(string searchText, int page);
        Task<List<string>> GetMenuItemSearchSuggestions(string searchText);
    }
}
