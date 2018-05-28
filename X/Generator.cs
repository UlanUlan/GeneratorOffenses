using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X
{
    public static class Generator
    {
        private static Random rand = new Random();
        public static void GeneratorOffenses(Citizen c)
        {
            c.Offenses.Add(rand.Next(1,1000).ToString());
        }
    }
}
