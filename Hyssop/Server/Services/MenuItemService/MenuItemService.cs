

namespace Hyssop.Server.Services.MenuItemService
{
    public class MenuItemService : IMenuItemService
    {
        private readonly HyssopDbContext _db;
        public MenuItemService(HyssopDbContext db)
        {
            _db = db;
        }
        //get ALL Menu Items
        public async Task<ServiceResponse<List<MenuItem>>> GetMenuItemsAsync()
        {
            var response = new ServiceResponse<List<MenuItem>>()
            {
                Data = await _db.MenuItems.Include(p => p.MenuItemVariants).ToListAsync()
            };

            return response;
        }

        //Get Single Menu Item
        public async Task<ServiceResponse<MenuItem>> GetMenuItemAsync(int menuItemId)
        {
            var response = new ServiceResponse<MenuItem>();
            var menuItem = await _db.MenuItems.Include(m => m.MenuItemVariants).ThenInclude(t => t.MenuItemType).FirstOrDefaultAsync(m => m.Id == menuItemId);
            if (menuItem == null)
            {
                response.Success = false;
                response.Message = "Sorry this item does not exists";
            }
            else
            {
                response.Data = menuItem;

            }
            return response;
        }

        public async Task<ServiceResponse<List<MenuItem>>> GetMenuItemByMealType(string mealTypeUrl)
        {
            var response = new ServiceResponse<List<MenuItem>>
            {
                Data = await _db.MenuItems
     .Where(m => m.Meal.Url.ToLower().Equals(mealTypeUrl.ToLower()))
     .Include(m => m.MenuItemVariants)
     .ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<List<string>>> GetMenuItemSearchSuggestions(string searchText)
        {
            var menuItems = await FindMenuItemsBySearchText(searchText);

            List<string> result = new List<string>();

            foreach (var menuItem in menuItems)
            {
                if (menuItem.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase))

                {
                    result.Add(menuItem.Name);
                }

                if (menuItem.Description != null)
                {
                    var punctuation = menuItem.Description.Where(char.IsPunctuation)
                        .Distinct().ToArray();
                    var words = menuItem.Description.Split()
                        .Select(s => s.Trim(punctuation));

                    foreach (var word in words)
                        if (word.Contains(searchText, StringComparison.OrdinalIgnoreCase)
                            && !result.Contains(word))
                        {
                            result.Add(word);
                        }
                }
            }

            return new ServiceResponse<List<string>> { Data = result };
        }

        public async Task<ServiceResponse<List<MenuItem>>> GetSpecialMenuItems()
        {
            var response = new ServiceResponse<List<MenuItem>>
            {
                Data = await _db.MenuItems
    .Where(p => p.Special)
    .Include(p => p.MenuItemVariants)
    .ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<MenuItemSearchResultDTO>> SearchProducts(string searchText, int page)
        {
            var pageResults = 2f;
            var pageCount = Math.Ceiling((await FindMenuItemsBySearchText(searchText)).Count / pageResults);
            var menuItems = await _db.MenuItems
                            .Where(m => m.Name.ToLower().Contains(searchText.ToLower())
                            || m.Description.ToLower().Contains(searchText.ToLower()))
                            .Include(m => m.MenuItemVariants)
                            .Skip((page - 1) * (int)pageResults)
                            .Take((int)pageResults)
                            .ToListAsync();

            var response = new ServiceResponse<MenuItemSearchResultDTO>
            {
                Data = new MenuItemSearchResultDTO
                {
                    MenuItems = menuItems,
                    CurrentPage = page,
                    Pages = (int)pageCount
                }
            };

            return response;
        }

        private async Task<List<MenuItem>> FindMenuItemsBySearchText(string searchText)
        {
            return await _db.MenuItems
                            .Where(m => m.Name.ToLower().Contains(searchText.ToLower())
                            || m.Description.ToLower().Contains(searchText.ToLower()))
                            .Include(p => p.MenuItemVariants).ToListAsync();
        }
    }
}
