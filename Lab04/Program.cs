using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Set<int> tempVar1 = new Set<int>(9, 11, 31, 12, 10);
                Set<int> tempVar2 = new Set<int>(9, 11, 31, 31023, 12, 10);
                if (tempVar1 == tempVar2)
                    Console.WriteLine("tempVar1 == tempVar2!");
                if (tempVar1 < tempVar2)
                    Console.WriteLine($"tempVar1 является подмножеством tempVar2!");
                Set<int> tempVar3 = new Set<int>(11, 31, 12, 3101, 3123);
                var tempVar4 = tempVar3 % tempVar2;
                tempVar4.PrintCollection();
                int x = 40 ^ 20;
                tempVar1.WriteInFile();
                Set<int>.ReadInFile();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("That all.");
            }
        }
    }
}
