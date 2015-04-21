using System;
using System.Data.Entity;
using DataAccess;

namespace EFDataAccess
{
    class EFUnitOfWork : IDisposable
    {

        private readonly DbContext _context;

        public EFUnitOfWork(DbContext context)
        {
            _context = context;
        }

        public T Get<T, TE>() where TE : Type where T:EFGenericRepository<TE>
        {
            var x = new EFGenericRepository<TE>(_context.Set<TE>());
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
