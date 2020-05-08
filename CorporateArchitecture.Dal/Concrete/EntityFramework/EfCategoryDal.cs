using Core.DataAccess.EntityFramework;
using CorporateArchitecture.Dal.Abstract;
using CorporateArchitecture.Dal.Concrete.EntityFramework.Contexts;
using CorporateArchitecture.Entity.Concrete;

namespace CorporateArchitecture.Dal.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, CorporateArchitectureContext>, ICategoryDal
    {
    }
}
