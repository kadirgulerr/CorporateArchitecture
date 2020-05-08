using Core.DataAccess.EntityFramework;
using CorporateArchitecture.Dal.Abstract;
using CorporateArchitecture.Dal.Concrete.EntityFramework.Contexts;
using CorporateArchitecture.Entity.Concrete;
using System.Collections.Generic;

namespace CorporateArchitecture.Dal.Concrete.EntityFramework
{
    //public class EfProuctDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal

    public class EfProductDal : EfEntityRepositoryBase<Product, CorporateArchitectureContext>, IProductDal
    {
        public Product Add(Product parameters)
        {
            return new Product()
            {
                ProdId = 4,
                ProdBrand = "Logitech",
                ProdName = "Mouse",
                ProdUnitPrice = 50,
                ProdCategoryId = 2
            };
        }

        public List<Product> GetAll()
        {
            return new List<Product>() {
             new Product(){
              ProdId = 1,
               ProdName = "Dizüstü Bilgisayar",
               ProdBrand = "Casper",
               ProdUnitPrice = 1500,
               ProdCategoryId = 1
             },
             new Product(){
              ProdId = 2,
              ProdName = "Masaüstü Bilgisayar",
              ProdBrand = "Asus",
              ProdUnitPrice = 2000,
              ProdCategoryId = 1
             },
             new Product()
             {
             ProdId = 3,
             ProdBrand = "Porselen",
             ProdName = "Paşabahçe",
             ProdUnitPrice = 50,
              ProdCategoryId = 55
             }
            };
        }
    }
}
