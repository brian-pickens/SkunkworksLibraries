using System;
using System.Data.Entity;
using DataAccess;

namespace EFDataAccess
{
    public class EFGenericRepositoryContext : IGenericRepositoryContext
    {

        private readonly DbContext _context;

        public EFGenericRepositoryContext(DbContext context)
        {
            _context = context;
        }

        public T Get<T, TE>() where TE : class where T:EFGenericRepository<TE>
        {
            var x = Activator.CreateInstance(typeof(T), _context.Set<TE>());
            return (T) Convert.ChangeType(x, typeof(T));
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
