namespace Frontec.Models
{
     /// <summary>
    /// DTO для отображения максимума продаж на клиенте.
    /// Используется в компоненте TopSales.razor.
    /// </summary>
    public class TopSaleDto
    {
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
