namespace Frontec.Models
{
    /// <summary>
    /// DTO для отображения товаров в магазине на клиенте.
    /// Используется в компоненте ProductsInStore.razor.
    /// </summary>
    public class ProductDto
    {
        public int Id { get; set; }
        public string Barcode { get; set; } = "";
        public string Name { get; set; } = "";
        public int GroupCode { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int StoreId { get; set; }
    }
}
