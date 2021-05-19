using System;
using System.Data;

namespace S2_Lab10.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public IDbCommand CreateCommand();
        public void SaveChanges();
    }
}