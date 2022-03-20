using Microsoft.AspNetCore.Mvc;

namespace Hyssop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        private readonly IMenuItemService _menuItemService;
        public MenuItemController(IMenuItemService menuItemService)
        {
            _menuItemService = menuItemService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<MenuItem>>>> GetMenuItems()
        {
            var result = await _menuItemService.GetMenuItemsAsync();
            return Ok(result);
        }
        [HttpGet("{menuItemId}")]
        public async Task<ActionResult<ServiceResponse<MenuItem>>> GetMenuItem(int menuItemId)
        {
            var result = await _menuItemService.GetMenuItemAsync(menuItemId);
            return Ok(result);
        }

        [HttpGet("mealType/{mealTypeUrl}")]
        public async Task<ActionResult<ServiceResponse<MenuItem>>> GetMenuItemsByCategory(string mealTypeUrl)
        {
            var result = await _menuItemService.GetMenuItemsByMealType(mealTypeUrl);
            return Ok(result);
        }


        [HttpGet("search/{searchText}/{page}")]
        public async Task<ActionResult<ServiceResponse<MenuItemSearchResultDTO>>> SearchMenuItems(string searchText, int page = 1)
        {
            var result = await _menuItemService.SearchMenuItems(searchText, page);
            return Ok(result);
        }


        [HttpGet("searchsuggestions/{searchText}")]
        public async Task<ActionResult<ServiceResponse<MenuItem>>> GetMenuItemSearchSuggestions(string searchText)
        {
            var result = await _menuItemService.GetMenuItemSearchSuggestions(searchText);
            return Ok(result);
        }

        [HttpGet("special")]
        public async Task<ActionResult<ServiceResponse<List<MenuItem>>>> GetFeaturedMenuItems()
        {
            var result = await _menuItemService.GetSpecialMenuItems();
            return Ok(result);
        }
    }
}
