using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    //Множество Set
    // !=            - проверка множеств на неравенство
    // >             - проверка множествa на подмножество 
    // %             - пересечение множеств
    class Set<T> : IGenericInterface<T> // where T : struct
    {
        public List<T> Items { get; set; } = new List<T>();

        public Owner ThisOwner { get; set; } = new Owner();

        public Set() { }
        public Set(params T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Items.Add(arr[i]);
            }
        }
        public static bool operator ==(Set<T> setFirst, Set<T> setSecond)
        {
            for (int i = 0; i < setFirst.Items.Count; i++)
            {
                if (!setSecond.Items.Contains(setFirst.Items[i]))
                    return false;
            }
            for (int i = 0; i < setSecond.Items.Count; i++)
            {
                if (!setFirst.Items.Contains(setSecond.Items[i]))
                    return false;
            }
            return true;
        }
        public static bool operator !=(Set<T> setFirst, Set<T> setSecond)
        {
            for (int i = 0; i < setFirst.Items.Count; i++)
            {
                if (setSecond.Items.Contains(setFirst.Items[i]))
                    return false;
            }
            for (int i = 0; i < setSecond.Items.Count; i++)
            {
                if (setFirst.Items.Contains(setSecond.Items[i]))
                    return false;
            }
            return true;
        }
        public static bool operator <(Set<T> setFirst, Set<T> setSecond)
        {
            bool check = true;
            for (int i = 0; i < setFirst.Items.Count; i++)
            {
                if (!setSecond.Items.Contains(setFirst.Items[i]))
                    check = false;
            }
            return check;
        }
        public static bool operator >(Set<T> setFirst, Set<T> setSecond)
        {
            bool check = true;
            for (int i = 0; i < setSecond.Items.Count; i++)
            {
                if (!setFirst.Items.Contains(setSecond.Items[i]))
                    check = false;
            }
            return check;
        }
        public static Set<T> operator %(Set<T> setFirst, Set<T> setSecond)
        {
            Set<T> interSet = new Set<T>();
            for (int i = 0; i < setSecond.Items.Count; i++)
            {
                if (setFirst.Items.Contains(setSecond.Items[i]))
                    interSet.Items.Add(setSecond.Items[i]);
            }
            interSet.Items.Sort();
            return interSet;
        }
        public void Add(T value)
        {
            Items.Add(value);
        }

        public void Remove(int index)
        {
            Items.RemoveAt(index);
        }

        public void PrintCollection()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Console.WriteLine(Items[i]);
            }
        }
    }
}
