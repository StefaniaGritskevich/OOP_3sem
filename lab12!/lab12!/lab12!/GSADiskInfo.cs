using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class GSADiskInfo
    {
        public static void AboutDisk()
        {
            GSALog.Log("-------Disk Info-------");

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");

                GSALog.Log($"Название: {drive.Name}");
                GSALog.Log($"Тип: {drive.DriveType}");


                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем диска: {drive.TotalSize}");
                    Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка диска: {drive.VolumeLabel}");
                    Console.WriteLine($"Файловой системе : {drive.DriveFormat}");

                    GSALog.Log($"Объем диска: {drive.TotalSize}");
                    GSALog.Log($"Свободное пространство: {drive.TotalFreeSpace}");
                    GSALog.Log($"Метка диска: {drive.VolumeLabel}");
                    GSALog.Log($"Файловой системе : {drive.DriveFormat}");
                }
                Console.WriteLine();
            }
        }
    }
}
