using Core.Entities;

namespace CorporateArchitecture.Entity.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
