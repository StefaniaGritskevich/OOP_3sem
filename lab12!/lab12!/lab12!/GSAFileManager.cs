using System;
using System.IO.Compression;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lab12
{
    class GSAFileManager
    {
        public static void FileManagment()
        {
            string path = @"D:\C#\lab12!\GSAInspect";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
                dirInfo.Create();

            string dirInfoPath = @"D:\C#\lab12!\GSAInspect\GSAdirinfo1.txt";
            FileInfo GSAdirinfo = new FileInfo(dirInfoPath);

            using (StreamWriter writerGSA = new StreamWriter(dirInfoPath, false))
            {
                string dirName = "D:\\";
                if (Directory.Exists(dirName))
                {
                    writerGSA.WriteLine("Подкаталоги");
                    string[] dirs = Directory.GetDirectories(dirName);
                    foreach (string s in dirs)
                        writerGSA.WriteLine(s);
                    writerGSA.WriteLine();
                    writerGSA.WriteLine("Файлы:");
                    string[] files = Directory.GetFiles(dirName);
                    foreach (string s in files)
                        writerGSA.WriteLine(s);

                    string newdirInfoPath = @"D:\C#\lab12!\GSAInspect\GSAdirinfoCOPY1.txt";
                    FileInfo fileInf = new FileInfo(dirInfoPath);
                    if (fileInf.Exists)
                    {
                        fileInf.CopyTo(newdirInfoPath, true);
                    }
                    if (GSAdirinfo.Exists)
                    {
                        try
                        {
                            GSAdirinfo.Delete();
                        }
                        catch (IOException ex)
                        {
                            Console.WriteLine($"Ошибка при удалении файла: {ex.Message}");
                        }
                    }

                }

            }
        }

        public static void XXXFiles(string dirPath, string exten)
        {
            string path = @"D:\C#\lab12!\GSAFiles";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
                dirInfo.Create();


            DirectoryInfo directory = new DirectoryInfo(dirPath);

            if (directory.Exists)
            {
                Console.WriteLine("Файлы:");
                FileInfo[] files = directory.GetFiles();
                foreach (FileInfo file in files)
                {
                    if (file.Extension == exten)
                    {
                        file.CopyTo($"{path}\\{file.Name}", true);
                    }
                }
            }
            string newPath = @"D:\C#\lab12!\GSAInspect\GSAFiles";
            if (dirInfo.Exists && !Directory.Exists(newPath))
            {
                dirInfo.MoveTo(newPath);
            }

        }

        public static void XXXFilesZIP()
        {
            string sourceFolder = @"D:\C#\lab12!\GSAInspect\GSAFiles"; // исходная папка
            string zipFile = @"D:\C#\lab12!\GSAInspect\GSAFiles.zip"; // сжатый файл
            string targetFolder = @"D:\C#\lab12!\forzip"; // папка, куда распаковывается файл

            FileInfo zipFileInfo = new FileInfo(zipFile);
            if (!zipFileInfo.Exists)
            {
                try
                {
                    ZipFile.CreateFromDirectory(sourceFolder, zipFile);
                    Console.WriteLine($"Папка {sourceFolder} архивирована в файл {zipFile}");
                    ZipFile.ExtractToDirectory(zipFile, targetFolder);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Message: {ex.Message}");
                }
            }

            Console.WriteLine($"Файл {zipFile} распакован в папку {targetFolder}");
        }
    }
}
