using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using S2_Lab10.Data.UnitOfWork;

namespace S2_Lab10
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
        
        public override IEnumerable<Product> GetModelList()
        {
            var products = new List<Product>();

            using var command = UnitOfWork.CreateCommand();
            command.CommandText = "select * from Products";
            var result = command.ExecuteReader();

            while (result.Read())
            {
                products.Add(new Product
                {
                    Id = result.GetInt32(0),
                    Name = result.GetString(1),
                    Weight = result.GetInt32(2),
                    Price = result.GetDecimal(3),
                });
            }
            result.Close();

            return products;
        }

        public override Product GetModel(int id)
        {
            if (id < 0)
                return null;

            using var command = UnitOfWork.CreateCommand();
            command.CommandText = "select * from Products where Id = @id";
            command.Parameters.Add(new SqlParameter("@id", id));
            var result = command.ExecuteReader();

            if (!result.Read()) 
                return null;
            
            var product = new Product()
            {
                Id = result.GetInt32(0),
                Name = result.GetString(1),
                Weight = result.GetInt32(2),
                Price = result.GetDecimal(3),
            };
            result.Close();
            
            return product;

        }

        public override int Create(Product item)
        {
            if (item is null)
                return -1;

            using var command = UnitOfWork.CreateCommand();
            command.CommandText = @"insert into Products(Name, Weight, Price)
                                            values(@name, @weight, @price);
                                            SET @id=SCOPE_IDENTITY()";
            
            command.Parameters.Add(new SqlParameter("@name", item.Name));
            command.Parameters.Add(new SqlParameter("@weight", item.Weight));
            command.Parameters.Add(new SqlParameter("@price", item.Price));
            
            var sqlParameter = new SqlParameter()
            {
                ParameterName = "@id",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };
            command.Parameters.Add(sqlParameter);
            
            command.ExecuteNonQuery();
            return (int) sqlParameter.Value;
        }

        public override void Update(Product item)
        {
            if (item is null)
                return;
            
            using var command = UnitOfWork.CreateCommand();
            command.CommandText = @"update Products set Name = @name,
                                                        Weight = @weight, 
                                                        Price = @price 
                                    where Id = @id";
            command.Parameters.Add(new SqlParameter("@id", item.Id));
            command.Parameters.Add(new SqlParameter("@name", item.Name));
            command.Parameters.Add(new SqlParameter("@weight", item.Weight));
            command.Parameters.Add(new SqlParameter("@price", item.Price));
            command.ExecuteNonQuery();
        }

        public override void Delete(int id)
        {
            if (id < 0)
                return;
            
            using var command = UnitOfWork.CreateCommand();
            command.CommandText = "delete from Products where Id=@id";
            command.Parameters.Add(new SqlParameter("@id", id));
            command.ExecuteNonQuery();
        }
    }
}