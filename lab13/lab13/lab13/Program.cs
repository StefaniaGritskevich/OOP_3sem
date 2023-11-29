using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam exam1 = new Exam("Математика", 3, 45);
            Exam exam2 = new Exam("Механика", 6, 90);
            Exam exam3 = new Exam("Биология", 2, 120);

            Console.WriteLine("Бинарная сериализация");
            CustomSerializer.Serializer("check1.bin", exam1);
            Console.WriteLine("JSON сериализация");
            CustomSerializer.Serializer("check2.json", exam2);

            Console.WriteLine("XML сериализация");
            CustomSerializer.Serializer("check3.xml", exam3);

            Console.WriteLine("\n\nБинарная десериализация");
            CustomSerializer.Deserializer("check1.bin");
            Console.WriteLine("JSON десериализация");
            CustomSerializer.Deserializer("check2.json");

           Console.WriteLine("XML десериализация");
            CustomSerializer.Deserializer("check3.xml");

            XmlSerializer serializer = new XmlSerializer(typeof(List<Exam>));
            List<Exam> checks = new List<Exam>();
            checks.Add(exam1);
            checks.Add(exam2);
            checks.Add(exam3);

            using (FileStream fs = new FileStream("Collection.xml", FileMode.Create))
            {
                serializer.Serialize(fs, checks);
            }

            Console.WriteLine("XML сериализация коллекции");
            using (FileStream fr = new FileStream("Collection.xml", FileMode.Open))
            {
                List<Exam> newLst = (List<Exam>)serializer.Deserialize(fr);
                foreach (var item in newLst)
                {
                    Console.WriteLine($"Десеарелизован: " + item.ToString());
                }
            }
            //////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n--------Селекторы XPath--------\n");
                XmlDocument doc = new XmlDocument();
                doc.Load("check3.xml");

                //XPath
                XmlNodeList examNodes = doc.SelectNodes("//Exam");
                foreach (XmlNode node in examNodes)
                {
                    Console.WriteLine($"Предмет: {node.SelectSingleNode("Goal").InnerText}");
                    Console.WriteLine($"Время выполнения: {node.SelectSingleNode("Time").InnerText}");
                }

                Console.WriteLine("--------------------------------------");

                
                XmlNodeList goalNodes = doc.SelectNodes("//Grade");
                foreach (XmlNode node in goalNodes)
                {
                    Console.WriteLine($"Оценка: {node.InnerText}");
                }
                ////////////////////////////////////////////////////////////////


                // Создание нового XML-документа
                XDocument docс = new XDocument(
                    new XElement("Root",
                        new XElement("Person",
                            new XElement("Name", "John"),
                            new XElement("Age", 30)
                        ),
                        new XElement("Person",
                            new XElement("Name", "Alice"),
                            new XElement("Age", 25)
                        )
                    )
                );

                //LINQ to XML
                var names = docс.Descendants("Name") //возвращает все потомки элемента удовлетворяющие заданному имени "Name
                    .Select(e => e.Value)
                    .ToList();

                Console.WriteLine("Имена:");
                foreach (var name in names)
                {
                    Console.WriteLine(name);
                }

                Console.WriteLine("--------------------------------------");

                // Добавление нового элемента в XML-документ
                docс.Root.Add(new XElement("Person",
                    new XElement("Name", "Bob"),
                    new XElement("Age", 35)
                ));

                // после добавления нового элемента
                var ages = docс.Descendants("Age")
                    .Select(e => int.Parse(e.Value))//преобразует в целочисленный тип
                    .ToList();

                Console.WriteLine("Возраста:");
                foreach (var age in ages)
                {
                    Console.WriteLine(age);
                }

                // Сохранение XML-документа в файл
                docс.Save("new_document.xml");
            }
        }
    }