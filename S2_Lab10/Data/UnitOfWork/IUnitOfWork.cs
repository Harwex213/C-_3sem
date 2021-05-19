using System.Data;

namespace S2_Lab10.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IDbCommand CreateCommand();
        public void SaveChanges();
        public void Dispose();
    }
}