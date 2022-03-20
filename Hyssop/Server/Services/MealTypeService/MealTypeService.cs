namespace Hyssop.Server.Services.MealTypeService
{
    public class MealTypeService : IMealTypeService
    {
        private readonly HyssopDbContext _db;
        public MealTypeService(HyssopDbContext db)
        {
            _db = db;
        }
        public async Task<ServiceResponse<List<MealType>>> GetAllMealTypes()
        {
            var mealTypes = await _db.MealTypes.ToListAsync();
            return new ServiceResponse<List<MealType>>
            {
                Data = mealTypes,
            };
        }


    }
}
