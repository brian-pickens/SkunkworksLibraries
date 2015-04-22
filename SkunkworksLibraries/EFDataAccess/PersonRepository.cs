using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel.Entity;

namespace EFDataAccess
{
    public class PersonRepository : EFGenericRepository<Person>
    {
        public PersonRepository(DbSet<Person> dbSet) : base(dbSet)
        {
        }
    }
}
