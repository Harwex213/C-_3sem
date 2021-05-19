using System;
using System.Collections.Generic;
using S2_Lab10.Data.UnitOfWork;

namespace S2_Lab10
{
    public abstract class RepositoryBase<T>
    {
        private IUnitOfWork _unitOfWork;
        public RepositoryBase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public abstract IEnumerable<T> GetModelList();
        public abstract T GetModel(int id);
        public abstract void Create(T item);
        public abstract void Update(T item); 
        public abstract void Delete(int id); 
    }
}