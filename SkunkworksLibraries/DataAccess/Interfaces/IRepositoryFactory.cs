using System;

namespace DataAccess
{
    public interface IRepositoryFactory
    {
        T Get<T, TE>() where TE : Type where T : IGenericRepository<TE>;
    }
}