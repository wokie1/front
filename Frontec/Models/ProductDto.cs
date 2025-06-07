namespace Frontec.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Group { get; set; } = "";
        public decimal Price { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
