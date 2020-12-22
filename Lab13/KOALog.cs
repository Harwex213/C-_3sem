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
    }
}
