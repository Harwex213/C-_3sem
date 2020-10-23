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
    // >> (set-item) - удаление из множества
    // << (set+item) - добавление в множество
    // !=            - проверка множеств на неравенство
    // >             - проверка множествa на подмножество 
    // %             - пересечение множеств
    class Set
    {
        public List<int> Items { get; set; } = new List<int>();

        public Owner ThisOwner { get; set; } = new Owner();

        public Set() { }

        public static Set operator <<(Set set, int newElement)
        {
            set.Items.Add(newElement);
            return set;
        }
        public static Set operator >>(Set set, int oldElement)
        {
            set.Items.Remove(oldElement);
            return set;
        }
        public static bool operator ==(Set setFirst, Set setSecond)
        {
            bool check = true;
            if (setFirst.Items.Count == setSecond.Items.Count)
                for (int i = 0; i < setSecond.Items.Count; i++)
                {
                    if (setFirst.Items[i] != setSecond.Items[i])
                        check = false;
                }
            return check;
        }
        public static bool operator !=(Set setFirst, Set setSecond)
        {
            bool check = true;
            if (setFirst.Items.Count == setSecond.Items.Count)
                for (int i = 0; i < setSecond.Items.Count; i++)
                {
                    if (setFirst.Items[i] == setSecond.Items[i])
                        check = false;
                }
            return check;
        }
        public static bool operator <(Set setFirst, Set setSecond)
        {
            bool check = false;
            for (int i = 0; i < setSecond.Items.Count; i++)
            {
                for (int j = 0; j < setFirst.Items.Count; j++)
                {
                    if (setSecond.Items[i] == setFirst.Items[j])
                        check = true;
                }
                if (!check)
                    return false;
            }
            return true;
        }
        public static bool operator >(Set setFirst, Set setSecond)
        {
            bool check = false;
            for (int i = 0; i < setFirst.Items.Count; i++)
            {
                for (int j = 0; j < setSecond.Items.Count; j++)
                {
                    if (setFirst.Items[i] == setSecond.Items[j])
                        check = true;
                }
                if (!check)
                    return false;
            }
            return true;
        }
        public static Set operator %(Set setFirst, Set setSecond)
        {
            Set interSet = new Set();
            bool counter = false;
            for (int i = 0; i < setFirst.Items.Count; i++)
            {
                for (int j = 0; j < setSecond.Items.Count; j++)
                {
                    if (setFirst.Items[i] == setSecond.Items[j])
                        counter = true;
                }
                if (counter)
                    interSet.Items.Add(setFirst.Items[i]);
            }
            interSet.Items.Sort();
            return interSet;
        }
        public void PrintElem()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Console.Write($"{Items[i]} ");
            }
            Console.WriteLine();
        }

        public class Date
        { 
            public static void PrintDate()
            {
                Console.WriteLine("10.23.2020");
            }
        }

    }
}
