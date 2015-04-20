using System;

namespace DataAccess
{
    public interface IRepositoryFactory
    {
        IGenericRepository<T> Get<T>() where T : Type;
    }
}