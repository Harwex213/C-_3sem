using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab05
{
    enum TypeOfScience
    {
        Physics,
        Chemistry,
        Mathematics
    }
    struct Science
    {
        public TypeOfScience ScienceType { get; set; }
        public Science(TypeOfScience type)
        {
            ScienceType = type;
        }
        public void MakeSience()
        {
            Console.WriteLine("Today we are going to make a Super Cool Powerful Computer made of dust.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Lab 7.
                // TechnicException.CheckTechnic(new Computer() { Price = -10 });
                Console.WriteLine("This line will write without exception");
                int[] a = null;
                Debug.Assert(a != null, "Values array cannot be null!");
                // Lab 6.
                var scienceVar = new Science();
                scienceVar.ScienceType = TypeOfScience.Physics;

                var laboratory1 = new Laboratory();

                laboratory1.Add(new Computer() { Name = "COMP1", Price = 100 });
                Console.WriteLine(laboratory1.Get(1));
                laboratory1.Add(new Computer() { Name = "COMP2", Price = 200 });
                Console.WriteLine(laboratory1.Get(2));
                laboratory1.Add(new Computer() { Name = "COMP3", Price = 10 });
                laboratory1.Add(new Computer() { Name = "COMP4", Price = 150 });
                LaboratoryManager.PrintTechnicOrderByPrice(laboratory1);
                laboratory1.Add(new Computer() { Name = "COMP5" });
                var tempTabet = new Tablet() { Name = "Oleg" };
                laboratory1.Add(tempTabet);
                laboratory1.Remove(tempTabet);
                laboratory1.Remove(new Computer() { Name = "COMP5" });

                laboratory1.Set(4, new Computer() { Name = "NEWCOMP" });

                Console.WriteLine(laboratory1.Get(1).CurrentOperationPeriod.Days);
                laboratory1.Get(1).CurrentOperationPeriod = new TimeSpan(2000, 0, 0, 0);
                Console.WriteLine(laboratory1.Get(1).CurrentOperationPeriod.Days);
                LaboratoryManager.SearchOldTechnic(laboratory1);

                LaboratoryManager.PrintTechnicOrderByPrice(laboratory1);

                // Lab 5.
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
            catch (ComputerException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.StackTrace);
            }
            catch (TabletException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.StackTrace);
            }
            catch (TechnicException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("This line will write in any case exception");
            }
        }
    }
}
