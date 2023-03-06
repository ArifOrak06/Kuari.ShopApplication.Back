using Kuari.ShopApplication.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kuari.ShopApplication.Repository.Seeds
{
    public class ProductSeedData : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product[]
            {
                new(){Id=1,Name="Ürün1",Price=120,Description="yeni ürün",PictureUrl="1.jpeg"},
                new(){Id=2,Name="Ürün2",Price=150,Description="yeni ürün",PictureUrl="2.jpeg"},
                new(){Id=3,Name="Ürün3",Price=160,Description="yeni ürün",PictureUrl="3.jpeg"}
            });
        }
    }
}
