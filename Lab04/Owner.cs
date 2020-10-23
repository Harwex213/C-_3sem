using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Owner
    {
        public int Id { get; set; }
        public static int Counter{ get; set; }
        public static string Name { get; set; }
        public static string Organization { get; set; }

        public Owner() {
            Id = Counter++;
        }
        static Owner()
        {
            Counter = 0;
            Name = "Oleg";
            Organization = "Harwex Corporation";
        }

        public void WriteOwner()
        {
            Console.WriteLine($"ID: {Id}; Name: {Name}; Organization: {Organization};");
        }
    }
}
