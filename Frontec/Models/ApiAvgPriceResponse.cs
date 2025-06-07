// Добавьте в Frontec.Models
public class ApiAvgPriceResponse
{
    public int groupCode { get; set; }
    public decimal avgPrice { get; set; }
};
protected override async Task OnInitializedAsync()
{
    try
    {
        var apiResponse = await Http.GetFromJsonAsync<List<ApiAvgPriceResponse>>("api/stats/avg-prices");
        
        stats = apiResponse?.Select(x => new AvgPriceStatDto
        {
            StoreName = "Основной магазин", // или получайте из API
            GroupName = $"Группа {x.groupCode}",
            AveragePrice = x.avgPrice
        }).ToList();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
}
