﻿namespace Frontec.Models
{
    /// <summary>
     /// DTO для отображения средней цены по товарной группе в магазине на клиенте.
     /// Используется в компоненте AveragePrice.razor.
     /// </summary> 
    public class AvgPriceStatDto
    {
        public int GroupCode { get; set; }
        public decimal AvgPrice { get; set; }
        public string StoreName { get; set; } // или получайте это с сервера
        public string GroupName { get; set; }
        public decimal AveragePrice { get; set; }
        // Вычисляемые свойства для отображения
        //public string StoreName => "Все магазины"; // или получайте это с сервера
        //public string GroupName => $"Группа {GroupCode}";
        //public decimal AveragePrice => AvgPrice;
    };

    //AvgPriceStatDto? stat; // Измените на одиночный объект вместо списка

    //protected override async Task OnInitializedAsync()
    //{
    //    try 
    //    {
    //        // Получаем одиночный объект вместо списка
    //        stat = await Http.GetFromJsonAsync<AvgPriceStatDto>("api/stats/avg-prices");
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine($"Ошибка: {ex.Message}");
    //    }
    //}
}