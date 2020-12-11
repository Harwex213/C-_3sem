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
        public string Name { get; set; }
        public string Organization { get; set; }
        public Owner()
        {
            Name = "Oleg";
            Organization = "Harwex Corporation";
        }

        public void WriteOwner()
        {
            Console.WriteLine($"ID: {Id}; Name: {Name}; Organization: {Organization};");
        }
    }
}
