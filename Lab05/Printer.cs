using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    sealed class Printer : PrintingDevice
    {
        public override int PrintingSpeed { get; set; } = 200;

        public void IAmPrinting(PrintingDevice temp)
        {
            switch (temp)
            {
                case Printer _:
                    Console.WriteLine("This Printing Device is Printer!");
                    break;
                case Xerox _:
                    Console.WriteLine("This Printing Device is Xerox!");
                    break;
                case Plotter _:
                    Console.WriteLine("This Printing Device is Plotter");
                    break;
            }
            temp.ToString();
        }

        public override string ToString()
        {
            return base.ToString() + "I use Printer every day";
        }
    }
}
