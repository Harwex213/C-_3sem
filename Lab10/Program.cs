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
                Console.WriteLine(item);
            university.Students.Add(new Student { Name = "Oleg", Speciality = "ISIT" });
            university.Students.Clear();

            Queue<int> array = new Queue<int>();
            array.Enqueue(10);
            array.Enqueue(123);
            array.Enqueue(243);
            array.Enqueue(1012351);
            array.Enqueue(1053);
            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();
            Console.WriteLine("Удалить последовательность n: ");
            var tempVar = Console.ReadLine();
            int n = System.Convert.ToInt32(tempVar);
            for (int i = 0; i < n; i++)
                array.Dequeue();
            foreach (var item in array)
                Console.Write(item + " ");

            Dictionary<int, int> keyValues = new Dictionary<int, int>();
            var arrayTemp = array.ToArray<int>();
            for (int i = 0; i < array.Count; i++)
                keyValues.Add(i, arrayTemp[i]);
            Console.WriteLine();
            Console.WriteLine("Введите в консоль TKey: ");
            tempVar = Console.ReadLine();
            n = System.Convert.ToInt32(tempVar);
            Console.WriteLine($"Tkey: {keyValues.Keys.ElementAt(n-1)}, TValue: {keyValues[n-1]}");

        }
    }
}
