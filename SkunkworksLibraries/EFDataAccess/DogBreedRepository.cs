using System.Data.Entity;
using DataModel.Entity;

namespace EFDataAccess
{
    public class DogBreedRepository : EFGenericRepository<DogBreed>
    {
        public DogBreedRepository(DbSet<DogBreed> dbSet) : base(dbSet)
        {
        }
    }
}
