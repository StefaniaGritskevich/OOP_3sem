using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace lab12
{
    public class MainClass
    {
        public static void Main()
        {
            GSADiskInfo.AboutDisk();

            GSAFileInfo.AboutFile(@"D:\C#\lab12!\for_12_oop.txt");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("---------------Dir----------------");
            GSADirInfo.AboutDir(@"C:\Program Files");
            Console.WriteLine("-------------------------------------");
            GSADirInfo.AboutDir(@"D:\C#\lab12!");


            GSAFileManager.FileManagment();
            GSAFileManager.XXXFiles(@"D:\C#\lab12!\dirWithExtensions", ".txt");
            GSAFileManager.XXXFilesZIP();

            //

            Console.WriteLine("Выберите нужную информацию:\n1 - DiskInfo\n2 - FileInfo\n3 - DirInfo\n4 - Посчитаь кол-во записей");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    using (StreamReader reader = new StreamReader(@"D:\C#\лфб12\lab12\GSAlogfile.txt"))
                    {
                        Console.WriteLine("|-------DiskInfo-------|");
                        string? line;
                        while ((line = reader.ReadLine()) != null)
                            if (line == "|-------DiskInfo-------|")
                            {
                                while (line != "|-------FileInfo-------|")
                                {
                                    line = reader.ReadLine();
                                    Console.WriteLine(line);
                                }
                                break;
                            }
                    }
                    break;
                case 2:
                    using (StreamReader reader = new StreamReader(@"D:\C#\лфб12\lab12\GSAlogfile.txt"))
                    {
                        Console.WriteLine("|-------FileInfo-------|");
                        string? line;
                        while ((line = reader.ReadLine()) != null)
                            if (line == "|-------FileInfo-------|")
                            {
                                while (line != "|-------DirInfo-------|")
                                {
                                    line = reader.ReadLine();
                                    Console.WriteLine(line);
                                }
                                break;
                            }
                    }
                    break;
                case 3:
                    using (StreamReader reader = new StreamReader(@"D:\C#\лфб12\lab12\GSAlogfile.txt"))
                    {
                        Console.WriteLine("|-------DirInfo-------|");
                        string? line;
                        while ((line = reader.ReadLine()) != null)
                            if (line == "|-------DirInfo-------|")
                            {
                                while ((line = reader.ReadLine()) != null)
                                    Console.WriteLine(line);
                                break;
                            }
                    }
                    break;
                case 4:
                    using (StreamReader reader = new StreamReader(@"D:\C#\лфб12\lab12\GSAlogfile.txt"))
                    {
                        string? line;
                        int k = 0;
                        while ((line = reader.ReadLine()) != null)
                            k++;
                        Console.WriteLine($"Количество записей: {k}");
                    }
                    break;
                default:
                    Console.WriteLine("Неверный вариант. До связи");
                    break;
            }
        }
    }
}