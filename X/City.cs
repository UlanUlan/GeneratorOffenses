using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X
{
    public class City
    {
        public List<Citizen> citizen = new List<Citizen>();
        public void printInfo()
        {
            foreach (Citizen item in citizen)
            {
                Console.WriteLine(item.fullName);
                Console.WriteLine(item.age);
                Console.WriteLine(item.category);
                Console.WriteLine(item.area);
                Console.Write("Offences: ");
                foreach (string i in item.Offenses)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine("\n-----------------------------------------------------\n");
            }
        }
    }
}
