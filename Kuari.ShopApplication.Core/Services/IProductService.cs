using Kuari.ShopApplication.Core.DTOs;
using Kuari.ShopApplication.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.ShopApplication.Core.Services
{
    public interface IProductService : IService<Product, ProductListDto,ProductCreateDto,ProductUpdateDto>
    {
        // tarihe göre sıralama,
        // kategorisi ile birlikte ürünleri listeleme
        // azalan ve artan sıralama
    }
}
