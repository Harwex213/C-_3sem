using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                KOALog.writeToLog("KOADiskInfo.getFreeDrivesSpace()");
                KOADiskInfo.getFreeDrivesSpace();

                KOAFileInfo.getFileinfo(@"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab13\files\KOALog.txt");
                KOALog.writeToLog("KOAFileInfo.getFileinfo()", "KOALog.txt", @"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab13\files\KOALog.txt");

                KOADirInfo.getDirinfo(@"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab13");
                KOALog.writeToLog("KOADirInfo.getDirinfo()", "", @"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab13");

                KOAFileManager.getAllDirsAndFilesOfDisk(@"C:\");
                KOALog.writeToLog("KOAFileManager.getAllDirsAndFilesOfDisk()", "", @"C:\");

                KOAFileManager.getAllFilesWithExtension(@"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab13\files\info", ".txt");
                KOALog.writeToLog("KOAFileManager.getAllDirsAndFilesOfDisk()", "", @"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab13\files\KOAFiles");

                KOAFileManager.createZIP(@"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab13\files\KOAInspect\KOAFiles");
                KOALog.writeToLog("KOAFileManager.createZIP()");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
