using Kuari.ShopApplication.Core.Entities;
using Kuari.ShopApplication.Core.Repositories;
using Kuari.ShopApplication.Repository.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Kuari.ShopApplication.Repository.Repositories
{

    public class ProductRepository :  Repository<Product>, IProductRepository
    {
        protected readonly ShopApplicationContext _context;

        public ProductRepository(ShopApplicationContext context) : base(context)
        {
            _context = context;
        }


   
    }
}
