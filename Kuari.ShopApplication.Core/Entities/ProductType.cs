namespace Kuari.ShopApplication.Core.Entities
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
