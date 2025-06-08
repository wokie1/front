namespace Frontec.Models
{
    /// <summary>
    /// DTO для отображения продаж товаров в магазине на клиенте.
    /// Используется в компоненте TopSales.razor.
    /// </summary>

    public class StoresSalesDto
    {
        public string Name { get; set; }
        public decimal TotalSale { get; set; }
    }
}
