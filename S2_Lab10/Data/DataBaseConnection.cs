using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace S2_Lab10.Data
{
    public class DataBaseConnection
    {
        public DataBaseConnection()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        
        private readonly string _connectionString;
        private const string GeneralConnection = "Server=.;Database=master;Trusted_Connection=True";
        private const string DataBaseName = "lab10_OOP";
        
        public SqlConnection DataBaseConnect()
        {
            var testConnection = DataBaseCheck();
            if (testConnection is not null)
                return new SqlConnection(_connectionString);
            
            var createDatabase = "create database " + DataBaseName;
            var createTables = 
                @"CREATE TABLE Products
                                        (
                                            Id INT PRIMARY KEY IDENTITY,
                                            Name NVARCHAR(50),
                                            Weight INT,
                                            Price MONEY
                                        )
                  CREATE TABLE Icons
                                    (
                                        Id INT PRIMARY KEY IDENTITY,
                                        ProductId INT foreign key references Products(Id),
                                        Photo varbinary(MAX)
                                    )";
            
            var createProcGetProductInfo = @"CREATE PROCEDURE sp_GetProductsInfo
                                             AS 
                                                SELECT p.Id, p.Name, p.Weight, p.Price, i.ProductId, i.Photo 
                                                FROM Products p 
                                                    join Icons i on p.Id = i.ProductId";

            try
            {
                using var connection = new SqlConnection(GeneralConnection);
                connection.Open();
                var command = new SqlCommand(createDatabase, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Database creation failed");
                MessageBox.Show(e.Message);
            }

            try
            {
                using var connection = new SqlConnection(_connectionString);
                connection.Open();
                var command = new SqlCommand(createTables, connection);
                command.ExecuteNonQuery();
                command.CommandText = createProcGetProductInfo;
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Table creation failed");
                MessageBox.Show(e.Message);
            }
            
            return new SqlConnection(_connectionString);
        }

        private SqlConnection DataBaseCheck()
        {
            try
            {
                using var connection = new SqlConnection(GeneralConnection);
                connection.Open();
                var sqlCreateDbQuery = $"SELECT database_id FROM sys.databases WHERE Name = '{DataBaseName}'";
                var sqlDatabaseCheck = new SqlCommand(sqlCreateDbQuery, connection);
                return (int) sqlDatabaseCheck.ExecuteScalar() > 0 ? connection : null;
            }
            catch (Exception e)
            {
                MessageBox.Show("The desired database was not found");
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}