using Core.Entities;

namespace CorporateArchitecture.Entity.Concrete
{
    public class Product : IEntity
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public int ProdCategoryId { get; set; }
        public string ProdBrand { get; set; }
        public decimal ProdUnitPrice { get; set; }
    }
}
