

namespace Hyssop.Client.Services.MenuItemService
{
    public class MenuItemService : IMenuItemService
    {
        private readonly HttpClient _http;

        public MenuItemService(HttpClient http)
        {
            _http = http;
        }
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        public string Message { get; set; } = "Loading MenuItems";
        public int CurrentPage { get; set; } = 1;
        public int PageCount { get; set; } = 0;
        public string LastSearchText { get; set; } = string.Empty;

        public event Action MenuItemsChanged;

        public async Task<ServiceResponse<MenuItem>> GetMenuItem(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<MenuItem>>($"api/menuItem/{productId}");
            return result;
        }

        public async Task GetMenuItems(string? mealTypeUrl = null)
        {
            var result = mealTypeUrl == null ?
                await _http.GetFromJsonAsync<ServiceResponse<List<MenuItem>>>("api/menuItem/specials") :
                await _http.GetFromJsonAsync<ServiceResponse<List<MenuItem>>>($"api/menuItem/mealType/{mealTypeUrl}");
            ;
            if (result != null && result.Data != null)
            {
                MenuItems = result.Data;
            }
            CurrentPage = 1;
            PageCount = 0;
            if (MenuItems.Count == 0)
            {
                Message = "No MenuItems Found.";
            }

            MenuItemsChanged.Invoke();

        }

        public async Task<List<string>> GetMenuItemSearchSuggestions(string searchText)
        {
            var result = await _http
                .GetFromJsonAsync<ServiceResponse<List<string>>>($"api/menuItem/searchsuggestions/{searchText}");
            return result.Data;
        }

        public async Task SearchMenuItems(string searchText, int page)
        {
            LastSearchText = searchText;
            var result = await _http
                .GetFromJsonAsync<ServiceResponse<MenuItemSearchResultDTO>>($"api/menuItem/search/{searchText}/{page}");
            if (result != null && result.Data != null)
            {
                MenuItems = result.Data.MenuItems;
                CurrentPage = result.Data.CurrentPage;
                PageCount = result.Data.Pages;
            }
            if (MenuItems.Count == 0)
            {
                Message = "No MenuItems Found.";
            }
            MenuItemsChanged?.Invoke();
        }
    }
}
