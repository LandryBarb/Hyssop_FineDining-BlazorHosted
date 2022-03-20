namespace Hyssop.Server.Services.MealTypeService
{
    public interface IMealTypeService
    {
        Task<ServiceResponse<List<MealType>>> GetAllMealTypes();
    }
}
