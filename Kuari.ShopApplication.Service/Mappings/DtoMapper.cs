using AutoMapper;
using Kuari.ShopApplication.Core.DTOs;
using Kuari.ShopApplication.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.ShopApplication.Service.Mappings
{
    public class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductCreateDto, Product>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>().ReverseMap();
            CreateMap<ProductListDto, Product>().ReverseMap();
            CreateMap<ProductTypeCreateDto, ProductType>().ReverseMap();
            CreateMap<ProductTypeUpdateDto, ProductType>().ReverseMap();
            CreateMap<ProductTypeListDto, ProductType>().ReverseMap();
            CreateMap<ProductBrandCreateDto, ProductBrand>().ReverseMap();
            CreateMap<ProductBrandListDto, ProductBrand>().ReverseMap();
            CreateMap<ProductBrandUpdateDto, ProductBrand>().ReverseMap();
        }
    }
}
