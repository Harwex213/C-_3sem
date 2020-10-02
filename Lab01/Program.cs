using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks.Dataflow;

namespace Lab1
{
	class Program
	{
		struct A
		{ public int Val; }
		static void Main(string[] args)
		{
			//Задание 1. Типы
			//a)
			bool arg1 = Equals("Hello", "Hello");
			int varX = 12;
			arg1 = varX.Equals(12);
			arg1 = varX.Equals(19);
			byte arg2 = byte.MaxValue;
			sbyte arg3 = sbyte.MinValue;
			short arg4 = short.MaxValue;
			ushort arg5 = ushort.MaxValue;
			int arg6 = int.MaxValue;
			uint arg7 = uint.MaxValue;
			long arg8 = long.MaxValue;
			ulong arg9 = ulong.MaxValue;
			char arg13 = 'a';
			float arg10 = 12.3F;
			double arg11 = 400.3123;
			decimal arg12 = 1000.0M;
			Console.WriteLine("---------------------------------------------\nТИПЫ\n---------------------------------------------");
			Console.WriteLine($"a)\nbool: {arg1}\nbyte: {arg2}\nsbyte: {arg3}\nshort: {arg4}\nushort: {arg5}\nint: {arg6}\n" +
				$"uint: {arg7}\nlong: {arg8}\nulong: {arg9}\nfloat: {arg10}\ndouble: {arg11}\ndecimal: {arg12}\nchar: {arg13}");

			//b)
			//Неявное преобразование
			float fVar = 78.12F;
			double dVar = fVar;

			char cVar = 'b';
			int iVar = cVar;

			byte bVar = 255;
			int iVar2 = bVar;

			int iVar3 = 99999;
			long lVar = iVar3;

			short sVar = 12432;
			long lVar2 = sVar;
			//Явное
			byte var1 = 4;
			byte var2 = (byte)(var1 + 70);

			long  varNn= 1023102401240;
			int VarNn1 = (int)varNn;

			float var3 = 8431.13F;
			int var4 = (int)var3;

			int varN = 0;
			bool varN1 = Convert.ToBoolean(varN);
			byte varN2 = Convert.ToByte(varN);
			bool varN3 = true;
			int VarN4 = Convert.ToInt32(varN3);

			//c)
			Int32 value1 = 10;
			Int16 value2 = 11;
			Double value3 = 12.1;
			Object link1 = value1;
			Object link2 = value2;
			Object link3 = value3;

			byte resultValue1 = (byte)(int)link1;
			byte resultValue2 = (byte)(short)link2;
			float resultValue3 = (float)(double)link3;

			//d)
			var name = "Joker";
			var age = 33;
			var man = true;
			//man = 0;
			Console.WriteLine($"\nd)\nvar name = 'Joker'. Type: {name.GetType()}\nvar age = 26. Type: {age.GetType()}" +
				$"\nvar man'. Type: {man.GetType()}");

			//e)
			int? x = null;
			Nullable<int> x1 = 5;
			if (x.HasValue)
			{
				int x2 = (int)x1;
				int? x3 = x2;
			}
			int t = x ?? 1;
			Console.WriteLine($"\ne)\n{t}");

			//Задание 2. Строки
			Console.WriteLine("---------------------------------------------\nСТРОКИ\n---------------------------------------------");
			//a)
			Console.WriteLine("a)");
			if (!Equals("Hello", "World")) //Compare(), ==, StringComparison
				Console.WriteLine("It's not a good day for the Hello Word today");

			string stringvar1 = "One";
			string stringvar2 = "Second";
			Object link4 = stringvar1;
			Object link5 = stringvar2;

            if (link4 == link5)
				Console.WriteLine("Right");

			//b)
			Console.WriteLine("b)");
			string string1 = "Hello";
			string string2 = "Word";
			string string3 = "!";
			string string4 = string1 + ", " + string2 + string3; // String.
			
			string string5 = String.Copy(string3);
			string string991 = "hello";
			string string123 = (string)string991.Clone();
			int varInt = string4.IndexOf(string2);
			string[] words = string4.Split(new char[] { ' ', ',' });
			string1 = string1.Insert(0, "Not");
			string1 = string1.Replace("Not", "");

			//c)
			Console.WriteLine("c)");
			string emptyString = "";
			string nullString = null;
            if (String.IsNullOrEmpty(emptyString) && String.IsNullOrEmpty(nullString))
                Console.WriteLine("Strings are null or empty");

			//d)
			Console.WriteLine("d)");
			StringBuilder sbString = new StringBuilder("Hello World");
			sbString.Insert(0, "It's ");
			sbString.Remove(0, 1);
			sbString.Replace("World", "Мир");
			sbString.AppendLine(" 02.10.20");
			Console.WriteLine(sbString);

			//Задание 3. Массивы
			Console.WriteLine("---------------------------------------------\nМАССИВЫ\n---------------------------------------------");
			//a)
			Console.WriteLine("a)");
			int[,] myArr = new int[10, 10];
			int counter = 0;
			for (int i = 0; i < 10; i++)
			{
				counter = i;
				for (int j = 0; j < 10; j++)
				{
					myArr[i, j] = counter;
					counter++;
					Console.Write($"{myArr[i, j]}\t ");
				}
				Console.WriteLine("\n");
			}
			//b)
			Console.WriteLine("b)\n");

			string[] strArray = new string[] { "Why", "are", "we", "here", "?" };

			Console.Write($"String array: ");
			foreach (var item in strArray)
				Console.Write(item+' ');
			Console.WriteLine("\nВведите позицию:");
			int position = Convert.ToInt32(Console.ReadLine())-1;
			/*	Отличие от Convert.To(): Если точно известно что в метод придёт строка, то лучше
			использовать TryParse(В отличие от Parse возвращает true || false);
			если не понятно что прилетит в метод, то безопаснее Convert, который также использует
			Parse (и Parse для строк работает быстрее)												*/
			strArray[position] = Console.ReadLine();
			Console.Write("New string array: ");
			foreach (var item in strArray)
				Console.Write(item +' ');	
			//c)
			Console.WriteLine("\nc)");
			int[][] steparr = new int[3][];
			steparr[0] = new int[2];
			steparr[1] = new int[3];
			steparr[2] = new int[4];
			counter = 0;
			for (int i = 0; i < steparr.Length; i++)
			{
				Console.Write($"array[{i}]:\t");
				for (int j = 0; j < steparr[i].Length; j++)
				{
					steparr[i][j] = counter;
					counter++;
					Console.Write($"{steparr[i][j]}\t");

				}
				Console.WriteLine("\n");
			}
			//d)
			Console.WriteLine("d)");
			var implicitArr1 = new[] { "Hello World" };
			var implicitArr2 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			//Задание 4. Кортежи
			Console.WriteLine("---------------------------------------------\nКОРТЕЖИ\n---------------------------------------------");
			//a)
			(int, string, char, string, ulong) values = (321, "Hello", 'd', "World", 82381);

			//b)
			Console.WriteLine(values);
			Console.WriteLine(values.Item1 + " " + values.Item3 + " " + values.Item5);

			//c)
			string s1 = values.Item2;
			(var a, var b, var c, var d, var e) = values;
			(var a2, _, var c2, var d2, var e2) = values;
			(int, string, char, string, ulong) srsf = (321, "Hello", 'd', "World", 82381);

			//d)
			if (values == srsf) Console.WriteLine("true");


			//Задание 5. local function
			Console.WriteLine("---------------------------------------------\nЛокальная функция\n---------------------------------------------");
			Random rnd = new Random();
			(int, int, int, char) vls = LocalFunction(new int[] { rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10) }, "hello");
			Console.WriteLine(vls);

			//Задание 6. Checked/Unchecked
			Console.WriteLine("---------------------------------------------\nCHECKED/UNCHECKED\n---------------------------------------------");
			UnCheckFunction();
			CheckFunction();

			Console.ReadLine();
		}

		static (int, int, int, char) LocalFunction(int[] array, string str)
		{
			Array.Sort(array);
			int max = array[array.Length - 1];
			int min = array[0];
			int sum = 0;
			foreach (var item in array)
				sum += item;
			return (max, min, sum, str[0]);
		}

		static void CheckFunction()
		{
			checked
			{
				long maxmax = (long)int.MaxValue + 1;
				int max = (int)maxmax;
			}
		}

		static void UnCheckFunction()
		{
			unchecked
			{
				int max = int.MaxValue;
			}
		}
	}
}
