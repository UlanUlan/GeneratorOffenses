using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace X
{
    class Program
    {
        private static Random rand = new Random();

        static void Main(string[] args)
        {
            Service service = new Service("almaty.xml");
         
            City c = Generator.GenerateCity();

            for (int i = 0; i < 100; i++)
                Generator.GeneratorOffenses(c.citizen[rand.Next(0, c.citizen.Count)]);

          
            foreach (var cat in c.citizen.GroupBy(g=>g.category))
            {
                service.XmlSerialize(c.citizen, cat.Key);
            }

            //foreach (Citizen item in XmlDeserialize())
            //{
            //    Console.WriteLine(item.age);
            //    Console.WriteLine(item.category);
            //    Console.WriteLine("----------------------------");
            //}

            
        }

       

    }
}
