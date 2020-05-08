using CorporateArchitecture.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CorporateArchitecture.Dal.Concrete.EntityFramework.Contexts
{
    public class CorporateArchitectureContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CorparateArchitectureDB;Trusted_Connection=true");
        }

        public DbSet<Product> Product { get; set; }
    }
}
