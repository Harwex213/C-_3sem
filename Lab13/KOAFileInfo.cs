using System.IO;

namespace Lab13
{
    class KOAFileInfo
    {
        static public void getFileinfo(string file)
        {
            System.Console.WriteLine("----------------------");
            FileInfo fileInfo = new FileInfo(file);
            if (!fileInfo.Exists)
            {
                System.Console.WriteLine("File has not found");
                return;
            }
            System.Console.WriteLine($"Full puth: {fileInfo.FullName}");
            System.Console.WriteLine($"Size: {fileInfo.Length} byte");
            System.Console.WriteLine($"Full extension: {fileInfo.Extension}");
            System.Console.WriteLine($"Name: {fileInfo.Name}");
            System.Console.WriteLine($"Full create time: {fileInfo.CreationTime}");
            System.Console.WriteLine($"Last access time: {fileInfo.LastAccessTime}");
            System.Console.WriteLine("----------------------");
        }
    }
}
