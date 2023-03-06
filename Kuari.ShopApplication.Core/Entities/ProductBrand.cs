using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.ShopApplication.Core.Entities
{
    public class ProductBrand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }

    }
}
