using System;
using System.Security.Cryptography.X509Certificates;

namespace DataAccess
{
    public interface IGenericRepositoryContext : IDisposable
    {
        void Commit();
    }
}