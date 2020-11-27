using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    static class StatisticOperation
    {
        public static int SumList(Set set)
        {
            return set.Items.Sum();
        }
        public static int DifferenceMax_Min(Set set)
        {
            return set.Items.Max() - set.Items.Min();
        }
        public static int LengthList(Set set)
        {
            return set.Items.Count();
        }
        public static string FindMinimalWord(this string str)
        {
            string[] words = str.Split(' ');
            string strOut = words.Min();
            
            return strOut;
        }
        public static Set Regulize(Set set)
        {
            set.Items.Sort();
            return set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Set setFirst = new Set();
            Set setFirst1 = new Set();
            Set setSecond = new Set();
            Set.Date.PrintDate();
            setFirst.ThisOwner.WriteOwner();

            for (int i = 0; i < 10; i++)
            {
                setFirst <<= i;
                setFirst1 = setFirst1 << i;
            }
            setFirst.PrintElem();
            setFirst1.PrintElem();

            for (int i = 5; i < 20; i++)
                setSecond = setSecond << i;
            setSecond.PrintElem();
            setSecond = setSecond >> 19;
            setSecond.PrintElem();

            if (setFirst == setFirst1)
                Console.WriteLine("== is work");

            if (setFirst != setSecond)
                Console.WriteLine("!= is work");

            Set setN = new Set();
            setN = setN << 9;
            setN.PrintElem();
            if (setN > setFirst)
                Console.WriteLine("> is work");

            Set setIntersection = setFirst % setSecond;
            setIntersection.PrintElem();

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                setN = setN << rnd.Next(0, 10);
            }
            setN.PrintElem();
            setN = StatisticOperation.Regulize(setN);
            setN.PrintElem();


            string str = "HELLO WORLD IT IS ME OLEG A";
            Console.WriteLine(str.FindMinimalWord());
        }
    }
}
