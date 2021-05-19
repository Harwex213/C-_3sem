using System.Collections.Generic;
using S2_Lab10.Data.UnitOfWork;

namespace S2_Lab10
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }


        public override IEnumerable<Product> GetModelList()
        {
            throw new System.NotImplementedException();
        }

        public override Product GetModel(int id)
        {
            throw new System.NotImplementedException();
        }

        public override void Create(Product item)
        {
            throw new System.NotImplementedException();
        }

        public override void Update(Product item)
        {
            throw new System.NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}