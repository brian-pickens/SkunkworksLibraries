using System;
using System.Data.Entity;
using DataAccess;

namespace EFDataAccess
{
    class RepositoryFactory : IRepositoryFactory
    {

        private readonly DbContext _context;

        public RepositoryFactory(DbContext context)
        {
            _context = context;
        }

        public T Get<T, TE>() where TE : Type where T:IGenericRepository<TE>
        {
            var x = new EFGenericRepository<TE>(_context.Set<TE>());
            return (T) Convert.ChangeType(x, typeof(T));
        }

    }
}
