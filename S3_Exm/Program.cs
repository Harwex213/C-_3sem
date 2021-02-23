using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_Exm
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SomeCollection<int> collection = new SomeCollection<int>();
                ((IColl<int>)collection).AddlEl(1);
                ((IColl<int>)collection).AddlEl(2);
                ((IColl<int>)collection).AddlEl(3);
                ((IColl<int>)collection).DelEl(2);
                for (int i = 0; i < collection.Size; i++)
                {
                    Console.WriteLine(((IColl<int>)collection).Get(i));
                }
                ((IColl<int>)collection).DellAll();
                //((IColl<int>)collection).DelEl(2);
                Console.WriteLine("Some Thing");

                SomeCollection<Student> collectionStudent = new SomeCollection<Student>();
                ((IColl<Student>)collectionStudent).AddlEl(new Student() {Name = "Liza", Mark = 4, Subject = "Math" });
                ((IColl<Student>)collectionStudent).AddlEl(new Student() { Name = "Who", Mark = 2, Subject = "Math" });
                for (int i = 0; i < collectionStudent.Size; i++)
                {
                    Console.WriteLine(((IColl<Student>)collectionStudent).Get(i).Name);
                }

                var linqRequest = (from student in collectionStudent.Collection where student.Mark >= 4 select student).Count();
                Console.WriteLine($"Человек сдало: {linqRequest}");

                var linqRequest1 = (from student in collectionStudent.Collection select student.Mark).Average();
                Console.WriteLine($"Средняя оценка: {linqRequest1}");

                Console.WriteLine(((IColl<Student>)collectionStudent).Get(0).Mark);
                ((IColl<Student>)collectionStudent).Get(0).Help();
                Console.WriteLine(((IColl<Student>)collectionStudent).Get(0).Mark);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }
        }
    }
    static class ServiceClass
    {
        public static void Help(this Student student)
        {
            var random = new Random();
            student.Mark += random.Next(1, 3);
        }
    }
    interface IColl<T>
    {
        void AddlEl(T element);
        void DelEl(T element);
        T Get(int index);
        void DellAll();
    }

    class SomeCollection<T> : IColl<T> where T : new()
    {
        public List<T> Collection { get; set; } = new List<T>();

        public int Size { get => Collection.Count; }

        void IColl<T>.AddlEl(T element)
        {
            Collection.Add(element);
        }

        void IColl<T>.DelEl(T element)
        {
            if (Size == 0)
                throw new NullSizeCollection("Коллекция пуста!");
            Collection.Remove(element);
        }

        void IColl<T>.DellAll()
        {
            if (Size == 0)
                throw new NullSizeCollection("Коллекция пуста!");
            Collection.Clear();
        }

        T IColl<T>.Get(int index)
        {
            return Collection[index];
        }
    }

    class NullSizeCollection : ApplicationException
    {
        public NullSizeCollection(string message = "**** Error in Collection! ****") : base(message) { }
    }

    class Student
    {
        public string Name { get; set; } = "";
        public int Mark { get; set; } 
        public string Subject { get; set; } = "";
        public Student()
        {

        }
    }
}
