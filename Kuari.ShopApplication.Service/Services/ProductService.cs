using Kuari.ShopApplication.Core.DTOs;
using Kuari.ShopApplication.Core.Entities;
using Kuari.ShopApplication.Core.Repositories;
using Kuari.ShopApplication.Core.Services;
using Kuari.ShopApplication.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.ShopApplication.Service.Services
{
    public class ProductService : Service<Product,ProductListDto,ProductCreateDto,ProductUpdateDto>,IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
   
        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork) : base(productRepository,unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }



        // filter repository operations and service operations
    }
}
