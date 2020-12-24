using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class KOALog
    {
        static public StreamWriter logfile;

        static KOALog()
        {
            string time = "Time: 12/24/2020 ";
            time += DateTime.Now.Hour.ToString();
            FindInfo(time);
            using (logfile = new StreamWriter(@"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab13\files\KOAlog.txt", false))
            {
                logfile.WriteLine("----------------Logger----------------");
            }
        }

        static public void writeToLog(string action, string fileName = "", string path = "")
        {
            using (logfile = new StreamWriter(@"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab13\files\KOAlog.txt", true))
            {
                DateTime time = new DateTime();
                time = DateTime.Now;
                logfile.WriteLine("------------------------------");
                logfile.WriteLine($"Action: {action}");

                if (fileName.Length != 0)
                    logfile.WriteLine($"File name: {fileName}");

                if (path.Length != 0)
                    logfile.WriteLine($"Path: {path}");

                logfile.WriteLine($"Time: {time.ToLocalTime()}");
                logfile.WriteLine("------------------------------");
            }
        }
        public static void FindInfo(string Name)
        {
            using (StreamReader sr = new StreamReader(@"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab13\files\KOAlog.txt"))
            {
                int num = 0;
                string buff = null;
                string data = "";
                string resultData = "";
                bool findSmth = false;

                while ((buff = sr.ReadLine()) != null)
                {
                    num++;
                    if (buff.Contains("----------------Logger----------------"))
                        continue;
                    if (buff.Contains("----------------------") && data.Contains(Name))
                    {
                        resultData += data;
                        data = "";
                        findSmth = true;
                    }
                    else
                        data += buff + "\n";
                }
                if (findSmth)
                {
                    Console.WriteLine("Совершенные пользователем действия за последний час:");
                    Console.WriteLine(resultData);
                }
                else
                {
                    Console.WriteLine("Пользователь не совершал действий за последний час.");
                }
                Console.WriteLine(num + " строк записей.");
            }
        }
    }
}
