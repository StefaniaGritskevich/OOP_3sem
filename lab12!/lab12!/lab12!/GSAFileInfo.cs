using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class GSAFileInfo
    {
        public static void AboutFile(string path)
        {
            GSALog.Log("-------FileInfo-------");
            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                Console.WriteLine($"Полный путь: {path}");
                Console.WriteLine($"Имя файла: {Path.GetFileNameWithoutExtension(path)}");
                Console.WriteLine($"Время создания: {fileInfo.CreationTime}");
                Console.WriteLine($"Размер: {fileInfo.Length}");
                Console.WriteLine($"Расширение: {fileInfo.Extension}");
                Console.WriteLine($"Полный путь 2: {fileInfo.DirectoryName}");
                Console.WriteLine($"Полный путь 3: {fileInfo.Directory}");

                GSALog.Log($"Полный путь: {path}");
                GSALog.Log($"Имя файла: {Path.GetFileNameWithoutExtension(path)}");
                GSALog.Log($"Время создания: {fileInfo.CreationTime}");
                GSALog.Log($"Размер: {fileInfo.Length}");
                GSALog.Log($"Расширение: {fileInfo.Extension}");
                GSALog.Log($"Полный путь 2: {fileInfo.DirectoryName}");
                GSALog.Log($"Полный путь 3: {fileInfo.Directory}");
            }
        }
    }
}
