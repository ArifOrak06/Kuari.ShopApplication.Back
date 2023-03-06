using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.ShopApplication.Core.DTOs
{
    public class ProductTypeListDto 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public ProductListDto ProductListDto { get; set; }
    }
}
