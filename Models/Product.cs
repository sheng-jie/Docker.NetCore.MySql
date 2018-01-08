namespace Docker.NetCore.MySql.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQty { get; set; }
    }
}
