using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
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
}
