using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class GSALog
    {
        static string filePath = @"D:\C#\lab12!\gsalogfile.txt";

        static GSALog()
        {
            using (StreamWriter writerGSA = new StreamWriter(filePath, false))
                writerGSA.WriteLine(DateTime.Now);
        }

        public static void Log(string str)
        {
            using (StreamWriter writerGSA = new StreamWriter(filePath, true))
                writerGSA.WriteLine(str);
        }
    }
}
