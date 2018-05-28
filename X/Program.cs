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
        static void Main(string[] args)
        {
            Random rand = new Random();
            City c = new City();
            for (int i = 0; i < 200; i++)
            {
                c.citizen.Add(new Citizen());
            }



            for (int i = 0; i < 100; i++)
            {
                Generator.GeneratorOffenses(c.citizen[rand.Next(10)]);
            }

            //c.printInfo();

           
            XmlSerialize(c.citizen, (Category)rand.Next(0,9));

            foreach (Citizen item in XmlDeserialize())
            {
                Console.WriteLine(item.age);
                Console.WriteLine(item.category);
                Console.WriteLine("----------------------------");
            }
        }

        public static void XmlSerialize(List<Citizen> citizen, Category _category)
        {
            List<Citizen> citizen1 = citizen.Where(category => category.category == _category).ToList();

            XmlSerializer formatter = new XmlSerializer(typeof(List<Citizen>));                      
            using (FileStream fs = new FileStream(citizen + ".xml", FileMode.OpenOrCreate))
            {
                //formatter.Serialize(fs, citizen.Where(category => category.category == _category).ToList());
                formatter.Serialize(fs, citizen1);
            }
        }

        public static List<Citizen> XmlDeserialize()
        {
            List<Citizen> citizen = new List<Citizen>();
            XmlSerializer formatter = new XmlSerializer(typeof(List<Citizen>));                      
            using (FileStream fs = new FileStream(citizen + ".xml", FileMode.OpenOrCreate))
            {
                citizen = (List<Citizen>)formatter.Deserialize(fs);
            }

            return citizen;
        }


    }
}
