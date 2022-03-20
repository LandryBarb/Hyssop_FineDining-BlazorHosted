namespace Hyssop.Client.Services.MealTypeService
{
    public class MealTypeService : IMealTypeService
    {
        private readonly HttpClient _http;

        public MealTypeService(HttpClient http)
        {
            _http = http;
        }
        public List<MealType> MealTypes { get; set; } = new List<MealType>();

        public async Task GetAllMealTypes()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<MealType>>>("api/MealType");
            if (response != null && response.Data != null)
            {
                MealTypes = response.Data;
            }
        }
    }
}
