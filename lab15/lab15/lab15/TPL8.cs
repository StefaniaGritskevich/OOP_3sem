using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Serialization;


namespace lab15
{
    static class TPL8
    {
        public static async Task Task8()
        {

            List<Product> data = new();

            await Task.Run(() => data = GetProducts());
            Console.WriteLine("-----------Задание 8---------");

            foreach (var product in data)
            {
                Console.WriteLine(product);
            }
        }

        public static List<Product> GetProducts()
        {
            List<Product> list = new();

            using StreamReader sr = new("products.json");
            int cnt = 0;
            string json;
            while (!sr.EndOfStream && cnt++ < 200)
            {
                json = sr.ReadLine() ?? "";
               // list.Add(JsonSerializer.Deserialize<Product>(json));
                Thread.Sleep(200);
            }

            return list;
        }
    }
}
