namespace Frontec.Models
{
    /// <summary>
    /// DTO для отображения магазинов на клиенте.
    /// Используется в компонентах для отображения магазинов
    /// </summary>
    public class StoreDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
    }
}
