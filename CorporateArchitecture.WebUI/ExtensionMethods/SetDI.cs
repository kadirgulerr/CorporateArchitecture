using CorporateArchitecture.Bll.Abstract;
using CorporateArchitecture.Bll.Concrete;
using CorporateArchitecture.Dal.Abstract;
using CorporateArchitecture.Dal.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace CorporateArchitecture.WebUI.ExtensionMethods
{
    public class SetDI
    {
        public static void DependencyServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EfProductDal>();
        }
    }
}
