using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace X
{
    public static class Generator
    {
        private static Random rand = new Random();

        public static void GeneratorOffenses(Citizen c)
        {
            Service sevice = new Service();
            c.Offenses.Add(sevice.GetPrest());
        }

        public static City GenerateCity(int count = 50)
        {
            City c = new City();

            for (int i = 0; i < count; i++)
            {
              //  Thread.Sleep(200);
                c.citizen.Add(new Citizen());
            }

            return c;
        }
    }
}
