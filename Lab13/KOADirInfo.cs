using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class KOADirInfo
    {
        static DirectoryInfo getParentDirs(DirectoryInfo dirInfo)
        {
            if (dirInfo == null)
                return dirInfo;

            Console.WriteLine($"{dirInfo.Name}");
            return getParentDirs(dirInfo.Parent);
        }

        static public void getDirinfo(string dir)
        {
            System.Console.WriteLine("----------------------");
            DirectoryInfo dirInfo = new DirectoryInfo(dir);
            if (!dirInfo.Exists)
                throw new Exception($"Directory {dirInfo.Name} dosn't found");
            Console.WriteLine($"Count of subdirectories: {dirInfo.GetDirectories().Length}");
            Console.WriteLine($"Count of subfiles: {dirInfo.GetFiles().Length}");
            Console.WriteLine($"Directory create time: {dirInfo.CreationTime}");
            Console.WriteLine("\nParent directories:");
            getParentDirs(dirInfo.Parent);
            System.Console.WriteLine("----------------------");
        }
    }
}
