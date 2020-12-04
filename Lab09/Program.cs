using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Program
    {
        public static string DeletePunctSigns(string str)
        {
            StringBuilder rc = new StringBuilder();

            for (int i = 0, j = 0; i < str.Length; i++)
                if (str[i] != ',' && str[i] != '.' && str[i] != '!' && str[i] != ':' && str[i] != ';' && str[i] != '?')
                    rc.Append(str[i], 1);

            Console.WriteLine($"Строка без знаков пунктуации: {rc}");
            return rc.ToString();
        }
        public static string ToUpperCase(string str)
        {
            Console.WriteLine($"Строка в верхнем регистре: {str.ToUpper()}");
            return str.ToUpper();
        }
        public static string DeleteUnnecessarySpace(string str)
        {
            StringBuilder rc = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
                if (str[i] == ' ')
                {
                    rc.Append(str[i], 1);
                    while (str[i + 1] == ' ')
                        i++;
                }
                else
                    rc.Append(str[i], 1);
            Console.WriteLine($"Строка без лишних пробелов: {rc}");
            return rc.ToString();
        }
        public static void AddSymbols(string str, string additionSymbols)
        {
            str += additionSymbols;

            Console.WriteLine($"Result: {str}");
        }
        static void Main(string[] args)
        {
            var orc = new Orc();
            orc.Attack += delegate (IGameObject obj)
            {
                Console.WriteLine("Attack Event!");
                obj.HP -= orc.AttackPower - (int)orc.Weapon;
                Console.WriteLine($"HP after attack {obj.HP}");
            };
            var human = new Human();
            human.Attack += (obj) => 
            {
                Console.WriteLine("Attack Event!");
                obj.HP -= human.AttackPower - (int)human.Weapon;
                Console.WriteLine($"HP after attack {obj.HP}");
            };

            var elf = new Elf();
            elf.Attack += (obj) =>
            {
                Console.WriteLine("Attack Event!");
                elf.HP -= elf.AttackPower - (int)elf.Weapon;
                Console.WriteLine($"HP after attack {obj.HP}");
            };
            elf.Attack += (obj) => Console.WriteLine("Second Attack Event!");
            elf.Heal += (obj) =>
            {
                Console.WriteLine("Heal Event!");
                obj.HP += 50;
                Console.WriteLine($"HP after attack {obj.HP}");
            };

            orc.SeeSomeBody(human);
            elf.SeeSomeBody(human);
            elf.SeeSomeBody(orc);

            Action<string, string> action = AddSymbols;
            action("Hello", " World");

            Func<string, string> func = DeletePunctSigns;
            func += ToUpperCase;
            func += DeleteUnnecessarySpace;

            string result = func("Salute!       Omg, so much white      spaces. !!! WOW ?");
        }
    }
}
