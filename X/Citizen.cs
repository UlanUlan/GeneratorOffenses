using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace X
{
    public enum Category { Physical=1, Legal, Invalid, Capable, NotCapable, Child, Teen, Young, Man, Woman }
    public enum Area { Auez=1, Alatau, Almal, Bost, Jetys, Medeu, Nauryz, Turksib }
    [Serializable]
    public class Citizen
    {
        public List<string> Offenses = new List<string>();

        public Citizen()
        {
            Random rand = new Random();

            fullName = "XJ" + rand.Next(1, 200);
            age = rand.Next(12, 100);
            category = (Category)rand.Next(1, 9);
            area = (Area)rand.Next(1, 8);
        }
        public string fullName { get; set; }
        public int age { get; set; }
        public Category category { get; set; }
        public Area area { get; set; }
    }
}
