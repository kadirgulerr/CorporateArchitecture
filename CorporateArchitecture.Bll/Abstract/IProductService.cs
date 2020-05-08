using CorporateArchitecture.Entity.ComplexTypes.Model;
using CorporateArchitecture.Entity.Concrete;
using System.Collections.Generic;

namespace CorporateArchitecture.Bll.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        ProductModel Add(ProductModel model);
        Product Update();
        bool Delete();
    }
}
