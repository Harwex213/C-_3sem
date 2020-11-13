using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            var tempVar = new Tablet() { Name = "Ipad Pro", Price = 400, Producer = "Apple" };

            var link = tempVar as Tablet;
            if (link != null)
                Console.WriteLine(link.ToString() + "\n");

            var linNew = tempVar is Tablet;
            if (linNew)
                Console.WriteLine(link.ToString() + "\n");

            PrintingDevice[] tempArr = { new Printer(), new Plotter(), new Xerox() };
            var newVar = new Printer();
            foreach(var temp in tempArr)
                newVar.IAmPrinting(temp);

            var tempVar2 = new Computer() { Name = "Computer Zen 321", Price = 2000, Producer = "ROG" };
            tempVar2.TurnOn();
            ((IDevice)tempVar2).TurnOn();
        }
    }
}
