using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/*
1. Определить класс, содержащий:
      - Конструкторы - DONE        
      - Статический конструктор - 
      - Закрытый конструктор. Как его вызывать? - 
      - Поле только для чтения - 
      - Поле константу - 
      - Свойства (get, set) для всех полей класса (они должны быть закрытыми). Для одного ограничить доступ по set - 
      - В одном из методов использовать ref и out - 
      - Статическое поле, хранящее количество созданных объектов и статический метод вывода информации - 
      - Сделать класс partial - 
      - Переопределить Equals, GetHashCode, ToString - 
2. Продемонстрировать все методы, свойства, конструкторы и прочее - 
3. Создать массив объектов моего класса, задание - 
4. Создать и вывести анонимный тип - 
*/

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Abiturient.Info();

            Random rnd = new Random();
            int[][] tempArray = new int[3][];
            for (int i = 0; i < tempArray.Length; i++)
                tempArray[i] = new int[] { rnd.Next(2, 10), rnd.Next(2, 10), rnd.Next(2, 10), rnd.Next(2, 10), rnd.Next(2, 10) };

            int counter = 0;
            Abiturient[] obj = new Abiturient[3];
            obj[0] = new Abiturient(counter++, "Oleg", 291170726);
            obj[0].Scores = tempArray[0];
            Console.WriteLine(obj[0].ToString());
            obj[0].PrintScores();
            obj[1] = new Abiturient(counter++, "Scvortsov", tempArray[1]);
            Console.WriteLine(obj[1].ToString());
            obj[1].PrintScores();
            obj[2] = new Abiturient(counter++, "Fedoruk", tempArray[2]);
            Console.WriteLine(obj[2].ToString());
            obj[2].PrintScores();
            Console.WriteLine();

            Abiturient objNew = obj[1];
            if (Equals(objNew, obj[1]))
            {
                Console.WriteLine("It's Done");
            }

            int average = 0;
            Abiturient.CalculateAverageScore(out average, 1, 2, 3, 4, 1);
            Console.WriteLine("1 2 3 4 1; Average: {0}", average);
            Console.WriteLine();

            foreach (var item in obj)
                if (item.CheckOnPassableScores())
                    Console.WriteLine("{0} has passable scores)", item.ToString());
                else
                    Console.WriteLine("{0} have unpassable scores)", item.ToString());
            Console.WriteLine();

            int wall = 20;
            Console.WriteLine("Wall: {0}", wall);
            foreach (var item in obj)
                if (item.ChekOnSumWall(wall))
                    Console.WriteLine("{0} passes wall)", item.ToString());
                else
                    Console.WriteLine("{0} doesn't pass wall)", item.ToString());
            Console.WriteLine();

            var objVar = new { Name = "Igor" };
            Console.WriteLine(objVar.GetType());
        }
    }
}
