

namespace Hyssop.Server.Services.MenuItemService
{
    public interface IMenuItemService
    {
        Task<ServiceResponse<List<MenuItem>>> GetMenuItemsAsync();
        Task<ServiceResponse<MenuItem>> GetMenuItemAsync(int menuItemId);
        Task<ServiceResponse<List<MenuItem>>> GetMenuItemsByMealType(string mealTypeUrl);

        Task<ServiceResponse<MenuItemSearchResultDTO>> SearchMenuItems(string searchText, int page);

        Task<ServiceResponse<List<string>>> GetMenuItemSearchSuggestions(string searchText);
        Task<ServiceResponse<List<MenuItem>>> GetSpecialMenuItems();
    }
}
