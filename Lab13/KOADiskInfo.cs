using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class KOADiskInfo
    {
        static public void getFreeDrivesSpace()
        {
            var allDrives = System.IO.DriveInfo.GetDrives();
            foreach (var drive in allDrives)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine($"Drive name: {drive.Name}");
                Console.WriteLine($"Drive type: {drive.DriveType}");
                if (!drive.IsReady) continue;
                Console.WriteLine($"Volume Label: {drive.VolumeLabel}");
                Console.WriteLine($"File system: {drive.DriveFormat}");
                Console.WriteLine($"Root: {drive.RootDirectory}");
                Console.WriteLine($"Total size: {drive.TotalSize / Math.Pow(10, 9)} Gbyte");
                Console.WriteLine($"Free size: {drive.TotalFreeSpace / Math.Pow(10, 9)} Gbyte");
                Console.WriteLine($"Available: {drive.AvailableFreeSpace / Math.Pow(10, 9)} Gbyte");
                Console.WriteLine("----------------------");
            }
        }
    }
}
