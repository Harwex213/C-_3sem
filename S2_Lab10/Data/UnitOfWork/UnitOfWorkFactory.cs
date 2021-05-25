using System.Configuration;
using System.Data.SqlClient;

namespace S2_Lab10.Data.UnitOfWork
{
    public class UnitOfWorkFactory
    {
        public static IUnitOfWork Create()
        {
            var connection = new DataBaseConnection().DataBaseConnect();
            connection.Open();
		
            return new AdoNetUnitOfWork(connection);
        }
    }
}