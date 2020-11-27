using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    static class LaboratoryManager
    {
        static public void SearchOldTechnic(Laboratory laboratory)
        {
            for (int i = 1; i <= laboratory.Length; i++)
            {
                if (laboratory.Get(i).CurrentOperationPeriod.Days > 1000)
                    Console.WriteLine($"This Technic {laboratory.Get(i).Name} is almost die!!!");
            }
        }
        static public (int countTablet, int countComputer) CountAmountTechincs(Laboratory laboratory)
        {
            int countTablet = 0;
            int countComputer = 0;

            for (int i = 1; i <= laboratory.Length; i++)
            {
                if (laboratory.Get(i) is Tablet)
                    countTablet++;
                if (laboratory.Get(i) is Computer)
                    countComputer++;
            }
            return (countTablet, countComputer);
        }
        static public void PrintTechnicOrderByPrice(Laboratory laboratory)
        {
            var temp = laboratory as Laboratory;
            if (temp != null)
            {
                temp.Sort();
            }
            for (int i = 1; i <= laboratory.Length; i++)
            {
                Console.WriteLine(laboratory.Get(i).ToString());
            }
        }
    }
}
