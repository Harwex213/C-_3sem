using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            var university = new University();
            foreach (var item in university)
            {
                Console.WriteLine(item);
            }

            Queue<int> array = new Queue<int>();
            array.Enqueue(10);
            array.Enqueue(123);
            array.Enqueue(243);
            array.Enqueue(1012351);
            array.Enqueue(1053);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            var tempVar = Console.ReadLine();
            int n = System.Convert.ToInt32(tempVar);
            for (int i = 0; i < n; i++)
            {

            }

        }
    }
}
