using System;
using System.IO;
using System.IO.Compression;

namespace Lab13
{
    class KOAFileManager
    {
        static public void getAllDirsAndFilesOfDisk(string diskName)
        {
            var allDrives = DriveInfo.GetDrives();
            foreach (var drive in allDrives)
            {
                if (drive.Name == diskName)
                {
                    DirectoryInfo dir = new DirectoryInfo(@"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab13\files");
                    if (dir.GetDirectories("KOAInspect").Length == 0)
                    {
                        DirectoryInfo subDir = dir.CreateSubdirectory("KOAInspect");
                        DirectoryInfo dr = new DirectoryInfo(diskName);
                        using (StreamWriter file = new StreamWriter(subDir.FullName + @"\" + "KOAdirinfo.txt"))
                        {
                            file.WriteLine("----------Directories----------");
                            foreach (var d in dr.GetDirectories())
                                file.WriteLine($"{d.Name}");
                            file.WriteLine("----------------------");

                            file.WriteLine("----------Files----------");
                            foreach (var d in dr.GetFiles())
                                file.WriteLine($"{d.Name}");
                            file.WriteLine("----------------------");
                        }
                        FileInfo dirinfo = new FileInfo(subDir.FullName + @"\" + "KOAdirinfo.txt");
                        dirinfo.CopyTo(subDir.FullName + @"\" + "KOAdirinfoCOPY.txt");
                        dirinfo.Delete();
                    }
                    break;
                }
            }
        }

        static public void getAllFilesWithExtension(string dirPath, string extension)
        {
            DirectoryInfo directory = new DirectoryInfo(dirPath);
            if (directory.Exists)
            {
                DirectoryInfo temp = new DirectoryInfo(@"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab13\files");
                if (temp.GetDirectories("KOAFiles").Length == 0 &&
                    temp.GetDirectories("KOAInspect")[0].GetDirectories("KOAiles").Length == 0)
                {
                    DirectoryInfo Files = temp.CreateSubdirectory("KOAFiles");

                    foreach (var file in directory.GetFiles($"*{extension}"))
                        file.CopyTo(Files.FullName + @"\" + file.Name);

                    Files.MoveTo(temp.GetDirectories("KOAInspect")[0].FullName + "\\KOAFiles");
                }
            }
        }

        static public void createZIP(string dir)
        {
            string zipName = @"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab13\files\KOAInspect\KOAFiles.zip";
            if (new DirectoryInfo(@"C:\Workplace\1University\second_cource\OOTP\Csharp_3sem\Lab13\files\KOAInspect").GetFiles("*.zip").Length == 0)
            {
                ZipFile.CreateFromDirectory(dir, zipName);
                DirectoryInfo direct = new DirectoryInfo(dir);
                foreach (var innerFile in direct.GetFiles())
                    innerFile.Delete();
                direct.Delete();
                ZipFile.ExtractToDirectory(zipName, dir);
            }
        }
    }
}
