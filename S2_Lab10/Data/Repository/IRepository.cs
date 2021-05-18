using System;
using System.Collections.Generic;

namespace S2_Lab10
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetProductList();
        T GetProduct(int id);
        void Create(T item);
        void Update(T item); 
        void Delete(int id); 
        void Save();  
    }
}