namespace Hyssop.Client.Services.MealTypeService
{
    public interface IMealTypeService
    {
        List<MealType> MealTypes { get; set; }
        Task GetAllMealTypes();
    }
}
