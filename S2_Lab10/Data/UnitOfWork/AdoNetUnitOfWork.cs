using System;
using System.Data;

namespace S2_Lab10.Data.UnitOfWork
{
    public class AdoNetUnitOfWork : IUnitOfWork
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;

        public AdoNetUnitOfWork(IDbConnection connection)
        {
            _connection = connection;
            _transaction = connection.BeginTransaction();
        }
	
        public IDbCommand CreateCommand()
        {
            var command = _connection.CreateCommand();
            command.Transaction = _transaction;
            return command;
        }
	
        public void SaveChanges()   
        {
            if (_transaction == null)
                throw new InvalidOperationException("Transaction have already been committed. Check your transaction handling.");
			
            _transaction.Commit();
            _transaction = null;
        }

        public void Dispose()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction = null;
            }
        }
    }
}