using Kuari.ShopApplication.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.ShopApplication.Core.DTOs
{
    public class ProductBrandCreateDto
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
    }
}
