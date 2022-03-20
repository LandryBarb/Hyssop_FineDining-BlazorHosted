using Hyssop.Server.Services.MealTypeService;
using Microsoft.AspNetCore.Mvc;

namespace Hyssop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealTypeController : ControllerBase
    {
        private readonly IMealTypeService _mealTypeService;
        public MealTypeController(IMealTypeService mealTypeService)
        {
            _mealTypeService = mealTypeService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<MealType>>>> GetAllMealTypes()
        {
            var result = await _mealTypeService.GetAllMealTypes();
            return Ok(result);
        }
    }
}
