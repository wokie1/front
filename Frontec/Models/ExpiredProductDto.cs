namespace Frontec.Models
{
    /// <summary>
    /// DTO для отображения просроченных товаров в магазине на клиенте.
    /// Используется в компоненте ExpiredProducts.razor.
    /// </summary>
    public class ExpiredProductDto
    {
        public string Name { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string StoreName { get; set; }
    }
}
