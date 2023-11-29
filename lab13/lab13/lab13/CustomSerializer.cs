using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab13
{
    class CustomSerializer
    {
        public static void Serializer(string filename, Exam name)
        {
            string[] format = filename.Split('.');
            switch (format[1])
            {
                case "bin":
                    {
                        BinaryFormatter binFormatter = new BinaryFormatter();
                        using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                        {
                            binFormatter.Serialize(fs, name);
                            Console.WriteLine($"Object {typeof(Exam)} serialized to {filename}");
                            Console.WriteLine("------------------------------------------------------------");
                        }
                        break;
                    }
                case "json":
                    {
                        DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Exam));
                        using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                        {
                            jsonFormatter.WriteObject(fs, name);
                            Console.WriteLine($"Object {typeof(Exam)} serialized to {filename}");
                            Console.WriteLine("------------------------------------------------------------");
                        }
                        break;
                    }

                case "xml":
                    {
                        XmlSerializer obSer = new XmlSerializer(typeof(Exam));
                        using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                        {
                            obSer.Serialize(fs, name);
                            Console.WriteLine($"Object {typeof(Exam)} serialized to {filename}");
                            Console.WriteLine("------------------------------------------------------------");
                        }
                        break;

                    }
                default:
                    {
                        Console.WriteLine("Wrong Format");
                        break;
                    }

            }
        }

        public static void Deserializer(string fname)
        {
            string[] format = fname.Split('.');
            switch (format[1])
            {
                case "bin":
                    {
                        BinaryFormatter binFormatter = new BinaryFormatter();
                        using (FileStream fr = new FileStream(fname, FileMode.OpenOrCreate))
                        {
                            Exam newP1 = (Exam)binFormatter.Deserialize(fr);
                            Console.WriteLine("Deserialized from file: " + fname + "\n" + newP1.ToString());
                            Console.WriteLine("------------------------------------------------------------");
                        }
                        break;
                    }
                case "json":
                    {
                        DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Exam));
                        using (FileStream fr = new FileStream(fname, FileMode.OpenOrCreate))
                        {
                            Exam newP1 = (Exam)jsonFormatter.ReadObject(fr);
                            Console.WriteLine("Deserialized from file: " + fname + "\n" + newP1.ToString());
                            Console.WriteLine("------------------------------------------------------------");
                        }
                        break;
                    }

                case "xml":
                    {
                        XmlSerializer obSer = new XmlSerializer(typeof(Exam));
                        using (FileStream fr = new FileStream(fname, FileMode.OpenOrCreate))
                        {
                            Exam newP1 = (Exam)obSer.Deserialize(fr);
                            Console.WriteLine("Deserialized from file: " + fname + "\n" + newP1.ToString());
                            Console.WriteLine("------------------------------------------------------------");
                        }
                        break;

                    }
            }
        }
    }
}