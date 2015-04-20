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

        public IGenericRepository<T> Get<T>() where T : Type
        {
            return new EFGenericRepository<T>(_context.Set<T>());
        }
    }
}
