using FluentValidation;
using Kuari.ShopApplication.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.ShopApplication.Service.Validations.ProductDtosValidations
{
    public class ProductCreateDtoValidator : AbstractValidator<ProductCreateDto>
    {
        public ProductCreateDtoValidator()
        {
            RuleFor(x => x.Price).NotNull().WithMessage("{PropertyName} zorunlu alandır.").NotEmpty().WithMessage("{PropertyName} boş olamaz");
            RuleFor(x => x.ProductBrandId).NotNull().WithMessage("{PropertyName} zorunlu alandır.").NotEmpty().WithMessage("{PropertyName} boş olamaz");
            RuleFor(x => x.ProductBrandId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} 1 dahil 1'den büyük rakamlar girilebilir.");
            RuleFor(x => x.ProductTypeId).NotNull().WithMessage("{PropertyName} zorunlu alandır").NotEmpty().WithMessage("{PropertyName} boş olamaz");
            RuleFor(x => x.ProductTypeId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} 1 dahil 1'den büyük rakamlar girilebilir.");
            RuleFor(x => x.Description).NotNull().WithMessage("{PropertyName} zorunlu alandır").NotEmpty().WithMessage("{PropertyName} boş olamaz");
            RuleFor(x => x.PictureUrl).NotNull().WithMessage("{PropertyName} zorunlu alandır").NotEmpty().WithMessage("{PropertyName} boş olamaz");
        }
    }
}
