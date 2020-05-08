using CorporateArchitecture.Entity.ComplexTypes.Model;
using CorporateArchitecture.Entity.Concrete;
using FluentValidation;

namespace CorporateArchitecture.Bll.ValidationRules.FluentValidation
{
    public class ProductValidation : AbstractValidator<ProductModel>
    {
        public ProductValidation()
        {
            RuleFor(p => p.Product.ProdName).NotEmpty();
            RuleFor(p => p.Product.ProdName).Length(2, 30);
            RuleFor(p => p.Product.ProdUnitPrice).NotEmpty();
            RuleFor(p => p.Product.ProdUnitPrice).GreaterThanOrEqualTo(1);
            RuleFor(p => p.Product.ProdName).Must(StartWithWithA);

        }
        private bool StartWithWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
