using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OOP_lab12
{
    class Program
    {
        #region abiturient
        interface IInterface1 { }
        partial class Abiturient : IInterface1
        {
            //Readonly Field - ID
            public int Identificator { get; set; } = 0;

            private string name = "";
            public string Name
            {
                get { return name; }
                set
                {
                    if (value != null)
                        name = value;
                }
            }
            private string middle = "";
            public string Middle
            {
                get { return middle; }
                set
                {
                    if (value != null)
                        middle = value;
                }
            }
            private string last = "";
            public string Last
            {
                get { return name; }
                set
                {
                    if (value != null)
                        last = value;
                }
            }
            private string adress = "";
            public string Adress
            {
                get { return name; }
                set
                {
                    if (value != null)
                        adress = value;
                }
            }
            public int Telephone { get; set; } = 0;
            public int[] Scores { get; set; } = new int[5];

            private readonly int ID;
            const string university = "BSTU";
            public static int PassableScore { get; set; } = 4;
            private static char city;
            static private int count = 0;
            private static Random random = new Random();

            public Abiturient()
            {
                ID = this.GetHashCode();
                for (int i = 0; i < Scores.Length; i++)
                    Scores[i] = random.Next(3, 10);
                count++;
            }
            public Abiturient(int id, string name, int telephone) : this()
            {
                Identificator = id;
                Name = name;
                Telephone = telephone;
            }
            public Abiturient(int id, string last, int[] scores) : this(scores, id)
            {
                Last = last;
            }
            private Abiturient(int[] scores, int id = -1, string name = "anonymous", int telephone = 112) : this()
            {
                Scores = scores;
                Identificator = id;
                Name = name;
                Telephone = telephone;
            }

            static Abiturient()
            {
                city = 'A';
            }

        }
        partial class Abiturient
        {
            //static methods
            public static void Info()
            {
                Console.WriteLine("Abiturients of city - {0}.", city);
            }
            public static void CalculateAverageScore(out int average, params int[] scores)
            {
                average = 0;
                for (int i = 0; i < scores.Length; i++)
                    average += scores[i];
                average /= scores.Length;
            }
            public static void SetMaxScore(ref int score)
            {
                score = 10;
            }
            public static void SetCity(char newCity)
            {
                city = newCity;
            }

            //class methods
            public void AddScores(params object[] scores)
            {
                for (int i = 0; i < scores.Length && i < Scores.Length; i++)
                    Scores[i] = (int)scores[i];
            }
            public int MaxScore()
            {
                int i = 0;
                foreach (var item in Scores)
                    if (i < item)
                        i = item;
                return i;
            }
            public int MinScore()
            {
                int i = 0;
                foreach (var item in Scores)
                    if (i > item)
                        i = item;
                return i;
            }
            public bool CheckOnPassableScores()
            {
                bool outcome = true;
                foreach (var item in Scores)
                    if (item < PassableScore)
                        outcome = false;
                return outcome;
            }
            public bool ChekOnSumWall(int wall)
            {
                int sum = 0;
                foreach (var item in Scores)
                    sum += item;
                return (wall < sum) ? true : false;
            }
            public void PrintScores()
            {
                foreach (var item in Scores)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }

            //override methods
            public override string ToString() => $"[Identificator: {Identificator}; Name: {Name}; Middle : {Middle}; Last : {Last}; Adress : {Adress}; Telephone: {Telephone};]";

            public override bool Equals(object obj)
            {
                if (obj is Abiturient && obj != null)
                {
                    Abiturient temp;
                    temp = (Abiturient)obj;
                    if (temp.Identificator == this.Identificator
                        && temp.Name == this.Name
                        && temp.Middle == this.Middle
                        && temp.Last == this.Last
                        && temp.Adress == this.Adress
                        && temp.Telephone == this.Telephone) return true;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return this.ToString().GetHashCode();
            }
        }
        #endregion

        #region student
        class Student
        {
            public string Name { get; set; } = "Anonim";
            public string Speciality { get; set; } = "ISIT";
            public Student() { }
            public Student(string name, string speciality)
            {
                Name = name;
                Speciality = speciality;
            }
            public void MakeLab()
            {
                Console.WriteLine("Starting work on Lab...");
            }
            public override string ToString()
            {
                return base.ToString() + $"Name: {Name}" + $"Speciality: {Speciality}";
            }
        }
        #endregion

        static void Main(string[] args)
        {
            // First class.
            Abiturient abiturient = new Abiturient(1, "Kaportsev", new int[] { 1, 234, 5, 24, 1 });

            Console.WriteLine(Reflector.GetAssemblyName(abiturient.GetType()));

            if (Reflector.IsPublicConstructors(abiturient.GetType()))
                Console.WriteLine("У класса есть публичные конструкторы...");
            else 
                Console.WriteLine("У класса нет публичных конструкторов...");

            Console.WriteLine("Public Methods:");
            foreach (var i in Reflector.GetPublicMethods(abiturient.GetType())) 
                Console.WriteLine(i);

            Console.WriteLine("Fields:");
            foreach (var i in Reflector.GetFields(abiturient.GetType())) 
                Console.WriteLine(i);

            Console.WriteLine("Interfaces:");
            foreach (var i in Reflector.GetInterfaces(abiturient.GetType())) 
                Console.WriteLine(i);

            Reflector.OutputMetodsNameFromParamType(abiturient.GetType());

            // Second class.
            Student student = new Student("Kaportsev", "POIT");

            Console.WriteLine(Reflector.GetAssemblyName(student.GetType()));

            if (Reflector.IsPublicConstructors(student.GetType()))
                Console.WriteLine("У класса есть публичные конструкторы...");
            else
                Console.WriteLine("У класса нет публичных конструкторов...");

            Console.WriteLine("Public Methods:");
            foreach (var i in Reflector.GetPublicMethods(student.GetType())) 
                Console.WriteLine(i);

            Console.WriteLine("Fields:");
            foreach (var i in Reflector.GetFields(student.GetType())) 
                Console.WriteLine(i);

            Console.WriteLine("Interfaces:");
            foreach (var i in Reflector.GetInterfaces(student.GetType())) 
                Console.WriteLine(i);

            Reflector.OutputMetodsNameFromParamType(student.GetType());
            
            // Standart class.
            List<int> standart = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine(Reflector.GetAssemblyName(standart.GetType()));

            if (Reflector.IsPublicConstructors(standart.GetType()))
                Console.WriteLine("У класса есть публичные конструкторы...");
            else
                Console.WriteLine("У класса нет публичных конструкторов...");

            Console.WriteLine("Public Methods:");
            foreach (var i in Reflector.GetPublicMethods(standart.GetType()))
                Console.WriteLine(i);

            Console.WriteLine("Fields:");
            foreach (var i in Reflector.GetFields(standart.GetType()))
                Console.WriteLine(i);

            Console.WriteLine("Interfaces:");
            foreach (var i in Reflector.GetInterfaces(standart.GetType()))
                Console.WriteLine(i);

            Reflector.OutputMetodsNameFromParamType(standart.GetType());

            // Invoke.
            object[] param = new object[1];
            using (StreamReader fstream = new StreamReader(@"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab12\files\Params.txt"))
            {
                string textFromFile = null;
                while ((textFromFile = fstream.ReadLine()) != null)
                    param[0] = Convert.ToInt32(textFromFile);
            }
            Reflector.Invoke(standart, "Add", param);

            Random rand = new Random();
            param[0] = rand.Next();
            Reflector.Invoke(standart, "Add", param);

            var someClass = Reflector.Create(typeof(Abiturient));
            Console.WriteLine(someClass.ToString());
        }

        public static class Reflector
        {
            static public string GetAssemblyName(Type t)
            {
                Assembly a = t.Assembly;
                return a.GetName().Name;
            }
            static public bool IsPublicConstructors(Type t)
            {
                var constructors = t.GetConstructors();

                return constructors.Length > 0;
            }
            static public IEnumerable<string> GetPublicMethods(Type t)
            {
                var metods = from i in t.GetMethods() select i.Name;
                return metods;
            }
            static public IEnumerable<string> GetFields(Type t)
            {
                var fields = from i in t.GetFields() select i.Name;
                return fields;
            }
            static public IEnumerable<string> GetInterfaces(Type t)
            {
                var fields = from i in t.GetInterfaces() select i.Name;
                return fields;
            }
            static public void OutputMetodsNameFromParamType(Type t)
            {
                Console.WriteLine("\n--------------------\nВведите тип параметра:");
                string paramType = Console.ReadLine();
                var methods = t.GetMethods();
                var resultMethods = from i in methods
                                   where
                  (from c in i.GetParameters() select c.ParameterType.Name).Contains(paramType)
                                   select i.Name;
                foreach (var i in resultMethods)
                    Console.WriteLine(i);
                Console.WriteLine("--------------------\n");
            }
            static public void Invoke(object t, string methodName, object[] arr)
            {
                MethodInfo m = t.GetType().GetMethod(methodName);
                m.Invoke(t, arr);
            }
            static public object Create(Type t)
            {
                return Activator.CreateInstance(t);
            }
        }
    }
}
