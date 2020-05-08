using Core.Entities;
using CorporateArchitecture.Entity.Concrete;

namespace CorporateArchitecture.Entity.ComplexTypes.Model
{
    public class ProductModel : IModelEntity
    {
        public Product Product { get; set; }
    }
}
