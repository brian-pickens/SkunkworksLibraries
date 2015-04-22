using System.Data.Entity;
using DataModel.Entity;

namespace EFDataAccess
{
    public class DogRepository : EFGenericRepository<Dog>
    {
        public DogRepository(DbSet<Dog> dbSet) : base(dbSet)
        {
        }
    }
}
