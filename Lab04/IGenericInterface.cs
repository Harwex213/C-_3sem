using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    interface IGenericInterface<T>
    {
        void Add(T value);
        void Remove(int index);
        void PrintCollection();
    }
}
