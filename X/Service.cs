using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace X
{
    public class Service
    {
        public Service() : this(""){}
        public Service(string path)
        {
            this.path = path;
            GetPrestFromFile();
        }

        private string path { get; set; }

        public void XmlSerialize(List<Citizen> citizen, Category category)
        {
            List<Citizen> citizen1 = citizen.Where(w => w.category == category).ToList();

            XmlSerializer formatter = new XmlSerializer(typeof(List<Citizen>));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, citizen1);
            }
        }

        public List<Citizen> XmlDeserialize()
        {
            List<Citizen> citizen = new List<Citizen>();

            XmlSerializer formatter = new XmlSerializer(typeof(List<Citizen>));

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                citizen = (List<Citizen>)formatter.Deserialize(fs);
            }

            return citizen;
        }

        private List<string> prest = new List<string>();

        private void GetPrestFromFile(string patht= "vidy.txt")
        {
            FileInfo fiT1 = new FileInfo(patht);
            string sb;

            using (StreamReader sr = new StreamReader(patht, Encoding.GetEncoding(1251)))
            {
                sb = sr.ReadToEnd();
            }

          
            foreach (string item in sb.Split(';'))
            {
                prest.Add(item);
            }

            foreach (string item in prest)
            {
                Console.WriteLine(item);
            }

        }

        private Random rnd = new Random();
        public string GetPrest()
        {
            return prest.ElementAt(rnd.Next(0, prest.Count));
        }
    }
}
