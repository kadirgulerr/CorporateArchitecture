using Core.DataAccess.EntityFramework;
using CorporateArchitecture.Entity.Concrete;
using System.Collections.Generic;

namespace CorporateArchitecture.Dal.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<Product> GetAll();
    }
}
