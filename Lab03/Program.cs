using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lab 11.
            string[] arrayString = { "June", "July", "August", "September", "October", "November", "December", "January", "February", "March", "April", "May" };
            var linqRequest = (from month in arrayString where month.Length >= 8 select month).ToArray<string>();
            linqRequest = (from month in arrayString where month == "December" || month == "January" || month == "February" select month).ToArray<string>();
            linqRequest = (from month in arrayString orderby month select month).ToArray<string>();
            var linqRequest2 = (from month in arrayString where month.Contains('u') select month).Count();

            List<Abiturient> abiturients = new List<Abiturient>
            {
                new Abiturient {Name = "Oleg", Last = "Kaportsev"},
                new Abiturient {Name = "Igor", Last = "Skvortsov"},
                new Abiturient {Name = "Lera", Last = "Fedoruk"},
                new Abiturient {Name = "Max", Last = "Yarmolik"},
                new Abiturient {Name = "Dima", Last = "Kaminskiy"},
                new Abiturient {Name = "Nikita", Last = "Kravchenko"},
                new Abiturient {Name = "Kirill", Last = "Kravchenko"},
                new Abiturient {Name = "Ephim", Last = "Kopil"}
            };
            var linqRequest3 = (from abit in abiturients from score in abit.Scores where score < 4 select abit).Distinct().ToArray<Abiturient>();
            Console.WriteLine("Список студентов, оценки которых ниже 4:");
            foreach (var item in linqRequest3)
                Console.WriteLine(item);
            linqRequest3 = (from abit in abiturients where abit.Scores.Sum() > 20 select abit).ToArray<Abiturient>();
            Console.WriteLine("Список студентов, у которых сумма оценок выше 20:");
            foreach (var item in linqRequest3)
                Console.WriteLine(item);
            linqRequest3 = (from abit in abiturients from score in abit.Scores where score == 10 select abit).Distinct().ToArray<Abiturient>();
            Console.WriteLine("Список студентов, у которых есть оценка 10:");
            foreach (var item in linqRequest3)
                Console.WriteLine(item);
            linqRequest3 = (from abit in abiturients orderby abit.Name select abit).ToArray<Abiturient>();
            linqRequest3 = (from abit in abiturients orderby abit.Name select abit).ToArray<Abiturient>();

            linqRequest3 = (from abit in abiturients orderby abit.Name select abit).ToArray<Abiturient>();

            Console.WriteLine("Done");
            // Lab 3.
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
