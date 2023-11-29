using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class GSADirInfo
    {
        public static void AboutDir(string dirName)
        {
            GSALog.Log("-------DirInfo-------");
            DirectoryInfo dirinfo = new DirectoryInfo(dirName);
            GSALog.Log("|-------DirInfo-------|");
            DirectoryInfo directory = new DirectoryInfo(dirName);

            if (directory.Exists)
            {
                Console.WriteLine("Подкаталоги:");
                GSALog.Log("Подкаталоги:");
                DirectoryInfo[] dirs = directory.GetDirectories();
                foreach (DirectoryInfo dir in dirs)
                {
                    Console.WriteLine(dir.FullName);
                    GSALog.Log(dir.FullName);
                }
                Console.WriteLine($"Количество поддиректориев: {dirs.Length}");
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                GSALog.Log($"Количество поддиректориев: {dirs.Length}");
                GSALog.Log("\n");
                GSALog.Log("Файлы:");
                FileInfo[] files = directory.GetFiles();
                foreach (FileInfo file in files)
                {
                    Console.WriteLine(file.FullName);
                    GSALog.Log(file.FullName);
                }
                Console.WriteLine($"Количество файлов: {files.Length}");
                Console.WriteLine($"Дата создания директория: {Directory.GetCreationTime(dirName)}");
                Console.WriteLine($"Родительский каталог: {Directory.GetParent(dirName)}");
                GSALog.Log($"Количество файлов: {files.Length}");
                GSALog.Log($"Дата создания директория: {Directory.GetCreationTime(dirName)}");
                GSALog.Log($"Родительский каталог: {Directory.GetParent(dirName)}");
            }

        }
    }
}
