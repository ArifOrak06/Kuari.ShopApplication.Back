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
    public class ProductTypeSeedData : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.HasData(new ProductType[]
            {
                new(){Id=1,Name="Giyim",ProductId=1},
                new(){Id=2,Name="Teknoloji",ProductId=2},
                new(){Id=3,Name="Aksesuar",ProductId=3}
            });
        }
    }
}
