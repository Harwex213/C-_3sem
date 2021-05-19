using System;
using System.Collections.Generic;
using S2_Lab10.Data.UnitOfWork;

namespace S2_Lab10
{
    public abstract class RepositoryBase<T>
    {
        public RepositoryBase(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        protected IUnitOfWork UnitOfWork { get; }

        public abstract IEnumerable<T> GetModelList();
        public abstract T GetModel(int id);
        public abstract int Create(T item);
        public abstract void Update(T item); 
        public abstract void Delete(int id); 
    }
}