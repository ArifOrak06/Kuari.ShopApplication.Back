using Kuari.ShopApplication.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.ShopApplication.Repository.Seeds
{
    public class ProductBrandSeedData : IEntityTypeConfiguration<ProductBrand>
    {
        public void Configure(EntityTypeBuilder<ProductBrand> builder)
        {
            builder.HasData(new ProductBrand[]
            {
                new(){Id=1,Name="Marka1",ProductId=1},
                new(){Id=2,Name="Marka2",ProductId=2},
                new(){Id=3,Name="Marka3",ProductId=3}

            });
        }
    }
}
