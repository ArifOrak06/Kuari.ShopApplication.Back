using FluentValidation;
using Kuari.ShopApplication.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.ShopApplication.Service.Validations.ProductBrandDtosValidations
{
    public class ProductBrandUpdateDtoValidator : AbstractValidator<ProductBrandUpdateDto>
    {
        public ProductBrandUpdateDtoValidator()
        {
            RuleFor(x => x.Id).NotNull().WithMessage("{PropertyName} zorunlu alandır").NotEmpty().WithMessage("{PropertyName} boş bırakılamaz");
            RuleFor(x => x.Name).NotNull().WithMessage("{PropertyName} zorunlu alandır").NotEmpty().WithMessage("{PropertyName} boş olamaz");
            RuleFor(x => x.ProductId).NotNull().WithMessage("{PropertyName} zorunlu alandır").NotEmpty().WithMessage("{PropertyName} boş olamaz");
            RuleFor(x => x.ProductId).InclusiveBetween(1, int.MaxValue);
        }
    }
}
