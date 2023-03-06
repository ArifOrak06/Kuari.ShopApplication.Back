using Kuari.ShopApplication.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Kuari.ShopApplication.Repository.Contexts
{
    public class ShopApplicationContext : DbContext
    {
        public ShopApplicationContext(DbContextOptions<ShopApplicationContext> options) : base(options)
        {

        }
        public DbSet<Product> Productss { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
