using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using S2_Lab10.Data.UnitOfWork;

namespace S2_Lab10
{
    public class IconRepository : RepositoryBase<Icon>
    {
        public IconRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
        
        public override IEnumerable<Icon> GetModelList()
        {
            var products = new List<Icon>();
            
            using var command = UnitOfWork.CreateCommand();
            command.CommandText = "select * from Icons";
            var result = command.ExecuteReader();

            while (result.Read())
            {
                products.Add(new Icon
                {
                    Id = result.GetInt32(0),
                    ProductId = result.GetInt32(1),
                    Photo = (byte[]) result.GetValue(2)
                });
            }
            
            return products;
        }

        public override Icon GetModel(int id)
        {
            if (id < 0)
                return null;

            using var command = UnitOfWork.CreateCommand();
            command.CommandText = "select * from Icons where Id = @id";
            command.Parameters.Add(new SqlParameter("@id", id));
            var result = command.ExecuteReader();

            if (!result.Read()) 
                return null;
            
            var icon = new Icon()
            {
                Id = result.GetInt32(0),
                ProductId = result.GetInt32(1),
                Photo = (byte[]) result.GetValue(2)
            };
            return icon;
        }

        public override int Create(Icon item)
        {
            if (item is null)
                return -1;

            using var command = UnitOfWork.CreateCommand();
            command.CommandText = @"insert into Icons(ProductId, Photo)
                                            values(@productId, @photo);
                                    SET @id=SCOPE_IDENTITY();";
            
            command.Parameters.Add(new SqlParameter("@productId", item.ProductId));
            command.Parameters.Add(new SqlParameter("@photo", item.Photo));
            
                        
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

        public override void Update(Icon item)
        {
            if (item is null)
                return;
            
            using var command = UnitOfWork.CreateCommand();
            command.CommandText = @"update Icons set ProductId = @productId,
                                                        Photo = @photo
                                    where Id = @id";
            command.Parameters.Add(new SqlParameter("@id", item.Id));
            command.Parameters.Add(new SqlParameter("@productId", item.ProductId));
            command.Parameters.Add(new SqlParameter("@photo", item.Photo));
            command.ExecuteNonQuery();
        }

        public override void Delete(int id)
        {
            if (id < 0)
                return;
            
            using var command = UnitOfWork.CreateCommand();
            command.CommandText = "delete from Icons where Id = @id";
            command.Parameters.Add(new SqlParameter("@id", id));
            command.ExecuteNonQuery();
        }
    }
}