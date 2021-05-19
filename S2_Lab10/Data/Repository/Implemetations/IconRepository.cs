using System.Collections.Generic;
using S2_Lab10.Data.UnitOfWork;

namespace S2_Lab10
{
    public class IconRepository : RepositoryBase<Icon>
    {
        public IconRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }
        
        public override IEnumerable<Icon> GetModelList()
        {
            throw new System.NotImplementedException();
        }

        public override Icon GetModel(int id)
        {
            throw new System.NotImplementedException();
        }

        public override void Create(Icon item)
        {
            throw new System.NotImplementedException();
        }

        public override void Update(Icon item)
        {
            throw new System.NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}